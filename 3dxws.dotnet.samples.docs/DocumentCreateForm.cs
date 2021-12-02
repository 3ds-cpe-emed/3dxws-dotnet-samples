//------------------------------------------------------------------------------------------------------------------------------------
// Copyright 2021 Dassault Systèmes - CPE EMED
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

using ds.enovia.document.model;
using System;

using System.Windows.Forms;

namespace ds.emedcpe.samples.docs
{
    public enum DocumentRelationType
    {
        Specification,
        Attachment
    }
    public partial class DocumentCreateForm : Form
    {
        string m_fileToUpload = string.Empty;
        string m_ownerPhysicalId = string.Empty;
        DocumentRelationType m_documentRelationType = DocumentRelationType.Attachment;

        public DocumentCreateForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        internal void Init(DocumentRelationType _docRelationType, string _physicalId, string _fileToUpload)
        {
            m_ownerPhysicalId = _physicalId;
            m_fileToUpload = _fileToUpload;

            m_documentRelationType = _docRelationType;

            if (m_documentRelationType == DocumentRelationType.Attachment)
            {
                this.Text = "New Document Attachment";
                m_fileGroupBox.Text = "File Attachment";
            }
            else
            {
                this.Text = "New Document Specification";
                m_fileGroupBox.Text = "File Specification";
            }

            this.m_titleTextBox.Text = System.IO.Path.GetFileNameWithoutExtension(m_fileToUpload);

            System.IO.FileInfo fileInfo = new System.IO.FileInfo(m_fileToUpload);

            this.m_folderNameLabel.Text = fileInfo.DirectoryName;

            long fileSize = fileInfo.Length;

            string uom = "bytes";

            if (fileSize  >= 1024)
            {
                uom = "Kb";

                fileSize = fileSize / 1024;

                if (fileSize >= 1024)
                {
                    uom = "Mb";

                    fileSize = fileSize / 1024;
                }
            }

            this.m_fileSizeLabel.Text = string.Format("{0} {1}", fileSize, uom);
            this.m_filenameLabel.Text = fileInfo.Name;

        }

        private async void m_uploadButton_Click(object sender, EventArgs e)
        {
            //TODO: Validate Title is not null and that the file exists and you have read access

            string title = this.m_titleTextBox.Text;
            string description = this.m_descriptionTextBox.Text;

           
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DateTime startTime = DateTime.Now;
                DocumentResponse<DocumentCreated> documentCreated = null;
                switch (m_documentRelationType)
                {
                    case DocumentRelationType.Attachment:

                        documentCreated = await ServiceConnections.Documents.CreateDocumentAsAttachment(title, description, m_ownerPhysicalId, m_fileToUpload);
                        break;

                    case DocumentRelationType.Specification:
                        documentCreated = await ServiceConnections.Documents.CreateDocumentAsSpecification(title, description, m_ownerPhysicalId, m_fileToUpload);
                        break;
                }
                
                DateTime endTime = DateTime.Now;
                TimeSpan elapsedTime = endTime - startTime;

                this.Cursor = Cursors.Default;

                MessageBox.Show(string.Format("Successfully attached new document in {0:0.0} secs", elapsedTime.TotalSeconds), "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.Cancel;

                this.Cursor = Cursors.Default;
                MessageBox.Show(ex.ToString());
            }



            this.Cursor = Cursors.Default;


            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
