
namespace ds.emedcpe.samples.searchuql
{
    partial class SearchForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.m_userLoginInfo = new System.Windows.Forms.Label();
            this.m_loginButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.m_searchUIGroupBox = new System.Windows.Forms.GroupBox();
            this.m_structureRootCheckBox = new System.Windows.Forms.CheckBox();
            this.m_structureLeafCheckBox = new System.Windows.Forms.CheckBox();
            this.m_structureStandaloneCheckBox = new System.Windows.Forms.CheckBox();
            this.m_structureIntermediateCheckBox = new System.Windows.Forms.CheckBox();
            this.m_typeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.m_dateAttributeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_searchResultGridView = new System.Windows.Forms.DataGridView();
            this.m_searchButton = new System.Windows.Forms.Button();
            this.m_countLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_searchStrValue = new System.Windows.Forms.Label();
            this.m_stateReleasedCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.m_searchUIGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_searchResultGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // m_userLoginInfo
            // 
            this.m_userLoginInfo.AutoSize = true;
            this.m_userLoginInfo.Location = new System.Drawing.Point(14, 23);
            this.m_userLoginInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_userLoginInfo.Name = "m_userLoginInfo";
            this.m_userLoginInfo.Size = new System.Drawing.Size(172, 13);
            this.m_userLoginInfo.TabIndex = 3;
            this.m_userLoginInfo.Text = "No user is logged in to any platform";
            // 
            // m_loginButton
            // 
            this.m_loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_loginButton.Location = new System.Drawing.Point(622, 12);
            this.m_loginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_loginButton.Name = "m_loginButton";
            this.m_loginButton.Size = new System.Drawing.Size(121, 29);
            this.m_loginButton.TabIndex = 2;
            this.m_loginButton.Text = "Log in";
            this.m_loginButton.UseVisualStyleBackColor = true;
            this.m_loginButton.Click += new System.EventHandler(this.m_loginButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.m_userLoginInfo);
            this.groupBox2.Controls.Add(this.m_loginButton);
            this.groupBox2.Location = new System.Drawing.Point(1, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(757, 49);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "3DX / User Info";
            // 
            // m_searchUIGroupBox
            // 
            this.m_searchUIGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_searchUIGroupBox.Controls.Add(this.m_stateReleasedCheckBox);
            this.m_searchUIGroupBox.Controls.Add(this.m_structureRootCheckBox);
            this.m_searchUIGroupBox.Controls.Add(this.m_structureLeafCheckBox);
            this.m_searchUIGroupBox.Controls.Add(this.m_structureStandaloneCheckBox);
            this.m_searchUIGroupBox.Controls.Add(this.m_structureIntermediateCheckBox);
            this.m_searchUIGroupBox.Controls.Add(this.m_typeComboBox);
            this.m_searchUIGroupBox.Controls.Add(this.label2);
            this.m_searchUIGroupBox.Controls.Add(this.m_dateTimePicker);
            this.m_searchUIGroupBox.Controls.Add(this.m_dateAttributeComboBox);
            this.m_searchUIGroupBox.Controls.Add(this.label1);
            this.m_searchUIGroupBox.Controls.Add(this.m_searchResultGridView);
            this.m_searchUIGroupBox.Controls.Add(this.m_searchButton);
            this.m_searchUIGroupBox.Location = new System.Drawing.Point(1, 61);
            this.m_searchUIGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_searchUIGroupBox.Name = "m_searchUIGroupBox";
            this.m_searchUIGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_searchUIGroupBox.Size = new System.Drawing.Size(757, 421);
            this.m_searchUIGroupBox.TabIndex = 6;
            this.m_searchUIGroupBox.TabStop = false;
            this.m_searchUIGroupBox.Text = "Search Criteria";
            // 
            // m_structureRootCheckBox
            // 
            this.m_structureRootCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_structureRootCheckBox.AutoSize = true;
            this.m_structureRootCheckBox.Location = new System.Drawing.Point(647, 88);
            this.m_structureRootCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_structureRootCheckBox.Name = "m_structureRootCheckBox";
            this.m_structureRootCheckBox.Size = new System.Drawing.Size(49, 17);
            this.m_structureRootCheckBox.TabIndex = 22;
            this.m_structureRootCheckBox.Text = "Root";
            this.toolTip1.SetToolTip(this.m_structureRootCheckBox, "The product that does not have any parent product but has children products.");
            this.m_structureRootCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_structureLeafCheckBox
            // 
            this.m_structureLeafCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_structureLeafCheckBox.AutoSize = true;
            this.m_structureLeafCheckBox.Location = new System.Drawing.Point(646, 160);
            this.m_structureLeafCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_structureLeafCheckBox.Name = "m_structureLeafCheckBox";
            this.m_structureLeafCheckBox.Size = new System.Drawing.Size(47, 17);
            this.m_structureLeafCheckBox.TabIndex = 21;
            this.m_structureLeafCheckBox.Text = "Leaf";
            this.toolTip1.SetToolTip(this.m_structureLeafCheckBox, "The product that at least one parent product but does not have any child product." +
        "");
            this.m_structureLeafCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_structureStandaloneCheckBox
            // 
            this.m_structureStandaloneCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_structureStandaloneCheckBox.AutoSize = true;
            this.m_structureStandaloneCheckBox.Location = new System.Drawing.Point(647, 136);
            this.m_structureStandaloneCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_structureStandaloneCheckBox.Name = "m_structureStandaloneCheckBox";
            this.m_structureStandaloneCheckBox.Size = new System.Drawing.Size(80, 17);
            this.m_structureStandaloneCheckBox.TabIndex = 20;
            this.m_structureStandaloneCheckBox.Text = "Standalone";
            this.toolTip1.SetToolTip(this.m_structureStandaloneCheckBox, "The product that has neither parent nor child product.");
            this.m_structureStandaloneCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_structureIntermediateCheckBox
            // 
            this.m_structureIntermediateCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_structureIntermediateCheckBox.AutoSize = true;
            this.m_structureIntermediateCheckBox.Location = new System.Drawing.Point(647, 112);
            this.m_structureIntermediateCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_structureIntermediateCheckBox.Name = "m_structureIntermediateCheckBox";
            this.m_structureIntermediateCheckBox.Size = new System.Drawing.Size(84, 17);
            this.m_structureIntermediateCheckBox.TabIndex = 19;
            this.m_structureIntermediateCheckBox.Text = "Intermediate";
            this.toolTip1.SetToolTip(this.m_structureIntermediateCheckBox, "The product that has parent product(s) as well as child product(s).");
            this.m_structureIntermediateCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_typeComboBox
            // 
            this.m_typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_typeComboBox.FormattingEnabled = true;
            this.m_typeComboBox.Location = new System.Drawing.Point(9, 48);
            this.m_typeComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_typeComboBox.Name = "m_typeComboBox";
            this.m_typeComboBox.Size = new System.Drawing.Size(115, 21);
            this.m_typeComboBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Type :";
            // 
            // m_dateTimePicker
            // 
            this.m_dateTimePicker.Location = new System.Drawing.Point(239, 51);
            this.m_dateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_dateTimePicker.Name = "m_dateTimePicker";
            this.m_dateTimePicker.Size = new System.Drawing.Size(206, 20);
            this.m_dateTimePicker.TabIndex = 10;
            // 
            // m_dateAttributeComboBox
            // 
            this.m_dateAttributeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_dateAttributeComboBox.FormattingEnabled = true;
            this.m_dateAttributeComboBox.Location = new System.Drawing.Point(136, 49);
            this.m_dateAttributeComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_dateAttributeComboBox.Name = "m_dateAttributeComboBox";
            this.m_dateAttributeComboBox.Size = new System.Drawing.Size(99, 21);
            this.m_dateAttributeComboBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Attribute :";
            // 
            // m_searchResultGridView
            // 
            this.m_searchResultGridView.AllowUserToAddRows = false;
            this.m_searchResultGridView.AllowUserToDeleteRows = false;
            this.m_searchResultGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            this.m_searchResultGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.m_searchResultGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_searchResultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_searchResultGridView.Location = new System.Drawing.Point(8, 88);
            this.m_searchResultGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_searchResultGridView.MultiSelect = false;
            this.m_searchResultGridView.Name = "m_searchResultGridView";
            this.m_searchResultGridView.ReadOnly = true;
            this.m_searchResultGridView.RowHeadersWidth = 51;
            this.m_searchResultGridView.RowTemplate.Height = 24;
            this.m_searchResultGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_searchResultGridView.Size = new System.Drawing.Size(624, 329);
            this.m_searchResultGridView.TabIndex = 7;
            // 
            // m_searchButton
            // 
            this.m_searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_searchButton.Location = new System.Drawing.Point(622, 23);
            this.m_searchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_searchButton.Name = "m_searchButton";
            this.m_searchButton.Size = new System.Drawing.Size(121, 27);
            this.m_searchButton.TabIndex = 3;
            this.m_searchButton.Text = "Search";
            this.m_searchButton.UseVisualStyleBackColor = true;
            this.m_searchButton.Click += new System.EventHandler(this.m_searchButton_Click);
            // 
            // m_countLabel
            // 
            this.m_countLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_countLabel.AutoSize = true;
            this.m_countLabel.Location = new System.Drawing.Point(47, 489);
            this.m_countLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_countLabel.Name = "m_countLabel";
            this.m_countLabel.Size = new System.Drawing.Size(10, 13);
            this.m_countLabel.TabIndex = 7;
            this.m_countLabel.Text = "-";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 489);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 489);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "$searchStr :";
            // 
            // m_searchStrValue
            // 
            this.m_searchStrValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_searchStrValue.AutoSize = true;
            this.m_searchStrValue.Location = new System.Drawing.Point(145, 489);
            this.m_searchStrValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_searchStrValue.Name = "m_searchStrValue";
            this.m_searchStrValue.Size = new System.Drawing.Size(10, 13);
            this.m_searchStrValue.TabIndex = 10;
            this.m_searchStrValue.Text = "-";
            // 
            // m_stateReleasedCheckBox
            // 
            this.m_stateReleasedCheckBox.AutoSize = true;
            this.m_stateReleasedCheckBox.Location = new System.Drawing.Point(449, 54);
            this.m_stateReleasedCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.m_stateReleasedCheckBox.Name = "m_stateReleasedCheckBox";
            this.m_stateReleasedCheckBox.Size = new System.Drawing.Size(71, 17);
            this.m_stateReleasedCheckBox.TabIndex = 24;
            this.m_stateReleasedCheckBox.Text = "Released";
            this.toolTip1.SetToolTip(this.m_stateReleasedCheckBox, "Maturity State Released");
            this.m_stateReleasedCheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 511);
            this.Controls.Add(this.m_searchStrValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_countLabel);
            this.Controls.Add(this.m_searchUIGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SearchForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.m_searchUIGroupBox.ResumeLayout(false);
            this.m_searchUIGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_searchResultGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_userLoginInfo;
        private System.Windows.Forms.Button m_loginButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox m_searchUIGroupBox;
        private System.Windows.Forms.Button m_searchButton;
        private System.Windows.Forms.DataGridView m_searchResultGridView;
        private System.Windows.Forms.Label m_countLabel;
        private System.Windows.Forms.DateTimePicker m_dateTimePicker;
        private System.Windows.Forms.ComboBox m_dateAttributeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox m_typeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox m_structureRootCheckBox;
        private System.Windows.Forms.CheckBox m_structureLeafCheckBox;
        private System.Windows.Forms.CheckBox m_structureStandaloneCheckBox;
        private System.Windows.Forms.CheckBox m_structureIntermediateCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label m_searchStrValue;
        private System.Windows.Forms.CheckBox m_stateReleasedCheckBox;
    }
}

