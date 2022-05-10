namespace CouncilGamingClub
{
    partial class frmEditSupplier
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbSupplierID = new System.Windows.Forms.TextBox();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.tbSupplierName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tblEditOrders = new System.Windows.Forms.TableLayoutPanel();
            this.tbSupplierAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelChanges = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.tblEditOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "EDIT SUPPLIER INFO";
            // 
            // tbSupplierID
            // 
            this.tbSupplierID.Location = new System.Drawing.Point(436, 4);
            this.tbSupplierID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSupplierID.Name = "tbSupplierID";
            this.tbSupplierID.Size = new System.Drawing.Size(156, 22);
            this.tbSupplierID.TabIndex = 1;
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Location = new System.Drawing.Point(4, 0);
            this.lblSupplierID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(73, 16);
            this.lblSupplierID.TabIndex = 0;
            this.lblSupplierID.Text = "Supplier ID";
            // 
            // tbSupplierName
            // 
            this.tbSupplierName.Location = new System.Drawing.Point(436, 165);
            this.tbSupplierName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSupplierName.Name = "tbSupplierName";
            this.tbSupplierName.Size = new System.Drawing.Size(156, 22);
            this.tbSupplierName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier Name";
            // 
            // tblEditOrders
            // 
            this.tblEditOrders.ColumnCount = 2;
            this.tblEditOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblEditOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblEditOrders.Controls.Add(this.tbSupplierID, 1, 0);
            this.tblEditOrders.Controls.Add(this.lblSupplierID, 0, 0);
            this.tblEditOrders.Controls.Add(this.tbSupplierName, 1, 1);
            this.tblEditOrders.Controls.Add(this.tbSupplierAddress, 1, 2);
            this.tblEditOrders.Controls.Add(this.label2, 0, 2);
            this.tblEditOrders.Controls.Add(this.label1, 0, 1);
            this.tblEditOrders.Location = new System.Drawing.Point(101, 48);
            this.tblEditOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tblEditOrders.Name = "tblEditOrders";
            this.tblEditOrders.RowCount = 3;
            this.tblEditOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.00081F));
            this.tblEditOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0008F));
            this.tblEditOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0008F));
            this.tblEditOrders.Size = new System.Drawing.Size(865, 484);
            this.tblEditOrders.TabIndex = 7;
            // 
            // tbSupplierAddress
            // 
            this.tbSupplierAddress.Location = new System.Drawing.Point(436, 326);
            this.tbSupplierAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSupplierAddress.Name = "tbSupplierAddress";
            this.tbSupplierAddress.Size = new System.Drawing.Size(156, 22);
            this.tbSupplierAddress.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 322);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Supplier Address";
            // 
            // btnCancelChanges
            // 
            this.btnCancelChanges.Location = new System.Drawing.Point(669, 538);
            this.btnCancelChanges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelChanges.Name = "btnCancelChanges";
            this.btnCancelChanges.Size = new System.Drawing.Size(180, 47);
            this.btnCancelChanges.TabIndex = 10;
            this.btnCancelChanges.Text = "Cancel";
            this.btnCancelChanges.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(533, 28);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(213, 538);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(176, 47);
            this.btnSaveChanges.TabIndex = 11;
            this.btnSaveChanges.Text = "Save";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(3, 1);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 23);
            this.Return.TabIndex = 12;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // frmEditSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 594);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tblEditOrders);
            this.Controls.Add(this.btnCancelChanges);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnSaveChanges);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEditSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Supplier";
            this.tblEditOrders.ResumeLayout(false);
            this.tblEditOrders.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSupplierID;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.TextBox tbSupplierName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tblEditOrders;
        private System.Windows.Forms.TextBox tbSupplierAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelChanges;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button Return;
    }
}