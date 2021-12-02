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
using ds.emedcpe.samples;
using ds.enovia.common.collection;
using ds.enovia.common.search;
using ds.enovia.common.model;
using ds.enovia.dseng.model;
using ds.delmia.dsmfg.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ds.enovia.document.model;
using ds.emedcpe.samples.docs.model;
using ds.emedcpe.samples.docs;
using System.Threading.Tasks;
using ds.authentication.ui.win;

namespace ds.enovia.dseng.search.docs
{
    public partial class SearchEngItemsForm : Form
    {
        private BindingSource m_bindingSource = new BindingSource();
        private BindingSource m_documentsBindingSoure = new BindingSource();
        private BindingSource m_specificationsBindingSoure = new BindingSource();


        List<Tuple<string, string>> m_columnPropName = new List<Tuple<string, string>>();

       
        public SearchEngItemsForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Search Grid Initialization
            m_searchResultGridView.AutoGenerateColumns = false;
            m_searchResultGridView.DataSource = m_bindingSource;

            InitializeSearchGridColumnAndPropertyNames(ref m_columnPropName);

            m_bindingSource.AllowNew = false;
            InitializeGridColumns(m_searchResultGridView, m_columnPropName);
            #endregion

            UpdateUI();

            m_revisionSearchCriteriaTextBox.Text = "A.1";

            m_elementTypeComboBox.DataSource = ElementTypeEnumGlobals.GetAllDistinctValues();

            #region Documents Grid
            m_documentsDataGridView.AutoGenerateColumns = false;
            m_documentsDataGridView.DataSource = m_documentsBindingSoure;

            InitializeGridColumns(m_documentsDataGridView, InitializeDocumentsGridColumnAndPropertyNames());

            #endregion

            #region Specifications Grid
            m_specificationsDataGridView.AutoGenerateColumns = false;
            m_specificationsDataGridView.DataSource = m_specificationsBindingSoure;

            InitializeGridColumns(m_specificationsDataGridView, InitializeDocumentsGridColumnAndPropertyNames());

            #endregion

        }

        private void InitializeSearchGridColumnAndPropertyNames(ref List<Tuple<string, string>> _columnPropName)
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

        List<Tuple<string, string>> InitializeDocumentsGridColumnAndPropertyNames()
        {
            List<Tuple<string, string>> __columnPropNames = new List<Tuple<string, string>>();
            __columnPropNames.Add(new Tuple<string, string>("Title", "title"));
            __columnPropNames.Add(new Tuple<string, string>("Description", "description"));
            __columnPropNames.Add(new Tuple<string, string>("Modified", "modified"));
            __columnPropNames.Add(new Tuple<string, string>("Created", "created"));
            return __columnPropNames;
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
                    string enoviaURL       = authInfo.EnoviaURL;

                    m_userLoginInfo.Text   = authInfo.LoginMessage;

                    ServiceConnections.InitializeServices(enoviaURL, Passport, securityContext, authInfo.Tenant);
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

        private async void m_searchResultGridView_SelectionChanged(object sender, EventArgs e)
        {
            m_documentsBindingSoure.Clear();

            switch (m_searchResultGridView.SelectedRows.Count)
            {
                case 1:
                    Item item = (Item)m_searchResultGridView.SelectedRows[0].DataBoundItem;
                    await UpdateAttachmentDocumentsGrid(item);
                    await UpdateSpecificationsDocumentsGrid(item);
                    break;
                default:
                    break;
            }
        }

        private async Task UpdateAttachmentDocumentsGrid(Item _item)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                m_documentsBindingSoure.Clear();

                DocumentResponse<Document> itemDocs = await ServiceConnections.Documents.GetAttachedDocuments(_item.id);

                if (itemDocs.success)
                {
                    m_attachmentsTabPage.Text = string.Format("Attachment Documents ({0})", itemDocs.data.Count);

                    foreach (Document doc in itemDocs.data)
                    {
                        m_documentsBindingSoure.Add(new DocumentRow(doc));
                    }
                }
                else
                {
                    m_attachmentsTabPage.Text = "Attachment Documents (-)";

                }
            }
            catch (Exception _ex)
            {
                m_attachmentsTabPage.Text = "Attachment Documents (-)";

                this.Cursor = Cursors.Default;

                MessageBox.Show(this, _ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }   
        }

        private async Task UpdateSpecificationsDocumentsGrid(Item _item)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                m_specificationsBindingSoure.Clear();

                DocumentResponse<Document> itemDocs = await ServiceConnections.Documents.GetSpecificationDocuments(_item.id);

                if (itemDocs.success)
                {
                    m_specificationsTabPage.Text = string.Format("Specifications Documents ({0})", itemDocs.data.Count);

                    foreach (Document doc in itemDocs.data)
                    {
                        m_specificationsBindingSoure.Add(new DocumentRow(doc));
                    }
                }
                else
                {
                    m_specificationsTabPage.Text = "Specifications Documents (-)";
                }
                
            }
            catch (Exception _ex)
            {
                m_specificationsTabPage.Text = "Specifications Documents (-)";

                this.Cursor = Cursors.Default;

                MessageBox.Show(this, _ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private async void m_searchEBOMButton_Click(object sender, EventArgs e)
        {
            if (Passport == null) return;
            if (!Passport.IsValid()) { return; }

            if ((ServiceConnections.Engineering == null) || (ServiceConnections.ManufacturingItem == null)) return;

            this.Cursor = Cursors.WaitCursor;

            try
            {
                ElementTypeEnum selectedElementType = ElementTypeEnumGlobals.GetSelected(m_elementTypeComboBox);

                m_bindingSource.Clear();

                string titleSearchCriteria = m_titleSearchCriteriaTextBox.Text;
                string revisionSearchCriteria = m_revisionSearchCriteriaTextBox.Text;

                SearchByTitleRevision searchQuery = new SearchByTitleRevision(titleSearchCriteria, revisionSearchCriteria);

                long count = 0;
                switch (selectedElementType)
                {
                    case ElementTypeEnum.EngineeringItem:

                        List<NlsLabeledItemSet<EngineeringItem>> pages = await ServiceConnections.Engineering.SearchAll(searchQuery);

                        foreach (NlsLabeledItemSet<EngineeringItem> page in pages)
                        {
                            foreach (EngineeringItem item in page.member)
                            {
                                m_bindingSource.Add(item);
                                count++;
                            }
                        }

                        break;

                    case ElementTypeEnum.ManufacturingItem:

                        List<NlsLabeledItemSet<ManufacturingItem>> mfgPages = await ServiceConnections.ManufacturingItem.SearchAll(searchQuery);

                        foreach (NlsLabeledItemSet<ManufacturingItem> page in mfgPages)
                        {
                            foreach (ManufacturingItem item in page.member)
                            {
                                m_bindingSource.Add(item);
                                count++;
                            }
                        }

                        break;
                    default:
                        break;
                }

                m_countLabel.Text = count.ToString();

            }
            catch (Exception _ex)
            {
                MessageBox.Show(_ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void m_documentsDataGridView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // modify the drag drop effects to Move
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                // no need for any drag drop effect
                e.Effect = DragDropEffects.None;
            }
        }

        private async void m_documentsDataGridView_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Fetch the file(s) names with full path here to be processed
                string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop);

                // Your desired code goes here to process the file(s) being dropped
                if (fileList.Length != 1)
                {
                    MessageBox.Show(this, "Can only attach one file at a time!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string fileToUpload = fileList[0];
                Item item = (Item)m_searchResultGridView.SelectedRows[0].DataBoundItem;

                DocumentCreateForm docCreateForm = new DocumentCreateForm();
                docCreateForm.Init(DocumentRelationType.Attachment , item.id, fileToUpload);
                if (DialogResult.OK == docCreateForm.ShowDialog())
                {
                   await UpdateAttachmentDocumentsGrid(item);
                }
            }
        }

        private void m_specificationsDataGridView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // modify the drag drop effects to Move
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                // no need for any drag drop effect
                e.Effect = DragDropEffects.None;
            }
        }

        private async void m_specificationsDataGridView_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Fetch the file(s) names with full path here to be processed
                string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop);

                // Your desired code goes here to process the file(s) being dropped
                if (fileList.Length != 1)
                {
                    MessageBox.Show(this, "Can only add one file at a time!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string fileToUpload = fileList[0];
                Item item = (Item)m_searchResultGridView.SelectedRows[0].DataBoundItem;

                DocumentCreateForm docCreateForm = new DocumentCreateForm();
                docCreateForm.Init(DocumentRelationType.Specification, item.id, fileToUpload);
                if (DialogResult.OK == docCreateForm.ShowDialog())
                {
                    await UpdateSpecificationsDocumentsGrid(item);
                }
            }
        }
    }
}
