﻿namespace CouncilGamingClub
{
    partial class frmExistingData
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
            this.gvCustInfo = new System.Windows.Forms.DataGridView();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // gvCustInfo
            // 
            this.gvCustInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCustInfo.Location = new System.Drawing.Point(4, 86);
            this.gvCustInfo.Location = new System.Drawing.Point(105, 106);
            this.gvCustInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gvCustInfo.Name = "gvCustInfo";
            this.gvCustInfo.RowHeadersWidth = 51;
            this.gvCustInfo.Size = new System.Drawing.Size(458, 278);
            this.gvCustInfo.TabIndex = 0;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(169, 483);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(113, 52);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "Add Customer ";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnEditCustomer
            // 
<<<<<<< HEAD
            this.btnEditCustomer.Location = new System.Drawing.Point(499, 483);
=======
            this.btnEditCustomer.Location = new System.Drawing.Point(324, 386);
>>>>>>> b8fa47d4527eea2d74d6b9434ed822730a95bd0e
            this.btnEditCustomer.Location = new System.Drawing.Point(283, 483);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(151, 64);
            this.btnEditCustomer.Size = new System.Drawing.Size(103, 52);
            this.btnEditCustomer.TabIndex = 1;
            this.btnEditCustomer.Text = "Edit Customer";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
<<<<<<< HEAD
            this.btnDeleteCustomer.Location = new System.Drawing.Point(855, 483);
=======
            this.btnDeleteCustomer.Location = new System.Drawing.Point(467, 386);
>>>>>>> b8fa47d4527eea2d74d6b9434ed822730a95bd0e
            this.btnDeleteCustomer.Location = new System.Drawing.Point(392, 483);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(151, 64);
            this.btnDeleteCustomer.Size = new System.Drawing.Size(111, 52);
            this.btnDeleteCustomer.TabIndex = 1;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // frmExistingData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1095, 559);
=======
            this.ClientSize = new System.Drawing.Size(800, 450);
>>>>>>> b8fa47d4527eea2d74d6b9434ed822730a95bd0e
            this.ClientSize = new System.Drawing.Size(733, 559);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.gvCustInfo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmExistingData";
            this.Text = "Existing Customer Data";
            this.Activated += new System.EventHandler(this.frmExistingData_Activated);
            this.Load += new System.EventHandler(this.frmExistingData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCustInfo)).EndInit();
            this.ResumeLayout(false);

            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        }

        #endregion

        private System.Windows.Forms.DataGridView gvCustInfo;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
    }
}