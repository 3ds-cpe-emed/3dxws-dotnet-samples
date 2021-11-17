//------------------------------------------------------------------------------------------------------------------------------------
// Copyright 2020-2021 Dassault Systèmes - CPE EMED
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify,
// merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished
// to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES 
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS
// BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//------------------------------------------------------------------------------------------------------------------------------------

using ds.authentication;
using ds.authentication.ui.win;
using ds.emedcpe.samples.ein.csv;
using ds.emedcpe.samples.ein.model;
using ds.enovia.common.collection;
using ds.enovia.common.search;
using ds.enovia.dseng.exception;
using ds.enovia.dseng.mask;
using ds.enovia.dseng.model;
using ds.enovia.dseng.service;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyCsvParser;
using TinyCsvParser.Mapping;

namespace ds.emedcpe.samples.ein
{
    public partial class AssignEINEngItemsForm : Form
    {
        EngineeringServices m_engineeringServices = null;

        private BindingSource m_bindingSource = new BindingSource();

        List<Tuple<string, string>> m_columnPropName = new List<Tuple<string, string>>();

        bool m_useSearchIndex = false;

        public AssignEINEngItemsForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_searchResultGridView.AutoGenerateColumns = false;
            m_searchResultGridView.DataSource = m_bindingSource;

            m_searchResultGridView.MultiSelect = false;

            InitializeColumnAndPropertyNames(ref m_columnPropName);

            m_bindingSource.AllowNew = false;
            InitializeGridColumns(m_searchResultGridView, m_columnPropName);

            UpdateUI();
        }

        private void InitializeColumnAndPropertyNames(ref List<Tuple<string, string>> _columnPropName)
        {
            _columnPropName.Add(new Tuple<string, string>("PhysicalId", "Physical Id"));
            _columnPropName.Add(new Tuple<string, string>("Title", "Title/Name"));
            _columnPropName.Add(new Tuple<string, string>("Revision", "Revision"));
            _columnPropName.Add(new Tuple<string, string>("CollabSpace", "Collab.Space"));
            _columnPropName.Add(new Tuple<string, string>("ProposedEIN", "Proposed EIN"));
            _columnPropName.Add(new Tuple<string, string>("ExistingEIN", "Existing EIN"));
            _columnPropName.Add(new Tuple<string, string>("LastUpdateStatus", "Last Update Status"));
        }

        private void InitializeGridColumns(DataGridView _datagridView, List<Tuple<string, string>> _columnPropNameList)
        {
            foreach (Tuple<string, string> columnPropName in _columnPropNameList)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = columnPropName.Item1;
                column.Name = columnPropName.Item2;
                _datagridView.Columns.Add(column);
            }
        }

        private IPassportAuthentication Passport { get; set; }

        private async void m_searchButton_Click(object sender, EventArgs e)
        {
            if (m_engineeringServices == null) return;
            if (Passport == null) return;
            if (!Passport.IsValid()) { return; }

            // 1.0 - Select, read, validate and parse the CSV file into useful structures
            string einMappingCSVFilename = "";

            // 1.1 - Select CSV file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select EIN CSV Mapping File";
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            einMappingCSVFilename = openFileDialog.FileName;

            if (!File.Exists(einMappingCSVFilename))
            {
                return;
            }

            //1.2 - Using TinyCSV (NUGET) to read, validate and parse the CSV
            //https://bytefish.github.io/TinyCsvParser

            this.Cursor = Cursors.WaitCursor;

            DateTime startTime = DateTime.Now;

            try
            {
                CsvHeaderOptions headerOptions = new CsvHeaderOptions(einMappingCSVFilename);

                CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');
                CsvEinMapping csvMapper = new CsvEinMapping(headerOptions);
                CsvParser<ItemProposedEIN> csvParser = new CsvParser<ItemProposedEIN>(csvParserOptions, csvMapper);

                List<CsvMappingResult<ItemProposedEIN>> itemProposedEINCsvParsedResult = csvParser
                    .ReadFromFile(einMappingCSVFilename, Encoding.UTF8)
                    .ToList();

                long itemProposedEINRows = itemProposedEINCsvParsedResult.Count;

                m_bindingSource.Clear();

                int i = 0;
                // 2.0 - Check if the choosen UID value of the elements already exist
                foreach (CsvMappingResult<ItemProposedEIN> itemProposedEINMap in itemProposedEINCsvParsedResult)
                {
                    ItemProposedEIN itemProposedEIN = itemProposedEINMap.Result;

                    this.Cursor = Cursors.WaitCursor;

                    SearchQuery searchQuery = null;

                    if ((headerOptions.UsesTitle) && (headerOptions.UsesCollabSpace))
                    {
                        searchQuery = new SearchByTitleRevision(itemProposedEIN.Title, itemProposedEIN.Revision, itemProposedEIN.CollabSpace);
                    }
                    else
                    {
                        if ((headerOptions.UsesName) && (!headerOptions.UsesCollabSpace))
                        {
                            searchQuery = new SearchByNameRevision(itemProposedEIN.Title, itemProposedEIN.Revision);
                        }
                    }

                    string mask = EngineeringSearchMask.Details.ToString();

                    NlsLabeledItemSet<EngineeringItem> page = await m_engineeringServices.Search(searchQuery, 0, 5, mask);

                    if ((page == null) || (page.totalItems == 0))
                    {
                        continue;
                    }

                    // Allowing multiple values returned
                    foreach (EngineeringItem item in page.member)
                    {
                        ItemProposedEIN cloneItemProposedEIN = itemProposedEIN.Clone();

                        //this was introduced because the search result depends on the indexing and we 
                        //might not see immediately the result of setting an EIN 
                        if (!m_useSearchIndex)
                        {
                            EnterpriseReference engRef = await m_engineeringServices.GetEnterpriseReference(item);
                            item.enterpriseReference = engRef;
                        }

                        cloneItemProposedEIN.Item = item;
                        cloneItemProposedEIN.PhysicalId = item.id;
                        cloneItemProposedEIN.CollabSpace = item.collabspace;

                        if (null != item.enterpriseReference)
                        {
                            cloneItemProposedEIN.ExistingEIN = item.enterpriseReference.partNumber;
                        }

                        m_bindingSource.Add(cloneItemProposedEIN);

                        DataGridViewRow row = m_searchResultGridView.Rows[i];

                        if ((null == cloneItemProposedEIN.ExistingEIN) || ("" == cloneItemProposedEIN.ExistingEIN))
                        {
                            row.Cells[4].Style.BackColor = Color.LightGreen;
                            row.Cells[5].Style.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            if (cloneItemProposedEIN.ExistingEIN != cloneItemProposedEIN.ProposedEIN)
                            {
                                row.Cells[4].Style.BackColor = Color.LightYellow;
                                row.Cells[5].Style.BackColor = Color.LightYellow;
                            }
                        }

                        //Visually flag duplicated items
                        if (page.totalItems > 1)
                        {
                            DataGridViewCellCollection rowCells = row.Cells;

                            foreach (DataGridViewCell rowCell in rowCells)
                            {
                                rowCell.Style.ForeColor = Color.Red;
                            }
                        }

                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void m_loginButton_Click(object sender, EventArgs e)
        {
            AuthenticationSelectionForm authSelectionForm = new AuthenticationSelectionForm();

            if (authSelectionForm.ShowDialog(this) != DialogResult.OK)
                return;

            IAuthenticationType authenticationType = authSelectionForm.SelectedAuthenticationType;

            if (authenticationType.ShowForm(this) == DialogResult.OK)
            {
                AuthenticationInfo authInfo = authenticationType.GetAuthenticationInfo();

                if (authInfo.IsValidAuthentication)
                {
                    Passport = authInfo.Passport;

                    string securityContext = authInfo.SecurityContext;
                    string enoviaURL = authInfo.EnoviaURL;

                    m_userLoginInfo.Text = authInfo.LoginMessage;

                    m_engineeringServices = new EngineeringServices(enoviaURL, Passport);

                    m_engineeringServices.SecurityContext = securityContext;
                    m_engineeringServices.Tenant = authInfo.Tenant;
                }
            }

            UpdateUI();
        }

        private void UpdateUI()
        {
            if ((Passport != null) && Passport.IsValid())
            {
                m_searchButton.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                m_searchButton.Enabled = false;
                button1.Enabled = false;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int stats_updated = 0;
            int stats_total = m_bindingSource.Count;

            foreach (ItemProposedEIN itemProposedChange in m_bindingSource)
            {
                itemProposedChange.LastUpdateStatus = "-";
            }
            m_bindingSource.ResetBindings(false);

            try
            {
                int i = 0;

                foreach (ItemProposedEIN itemProposedChange in m_bindingSource)
                {
                    EnterpriseReference entRefUpdated = null;

                    if ((null != itemProposedChange.Item) && (null != itemProposedChange.ProposedEIN))
                    {
                        EngineeringItem engItem = itemProposedChange.Item;

                        EnterpriseReference entRef = await m_engineeringServices.GetEnterpriseReference(engItem);

                        EnterpriseReferenceCreate newEntRef = new EnterpriseReferenceCreate(itemProposedChange.ProposedEIN);

                        if ((entRef == null) || (entRef.partNumber == null) || (entRef.partNumber.Equals(string.Empty)))
                        {
                            try
                            {
                                entRefUpdated = await m_engineeringServices.SetEnterpriseReference(engItem, newEntRef);
                            }

                            catch (SetEnterpriseReferenceException ex1)
                            {
                                try
                                {
                                    entRefUpdated = await m_engineeringServices.UpdateEnterpriseReference(engItem, newEntRef);
                                }
                                catch (UpdateEnterpriseReferenceException ex2)
                                {
                                    m_searchResultGridView.Rows[i].Cells[m_searchResultGridView.Rows[i].Cells.Count - 1].Style.BackColor = Color.Red;
                                    m_searchResultGridView.Rows[i].Cells[m_searchResultGridView.Rows[i].Cells.Count - 1].Style.ForeColor = Color.White;
                                    m_searchResultGridView.Rows[i].Cells[m_searchResultGridView.Rows[i].Cells.Count - 1].Value = ex2.Message;
                                }
                            }
                        }
                        else
                        {
                            if (!itemProposedChange.ProposedEIN.Equals(itemProposedChange.ExistingEIN))
                            {
                                try
                                {
                                    entRefUpdated = await m_engineeringServices.UpdateEnterpriseReference(engItem, newEntRef);
                                }
                                catch (UpdateEnterpriseReferenceException ex1)
                                {
                                    try
                                    {
                                        entRefUpdated = await m_engineeringServices.SetEnterpriseReference(engItem, newEntRef);
                                    }
                                    catch (SetEnterpriseReferenceException)
                                    {
                                        m_searchResultGridView.Rows[i].Cells[m_searchResultGridView.Rows[i].Cells.Count - 1].Style.BackColor = Color.Red;
                                        m_searchResultGridView.Rows[i].Cells[m_searchResultGridView.Rows[i].Cells.Count - 1].Style.ForeColor = Color.White;
                                        m_searchResultGridView.Rows[i].Cells[m_searchResultGridView.Rows[i].Cells.Count - 1].Value = ex1.Message;
                                    }
                                }
                            }
                        }
                    }

                    if (null != entRefUpdated)
                    {
                        stats_updated++;

                        itemProposedChange.ExistingEIN = entRefUpdated.partNumber;
                        itemProposedChange.LastUpdateStatus = "OK - part number updated";
                        m_searchResultGridView.Rows[i].Cells[m_searchResultGridView.Rows[i].Cells.Count - 1].Style.BackColor = Color.LightGreen;
                    }

                    m_bindingSource.ResetItem(i);

                    i++;
                }

                MessageBox.Show(string.Format("{0} part numbers updated from {1} records.", stats_updated, stats_total));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
