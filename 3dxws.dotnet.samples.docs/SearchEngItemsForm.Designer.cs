namespace ds.enovia.dseng.search.docs
{
    partial class SearchEngItemsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.m_loginButton = new System.Windows.Forms.Button();
            this.m_countLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.m_userLoginInfo = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.m_searchUIGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_elementTypeComboBox = new System.Windows.Forms.ComboBox();
            this.m_revisionSearchCriteriaTextBox = new System.Windows.Forms.TextBox();
            this.m_searchEBOMButton = new System.Windows.Forms.Button();
            this.m_titleSearchCriteriaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_searchResultGridView = new System.Windows.Forms.DataGridView();
            this.m_title = new System.Windows.Forms.Label();
            this.m_docsTabControl = new System.Windows.Forms.TabControl();
            this.m_specificationsTabPage = new System.Windows.Forms.TabPage();
            this.m_attachmentsTabPage = new System.Windows.Forms.TabPage();
            this.m_specificationsDataGridView = new System.Windows.Forms.DataGridView();
            this.m_documentsDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.m_searchUIGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_searchResultGridView)).BeginInit();
            this.m_docsTabControl.SuspendLayout();
            this.m_specificationsTabPage.SuspendLayout();
            this.m_attachmentsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_specificationsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_documentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // m_loginButton
            // 
            this.m_loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_loginButton.Location = new System.Drawing.Point(801, 10);
            this.m_loginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_loginButton.Name = "m_loginButton";
            this.m_loginButton.Size = new System.Drawing.Size(127, 36);
            this.m_loginButton.TabIndex = 2;
            this.m_loginButton.Text = "Log in";
            this.m_loginButton.UseVisualStyleBackColor = true;
            this.m_loginButton.Click += new System.EventHandler(this.m_loginButton_Click);
            // 
            // m_countLabel
            // 
            this.m_countLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_countLabel.AutoSize = true;
            this.m_countLabel.Location = new System.Drawing.Point(12, 586);
            this.m_countLabel.Name = "m_countLabel";
            this.m_countLabel.Size = new System.Drawing.Size(13, 17);
            this.m_countLabel.TabIndex = 3;
            this.m_countLabel.Text = "-";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.m_userLoginInfo);
            this.groupBox2.Controls.Add(this.m_loginButton);
            this.groupBox2.Location = new System.Drawing.Point(15, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(940, 50);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "3DX / User Info";
            // 
            // m_userLoginInfo
            // 
            this.m_userLoginInfo.AutoSize = true;
            this.m_userLoginInfo.Location = new System.Drawing.Point(19, 28);
            this.m_userLoginInfo.Name = "m_userLoginInfo";
            this.m_userLoginInfo.Size = new System.Drawing.Size(232, 17);
            this.m_userLoginInfo.TabIndex = 3;
            this.m_userLoginInfo.Text = "No user is logged in to any platform";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer3.Location = new System.Drawing.Point(12, 76);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.m_searchUIGroupBox);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.m_docsTabControl);
            this.splitContainer3.Size = new System.Drawing.Size(944, 506);
            this.splitContainer3.SplitterDistance = 166;
            this.splitContainer3.TabIndex = 12;
            // 
            // m_searchUIGroupBox
            // 
            this.m_searchUIGroupBox.Controls.Add(this.label2);
            this.m_searchUIGroupBox.Controls.Add(this.m_elementTypeComboBox);
            this.m_searchUIGroupBox.Controls.Add(this.m_revisionSearchCriteriaTextBox);
            this.m_searchUIGroupBox.Controls.Add(this.m_searchEBOMButton);
            this.m_searchUIGroupBox.Controls.Add(this.m_titleSearchCriteriaTextBox);
            this.m_searchUIGroupBox.Controls.Add(this.label1);
            this.m_searchUIGroupBox.Controls.Add(this.m_searchResultGridView);
            this.m_searchUIGroupBox.Controls.Add(this.m_title);
            this.m_searchUIGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_searchUIGroupBox.Location = new System.Drawing.Point(0, 0);
            this.m_searchUIGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_searchUIGroupBox.Name = "m_searchUIGroupBox";
            this.m_searchUIGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_searchUIGroupBox.Size = new System.Drawing.Size(944, 166);
            this.m_searchUIGroupBox.TabIndex = 1;
            this.m_searchUIGroupBox.TabStop = false;
            this.m_searchUIGroupBox.Text = "Search Criteria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type :";
            // 
            // m_elementTypeComboBox
            // 
            this.m_elementTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_elementTypeComboBox.FormattingEnabled = true;
            this.m_elementTypeComboBox.Location = new System.Drawing.Point(568, 26);
            this.m_elementTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_elementTypeComboBox.Name = "m_elementTypeComboBox";
            this.m_elementTypeComboBox.Size = new System.Drawing.Size(209, 24);
            this.m_elementTypeComboBox.TabIndex = 6;
            // 
            // m_revisionSearchCriteriaTextBox
            // 
            this.m_revisionSearchCriteriaTextBox.Location = new System.Drawing.Point(397, 27);
            this.m_revisionSearchCriteriaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_revisionSearchCriteriaTextBox.Name = "m_revisionSearchCriteriaTextBox";
            this.m_revisionSearchCriteriaTextBox.Size = new System.Drawing.Size(101, 22);
            this.m_revisionSearchCriteriaTextBox.TabIndex = 3;
            // 
            // m_searchEBOMButton
            // 
            this.m_searchEBOMButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_searchEBOMButton.Location = new System.Drawing.Point(804, 21);
            this.m_searchEBOMButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_searchEBOMButton.Name = "m_searchEBOMButton";
            this.m_searchEBOMButton.Size = new System.Drawing.Size(128, 33);
            this.m_searchEBOMButton.TabIndex = 3;
            this.m_searchEBOMButton.Text = "Search";
            this.m_searchEBOMButton.UseVisualStyleBackColor = true;
            this.m_searchEBOMButton.Click += new System.EventHandler(this.m_searchEBOMButton_Click);
            // 
            // m_titleSearchCriteriaTextBox
            // 
            this.m_titleSearchCriteriaTextBox.Location = new System.Drawing.Point(55, 30);
            this.m_titleSearchCriteriaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_titleSearchCriteriaTextBox.Name = "m_titleSearchCriteriaTextBox";
            this.m_titleSearchCriteriaTextBox.Size = new System.Drawing.Size(261, 22);
            this.m_titleSearchCriteriaTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Revision :";
            // 
            // m_searchResultGridView
            // 
            this.m_searchResultGridView.AllowUserToAddRows = false;
            this.m_searchResultGridView.AllowUserToDeleteRows = false;
            this.m_searchResultGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Azure;
            this.m_searchResultGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.m_searchResultGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.m_searchResultGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.m_searchResultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.m_searchResultGridView.DefaultCellStyle = dataGridViewCellStyle15;
            this.m_searchResultGridView.Location = new System.Drawing.Point(3, 70);
            this.m_searchResultGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_searchResultGridView.Name = "m_searchResultGridView";
            this.m_searchResultGridView.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.m_searchResultGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.m_searchResultGridView.RowTemplate.Height = 24;
            this.m_searchResultGridView.Size = new System.Drawing.Size(933, 86);
            this.m_searchResultGridView.TabIndex = 1;
            this.m_searchResultGridView.SelectionChanged += new System.EventHandler(this.m_searchResultGridView_SelectionChanged);
            // 
            // m_title
            // 
            this.m_title.AutoSize = true;
            this.m_title.Location = new System.Drawing.Point(5, 31);
            this.m_title.Name = "m_title";
            this.m_title.Size = new System.Drawing.Size(43, 17);
            this.m_title.TabIndex = 0;
            this.m_title.Text = "Title :";
            // 
            // m_docsTabControl
            // 
            this.m_docsTabControl.Controls.Add(this.m_specificationsTabPage);
            this.m_docsTabControl.Controls.Add(this.m_attachmentsTabPage);
            this.m_docsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_docsTabControl.Location = new System.Drawing.Point(0, 0);
            this.m_docsTabControl.Name = "m_docsTabControl";
            this.m_docsTabControl.SelectedIndex = 0;
            this.m_docsTabControl.Size = new System.Drawing.Size(944, 336);
            this.m_docsTabControl.TabIndex = 1;
            // 
            // m_specificationsTabPage
            // 
            this.m_specificationsTabPage.Controls.Add(this.m_specificationsDataGridView);
            this.m_specificationsTabPage.Location = new System.Drawing.Point(4, 25);
            this.m_specificationsTabPage.Name = "m_specificationsTabPage";
            this.m_specificationsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.m_specificationsTabPage.Size = new System.Drawing.Size(936, 307);
            this.m_specificationsTabPage.TabIndex = 0;
            this.m_specificationsTabPage.Text = "Specification Documents";
            this.m_specificationsTabPage.UseVisualStyleBackColor = true;
            // 
            // m_attachmentsTabPage
            // 
            this.m_attachmentsTabPage.Controls.Add(this.m_documentsDataGridView);
            this.m_attachmentsTabPage.Location = new System.Drawing.Point(4, 25);
            this.m_attachmentsTabPage.Name = "m_attachmentsTabPage";
            this.m_attachmentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.m_attachmentsTabPage.Size = new System.Drawing.Size(936, 307);
            this.m_attachmentsTabPage.TabIndex = 1;
            this.m_attachmentsTabPage.Text = "Attachment Documents";
            this.m_attachmentsTabPage.UseVisualStyleBackColor = true;
            // 
            // m_specificationsDataGridView
            // 
            this.m_specificationsDataGridView.AllowDrop = true;
            this.m_specificationsDataGridView.AllowUserToAddRows = false;
            this.m_specificationsDataGridView.AllowUserToDeleteRows = false;
            this.m_specificationsDataGridView.AllowUserToOrderColumns = true;
            this.m_specificationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_specificationsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_specificationsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.m_specificationsDataGridView.Name = "m_specificationsDataGridView";
            this.m_specificationsDataGridView.ReadOnly = true;
            this.m_specificationsDataGridView.RowTemplate.Height = 24;
            this.m_specificationsDataGridView.Size = new System.Drawing.Size(930, 301);
            this.m_specificationsDataGridView.TabIndex = 0;
            this.m_specificationsDataGridView.DragDrop += new System.Windows.Forms.DragEventHandler(this.m_specificationsDataGridView_DragDrop);
            this.m_specificationsDataGridView.DragEnter += new System.Windows.Forms.DragEventHandler(this.m_specificationsDataGridView_DragEnter);
            // 
            // m_documentsDataGridView
            // 
            this.m_documentsDataGridView.AllowDrop = true;
            this.m_documentsDataGridView.AllowUserToAddRows = false;
            this.m_documentsDataGridView.AllowUserToDeleteRows = false;
            this.m_documentsDataGridView.AllowUserToOrderColumns = true;
            this.m_documentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_documentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_documentsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.m_documentsDataGridView.Name = "m_documentsDataGridView";
            this.m_documentsDataGridView.ReadOnly = true;
            this.m_documentsDataGridView.RowTemplate.Height = 24;
            this.m_documentsDataGridView.Size = new System.Drawing.Size(930, 301);
            this.m_documentsDataGridView.TabIndex = 0;
            this.m_documentsDataGridView.DragDrop += new System.Windows.Forms.DragEventHandler(this.m_documentsDataGridView_DragDrop);
            this.m_documentsDataGridView.DragEnter += new System.Windows.Forms.DragEventHandler(this.m_documentsDataGridView_DragEnter);
            // 
            // SearchEngItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 628);
            this.Controls.Add(this.splitContainer3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.m_countLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(986, 665);
            this.Name = "SearchEngItemsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.m_searchUIGroupBox.ResumeLayout(false);
            this.m_searchUIGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_searchResultGridView)).EndInit();
            this.m_docsTabControl.ResumeLayout(false);
            this.m_specificationsTabPage.ResumeLayout(false);
            this.m_attachmentsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_specificationsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_documentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button m_loginButton;
        private System.Windows.Forms.Label m_countLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label m_userLoginInfo;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox m_searchUIGroupBox;
        private System.Windows.Forms.TextBox m_revisionSearchCriteriaTextBox;
        private System.Windows.Forms.Button m_searchEBOMButton;
        private System.Windows.Forms.TextBox m_titleSearchCriteriaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView m_searchResultGridView;
        private System.Windows.Forms.Label m_title;
        private System.Windows.Forms.ComboBox m_elementTypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl m_docsTabControl;
        private System.Windows.Forms.TabPage m_specificationsTabPage;
        private System.Windows.Forms.DataGridView m_specificationsDataGridView;
        private System.Windows.Forms.TabPage m_attachmentsTabPage;
        private System.Windows.Forms.DataGridView m_documentsDataGridView;
    }
}

