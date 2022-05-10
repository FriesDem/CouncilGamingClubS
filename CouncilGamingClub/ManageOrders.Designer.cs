namespace CouncilGamingClub
{
    partial class ManageOrders
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
            this.gvOrders = new System.Windows.Forms.DataGridView();
            this.addOrder = new System.Windows.Forms.Button();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblManageOrders = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // gvOrders
            // 
            this.gvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrders.Location = new System.Drawing.Point(167, 124);
            this.gvOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvOrders.Name = "gvOrders";
            this.gvOrders.RowHeadersWidth = 51;
            this.gvOrders.Size = new System.Drawing.Size(692, 276);
            this.gvOrders.TabIndex = 0;
            // 
            // addOrder
            // 
            this.addOrder.Location = new System.Drawing.Point(299, 428);
            this.addOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(133, 57);
            this.addOrder.TabIndex = 1;
            this.addOrder.Text = "Add Order";
            this.addOrder.UseVisualStyleBackColor = true;
            this.addOrder.Click += new System.EventHandler(this.addOrder_Click);
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.Location = new System.Drawing.Point(439, 428);
            this.btnEditOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(133, 57);
            this.btnEditOrder.TabIndex = 1;
            this.btnEditOrder.Text = "Edit Order";
            this.btnEditOrder.UseVisualStyleBackColor = true;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(580, 428);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 57);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete Order";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblManageOrders
            // 
            this.lblManageOrders.AutoSize = true;
            this.lblManageOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageOrders.Location = new System.Drawing.Point(349, 63);
            this.lblManageOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManageOrders.Name = "lblManageOrders";
            this.lblManageOrders.Size = new System.Drawing.Size(362, 54);
            this.lblManageOrders.TabIndex = 2;
            this.lblManageOrders.Text = "Manage Orders";
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(1, 2);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 23);
            this.Return.TabIndex = 3;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.lblManageOrders);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditOrder);
            this.Controls.Add(this.addOrder);
            this.Controls.Add(this.gvOrders);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManageOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Orders";
            this.Activated += new System.EventHandler(this.ManageOrders_Activated);
            this.Load += new System.EventHandler(this.ManageOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvOrders;
        private System.Windows.Forms.Button addOrder;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblManageOrders;
        private System.Windows.Forms.Button Return;
    }
}