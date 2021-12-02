namespace ds.emedcpe.samples.docs
{
    partial class DocumentCreateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.m_titleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_fileGroupBox = new System.Windows.Forms.GroupBox();
            this.m_filenameLabel = new System.Windows.Forms.Label();
            this.m_folderNameLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.m_fileSizeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_descriptionTextBox = new System.Windows.Forms.TextBox();
            this.m_uploadButton = new System.Windows.Forms.Button();
            this.m_cancelButton = new System.Windows.Forms.Button();
            this.m_fileGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title :";
            // 
            // m_titleTextBox
            // 
            this.m_titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_titleTextBox.Location = new System.Drawing.Point(125, 30);
            this.m_titleTextBox.Name = "m_titleTextBox";
            this.m_titleTextBox.Size = new System.Drawing.Size(340, 22);
            this.m_titleTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filename :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Size :";
            // 
            // m_fileGroupBox
            // 
            this.m_fileGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_fileGroupBox.Controls.Add(this.m_filenameLabel);
            this.m_fileGroupBox.Controls.Add(this.m_folderNameLabel);
            this.m_fileGroupBox.Controls.Add(this.label5);
            this.m_fileGroupBox.Controls.Add(this.m_fileSizeLabel);
            this.m_fileGroupBox.Controls.Add(this.label3);
            this.m_fileGroupBox.Controls.Add(this.label2);
            this.m_fileGroupBox.Location = new System.Drawing.Point(12, 129);
            this.m_fileGroupBox.Name = "m_fileGroupBox";
            this.m_fileGroupBox.Size = new System.Drawing.Size(453, 133);
            this.m_fileGroupBox.TabIndex = 5;
            this.m_fileGroupBox.TabStop = false;
            this.m_fileGroupBox.Text = "File Attachment";
            this.m_fileGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // m_filenameLabel
            // 
            this.m_filenameLabel.AutoSize = true;
            this.m_filenameLabel.Location = new System.Drawing.Point(110, 31);
            this.m_filenameLabel.Name = "m_filenameLabel";
            this.m_filenameLabel.Size = new System.Drawing.Size(13, 17);
            this.m_filenameLabel.TabIndex = 8;
            this.m_filenameLabel.Text = "-";
            // 
            // m_folderNameLabel
            // 
            this.m_folderNameLabel.AutoSize = true;
            this.m_folderNameLabel.Location = new System.Drawing.Point(110, 95);
            this.m_folderNameLabel.Name = "m_folderNameLabel";
            this.m_folderNameLabel.Size = new System.Drawing.Size(13, 17);
            this.m_folderNameLabel.TabIndex = 7;
            this.m_folderNameLabel.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Folder :";
            // 
            // m_fileSizeLabel
            // 
            this.m_fileSizeLabel.AutoSize = true;
            this.m_fileSizeLabel.Location = new System.Drawing.Point(110, 62);
            this.m_fileSizeLabel.Name = "m_fileSizeLabel";
            this.m_fileSizeLabel.Size = new System.Drawing.Size(13, 17);
            this.m_fileSizeLabel.TabIndex = 5;
            this.m_fileSizeLabel.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description :";
            // 
            // m_descriptionTextBox
            // 
            this.m_descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_descriptionTextBox.Location = new System.Drawing.Point(125, 75);
            this.m_descriptionTextBox.Multiline = true;
            this.m_descriptionTextBox.Name = "m_descriptionTextBox";
            this.m_descriptionTextBox.Size = new System.Drawing.Size(340, 41);
            this.m_descriptionTextBox.TabIndex = 7;
            // 
            // m_uploadButton
            // 
            this.m_uploadButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.m_uploadButton.Location = new System.Drawing.Point(129, 276);
            this.m_uploadButton.Name = "m_uploadButton";
            this.m_uploadButton.Size = new System.Drawing.Size(114, 33);
            this.m_uploadButton.TabIndex = 8;
            this.m_uploadButton.Text = "Upload";
            this.m_uploadButton.UseVisualStyleBackColor = true;
            this.m_uploadButton.Click += new System.EventHandler(this.m_uploadButton_Click);
            // 
            // m_cancelButton
            // 
            this.m_cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.m_cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_cancelButton.Location = new System.Drawing.Point(278, 276);
            this.m_cancelButton.Name = "m_cancelButton";
            this.m_cancelButton.Size = new System.Drawing.Size(114, 33);
            this.m_cancelButton.TabIndex = 9;
            this.m_cancelButton.Text = "Cancel";
            this.m_cancelButton.UseVisualStyleBackColor = true;
            // 
            // DocumentCreateForm
            // 
            this.AcceptButton = this.m_uploadButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.m_cancelButton;
            this.ClientSize = new System.Drawing.Size(494, 321);
            this.Controls.Add(this.m_cancelButton);
            this.Controls.Add(this.m_uploadButton);
            this.Controls.Add(this.m_descriptionTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_fileGroupBox);
            this.Controls.Add(this.m_titleTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(512, 368);
            this.Name = "DocumentCreateForm";
            this.Text = "New Document Attachment";
            this.m_fileGroupBox.ResumeLayout(false);
            this.m_fileGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_titleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox m_fileGroupBox;
        private System.Windows.Forms.Label m_filenameLabel;
        private System.Windows.Forms.Label m_folderNameLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label m_fileSizeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_descriptionTextBox;
        private System.Windows.Forms.Button m_uploadButton;
        private System.Windows.Forms.Button m_cancelButton;
    }
}