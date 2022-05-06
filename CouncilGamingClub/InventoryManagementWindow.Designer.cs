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
            this.button3 = new System.Windows.Forms.Button();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.addOrder = new System.Windows.Forms.Button();
            this.gvInventory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManageOrders
            // 
            this.lblManageOrders.AutoSize = true;
            this.lblManageOrders.Font = new System.Drawing.Font("Dosis", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageOrders.Location = new System.Drawing.Point(278, 54);
            this.lblManageOrders.Name = "lblManageOrders";
            this.lblManageOrders.Size = new System.Drawing.Size(287, 47);
            this.lblManageOrders.TabIndex = 7;
            this.lblManageOrders.Text = "Manage Inventory";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(451, 351);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 46);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.Location = new System.Drawing.Point(345, 351);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(100, 46);
            this.btnEditOrder.TabIndex = 5;
            this.btnEditOrder.Text = "Edit";
            this.btnEditOrder.UseVisualStyleBackColor = true;
            // 
            // addOrder
            // 
            this.addOrder.Location = new System.Drawing.Point(240, 351);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(100, 46);
            this.addOrder.TabIndex = 6;
            this.addOrder.Text = "Add";
            this.addOrder.UseVisualStyleBackColor = true;
            // 
            // gvInventory
            // 
            this.gvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvInventory.Location = new System.Drawing.Point(141, 104);
            this.gvInventory.Name = "gvInventory";
            this.gvInventory.Size = new System.Drawing.Size(519, 224);
            this.gvInventory.TabIndex = 3;
            // 
            // InventoryManagementWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblManageOrders);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnEditOrder);
            this.Controls.Add(this.addOrder);
            this.Controls.Add(this.gvInventory);
            this.Name = "InventoryManagementWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management Window";
            ((System.ComponentModel.ISupportInitialize)(this.gvInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageOrders;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.Button addOrder;
        private System.Windows.Forms.DataGridView gvInventory;
    }
}