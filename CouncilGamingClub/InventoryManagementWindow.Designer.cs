namespace CouncilGamingClub
{
    partial class InventoryManagementWindow
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
            this.lblManageOrders = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.gvInventory = new System.Windows.Forms.DataGridView();
            this.Return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManageOrders
            // 
            this.lblManageOrders.AutoSize = true;
            this.lblManageOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageOrders.Location = new System.Drawing.Point(344, 66);
            this.lblManageOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManageOrders.Name = "lblManageOrders";
            this.lblManageOrders.Size = new System.Drawing.Size(414, 54);
            this.lblManageOrders.TabIndex = 7;
            this.lblManageOrders.Text = "Manage Inventory";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(601, 432);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 57);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Inventory";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.Location = new System.Drawing.Point(460, 432);
            this.btnEditOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(133, 57);
            this.btnEditOrder.TabIndex = 5;
            this.btnEditOrder.Text = "Edit Inventory";
            this.btnEditOrder.UseVisualStyleBackColor = true;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(320, 432);
            this.btnAddOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(133, 57);
            this.btnAddOrder.TabIndex = 6;
            this.btnAddOrder.Text = "Add Inventory";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // gvInventory
            // 
            this.gvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvInventory.Location = new System.Drawing.Point(188, 128);
            this.gvInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvInventory.Name = "gvInventory";
            this.gvInventory.RowHeadersWidth = 51;
            this.gvInventory.Size = new System.Drawing.Size(692, 276);
            this.gvInventory.TabIndex = 3;
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(0, -1);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 23);
            this.Return.TabIndex = 8;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // InventoryManagementWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.lblManageOrders);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditOrder);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.gvInventory);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InventoryManagementWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management Window";
            this.Load += new System.EventHandler(this.InventoryManagementWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageOrders;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.DataGridView gvInventory;
        private System.Windows.Forms.Button Return;
    }
}