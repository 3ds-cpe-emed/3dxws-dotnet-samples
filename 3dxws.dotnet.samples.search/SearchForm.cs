//------------------------------------------------------------------------------------------------------------------------------------
// Copyright 2020 Dassault Systèmes - CPE EMED
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
using ds.delmia.dsmfg.model;
using ds.delmia.dsmfg.service;
using ds.enovia.common.collection;
using ds.enovia.common.model;
using ds.enovia.common.search;
using ds.enovia.dseng.model;
using ds.enovia.dseng.search;
using ds.enovia.dseng.service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ds.emedcpe.samples.searchuql
{
    public partial class SearchForm : Form
    {
        private EngineeringServices m_engineeringServices = null;
        private ManufacturingItemService m_manufacturingServices = null;

        private BindingSource m_bindingSource = new BindingSource();

        List<Tuple<string, string>> m_columnPropName = new List<Tuple<string, string>>();

        public SearchForm()
        {
            InitializeComponent();
        }
        private void SearchForm_Load(object sender, EventArgs e)
        {
            m_searchResultGridView.AutoGenerateColumns = false;
            m_searchResultGridView.DataSource = m_bindingSource;

            InitializeColumnAndPropertyNames(ref m_columnPropName);

            m_bindingSource.AllowNew = false;
            InitializeGridColumns(m_searchResultGridView, m_columnPropName);

            m_dateAttributeComboBox.DisplayMember = "Description";

            m_dateAttributeComboBox.Items.Add(new SearchByCreatedDateUI());
            m_dateAttributeComboBox.Items.Add(new SearchByModifiedDateUI());

            m_dateAttributeComboBox.SelectedIndex = 0;

            m_typeComboBox.DisplayMember = "Description";
            m_typeComboBox.Items.Add(new EngineeringItemUI());
            m_typeComboBox.Items.Add(new ManufacturingItemUI());

            m_typeComboBox.SelectedIndex = 0;

            UpdateUI();
        }

        private void InitializeColumnAndPropertyNames(ref List<Tuple<string, string>> _columnPropName)
        {
            _columnPropName.Add(new Tuple<string, string>("id", "Physical Id"));
            _columnPropName.Add(new Tuple<string, string>("name", "Name"));
            _columnPropName.Add(new Tuple<string, string>("title", "Title"));
            _columnPropName.Add(new Tuple<string, string>("revision", "Revision"));
            _columnPropName.Add(new Tuple<string, string>("collabspace", "Collab.Space"));
            _columnPropName.Add(new Tuple<string, string>("owner", "Owner"));
            _columnPropName.Add(new Tuple<string, string>("state", "State"));
            _columnPropName.Add(new Tuple<string, string>("created", "Created"));
            _columnPropName.Add(new Tuple<string, string>("modified", "Modified"));
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

                    m_manufacturingServices = new ManufacturingItemService(enoviaURL, Passport);
                    m_manufacturingServices.SecurityContext = securityContext;
                    m_manufacturingServices.Tenant = authInfo.Tenant;

                }
            }

            UpdateUI();

        }

        private void UpdateUI()
        {
            if ((Passport != null) && Passport.IsValid())
                m_searchUIGroupBox.Enabled = true;
            else
                m_searchUIGroupBox.Enabled = false;
        }

        private async void m_searchButton_Click(object sender, EventArgs e)
        {
            if (m_engineeringServices == null) return;
            if (Passport == null) return;
            if (!Passport.IsValid()) { return; }

            this.Cursor = Cursors.WaitCursor;

            try
            {
                m_bindingSource.Clear();

                DateTime selectedDate = m_dateTimePicker.Value;
                DateTime selectedDateUTC = selectedDate.ToUniversalTime();

                object selectedItem = m_dateAttributeComboBox.SelectedItem;

                SearchByDate searchQuery = null;

                if (selectedItem is SearchByCreatedDateUI)
                {
                    searchQuery = new SearchByCreatedDate(selectedDateUTC);
                }
                else
                {
                    if (selectedItem is SearchByModifiedDateUI)
                    {
                        searchQuery = new SearchByModifiedDate(selectedDateUTC);
                    }
                }

                if (this.m_stateReleasedCheckBox.Checked)
                {
                    // [ds6w:status]:(VPLM_SMB_Definition.IN_WORK)
                    // [ds6w:status]:(VPLM_SMB_Definition.RELEASED)
                    searchQuery.AddCriteria("[ds6w:status]:(VPLM_SMB_Definition.RELEASED)");
                }

                List<string> contentStructureOptionsSelected = new List<string>();

                if (m_structureRootCheckBox.Checked) contentStructureOptionsSelected.Add("[ds6w:contentStructure]:\"Root\"");
                if (m_structureLeafCheckBox.Checked) contentStructureOptionsSelected.Add("[ds6w:contentStructure]:\"Leaf\"");
                if (m_structureIntermediateCheckBox.Checked) contentStructureOptionsSelected.Add("[ds6w:contentStructure]:\"Intermediate\"");
                if (m_structureStandaloneCheckBox.Checked) contentStructureOptionsSelected.Add("[ds6w:contentStructure]:\"Standalone\"");

                if (contentStructureOptionsSelected.Count > 0)
                {
                    string contentStructureCriteria = null;
                    
                    contentStructureCriteria = contentStructureOptionsSelected[0];

                    for (int i = 1; i < contentStructureOptionsSelected.Count; i++)
                    {
                        contentStructureCriteria += $" OR {contentStructureOptionsSelected[i]}"; 
                    }
                    
                    if (contentStructureOptionsSelected.Count > 1)
                    {
                        contentStructureCriteria = $"({contentStructureCriteria})";
                    }
                    
                   searchQuery.AddCriteria(contentStructureCriteria);
                }

                object selectedType = m_typeComboBox.SelectedItem;

                m_searchStrValue.Text = searchQuery.GetSearchString();

                long count = 0;
                if (selectedType is EngineeringItemUI)
                {
                    List<NlsLabeledItemSet<EngineeringItem>> pages = await m_engineeringServices.SearchAll(searchQuery);
                    foreach (NlsLabeledItemSet<EngineeringItem> page in pages)
                    {
                        if (page.totalItems > 0)
                        {
                            foreach (Item item in page.member)
                            {
                                m_bindingSource.Add(item);
                            }

                            count += page.totalItems;
                        }
                    }
                }
                else
                {
                    if (selectedType is ManufacturingItemUI)
                    {
                        List<NlsLabeledItemSet<ManufacturingItem>> pages = await m_manufacturingServices.SearchAll(searchQuery);
                        foreach (NlsLabeledItemSet<ManufacturingItem> page in pages)
                        {
                            if (page.totalItems > 0)
                            {
                                foreach (Item item in page.member)
                                {
                                    m_bindingSource.Add(item);
                                }

                                count += page.totalItems;
                            }
                        }
                    }
                }                
                m_countLabel.Text = count.ToString();

            }
            catch (Exception _ex)
            {
                MessageBox.Show(_ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

      
    }
}
