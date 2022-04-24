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
            this.ReturnCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // gvCustInfo
            // 
            this.gvCustInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCustInfo.Location = new System.Drawing.Point(4, 86);
            this.gvCustInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvCustInfo.Name = "gvCustInfo";
            this.gvCustInfo.RowHeadersWidth = 51;
            this.gvCustInfo.Size = new System.Drawing.Size(1061, 342);
            this.gvCustInfo.TabIndex = 0;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(225, 475);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(151, 64);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "Add Customer ";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(432, 475);
            this.btnEditCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(151, 64);
            this.btnEditCustomer.TabIndex = 1;
            this.btnEditCustomer.Text = "Edit Customer";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(623, 475);
            this.btnDeleteCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(151, 64);
            this.btnDeleteCustomer.TabIndex = 1;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // ReturnCustomer
            // 
            this.ReturnCustomer.Location = new System.Drawing.Point(4, 14);
            this.ReturnCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.ReturnCustomer.Name = "ReturnCustomer";
            this.ReturnCustomer.Size = new System.Drawing.Size(99, 30);
            this.ReturnCustomer.TabIndex = 2;
            this.ReturnCustomer.Text = "Return";
            this.ReturnCustomer.UseVisualStyleBackColor = true;
            this.ReturnCustomer.Click += new System.EventHandler(this.ReturnCustomer_Click);
            // 
            // frmExistingData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ReturnCustomer);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.gvCustInfo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmExistingData";
            this.Text = "Existing Customer Data";
            this.Load += new System.EventHandler(this.frmExistingData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCustInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvCustInfo;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button ReturnCustomer;
    }
}