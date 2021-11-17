
namespace ds.emedcpe.samples.ein
{
    partial class AssignEINEngItemsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Assign EngItem EIN Form";

            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.m_loginButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.m_userLoginInfo = new System.Windows.Forms.Label();
            this.m_searchButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.m_searchResultGridView = new System.Windows.Forms.DataGridView();
            this.m_countLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_searchResultGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // m_loginButton
            // 
            this.m_loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_loginButton.Location = new System.Drawing.Point(627, 14);
            this.m_loginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_loginButton.Name = "m_loginButton";
            this.m_loginButton.Size = new System.Drawing.Size(160, 32);
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
            this.groupBox2.Location = new System.Drawing.Point(15, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(807, 50);
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
            // m_searchButton
            // 
            this.m_searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_searchButton.Location = new System.Drawing.Point(465, 480);
            this.m_searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_searchButton.Name = "m_searchButton";
            this.m_searchButton.Size = new System.Drawing.Size(161, 37);
            this.m_searchButton.TabIndex = 3;
            this.m_searchButton.Text = "Load EIN CSV";
            this.m_searchButton.UseVisualStyleBackColor = true;
            this.m_searchButton.Click += new System.EventHandler(this.m_searchButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(649, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Apply Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // m_searchResultGridView
            // 
            this.m_searchResultGridView.AllowUserToAddRows = false;
            this.m_searchResultGridView.AllowUserToDeleteRows = false;
            this.m_searchResultGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            this.m_searchResultGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.m_searchResultGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_searchResultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_searchResultGridView.Location = new System.Drawing.Point(12, 77);
            this.m_searchResultGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_searchResultGridView.MultiSelect = false;
            this.m_searchResultGridView.Name = "m_searchResultGridView";
            this.m_searchResultGridView.ReadOnly = true;
            this.m_searchResultGridView.RowTemplate.Height = 24;
            this.m_searchResultGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.m_searchResultGridView.Size = new System.Drawing.Size(791, 389);
            this.m_searchResultGridView.TabIndex = 1;
            // 
            // m_countLabel
            // 
            this.m_countLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_countLabel.AutoSize = true;
            this.m_countLabel.Location = new System.Drawing.Point(12, 468);
            this.m_countLabel.Name = "m_countLabel";
            this.m_countLabel.Size = new System.Drawing.Size(13, 17);
            this.m_countLabel.TabIndex = 3;
            this.m_countLabel.Text = "-";
            // 
            // AssignEINEngItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 533);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.m_searchButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.m_countLabel);
            this.Controls.Add(this.m_searchResultGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(850, 580);
            this.Name = "AssignEINEngItemsForm";
            this.Text = "Update Part Number";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_searchResultGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button m_loginButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label m_userLoginInfo;
        private System.Windows.Forms.Button m_searchButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView m_searchResultGridView;
        private System.Windows.Forms.Label m_countLabel;
    }
}

