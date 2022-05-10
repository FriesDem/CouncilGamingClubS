namespace CouncilGamingClub
{
    partial class frmManageSuppliers
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
            this.lblManageSuppliers = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditSupplier = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.gvSuppliers = new System.Windows.Forms.DataGridView();
            this.Return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManageSuppliers
            // 
            this.lblManageSuppliers.AutoSize = true;
            this.lblManageSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageSuppliers.Location = new System.Drawing.Point(344, 66);
            this.lblManageSuppliers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManageSuppliers.Name = "lblManageSuppliers";
            this.lblManageSuppliers.Size = new System.Drawing.Size(415, 54);
            this.lblManageSuppliers.TabIndex = 12;
            this.lblManageSuppliers.Text = "Manage Suppliers";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(601, 432);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 57);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete Supplier";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.Location = new System.Drawing.Point(460, 432);
            this.btnEditSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(133, 57);
            this.btnEditSupplier.TabIndex = 10;
            this.btnEditSupplier.Text = "Edit Supplier";
            this.btnEditSupplier.UseVisualStyleBackColor = true;
            this.btnEditSupplier.Click += new System.EventHandler(this.btnEditSupplier_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(320, 432);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(133, 57);
            this.btnAddSupplier.TabIndex = 11;
            this.btnAddSupplier.Text = "Add Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // gvSuppliers
            // 
            this.gvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSuppliers.Location = new System.Drawing.Point(188, 128);
            this.gvSuppliers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvSuppliers.Name = "gvSuppliers";
            this.gvSuppliers.RowHeadersWidth = 51;
            this.gvSuppliers.Size = new System.Drawing.Size(692, 276);
            this.gvSuppliers.TabIndex = 8;
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(3, 2);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 23);
            this.Return.TabIndex = 13;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // frmManageSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.lblManageSuppliers);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditSupplier);
            this.Controls.Add(this.btnAddSupplier);
            this.Controls.Add(this.gvSuppliers);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmManageSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Suppliers";
            ((System.ComponentModel.ISupportInitialize)(this.gvSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageSuppliers;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEditSupplier;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.DataGridView gvSuppliers;
        private System.Windows.Forms.Button Return;
    }
}