namespace CouncilGamingClub
{
    partial class OrdersWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.orderOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CGCLogo = new System.Windows.Forms.PictureBox();
            this.Employeeinfodisplay = new System.Windows.Forms.Panel();
            this.CHomeButton = new System.Windows.Forms.Button();
            this.tbOrderType = new System.Windows.Forms.TextBox();
            this.tbItemAmount = new System.Windows.Forms.TextBox();
            this.tbOrderID = new System.Windows.Forms.TextBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblTypeOfItem = new System.Windows.Forms.Label();
            this.lblInventoryId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CGCLogo)).BeginInit();
            this.Employeeinfodisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderOptionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // orderOptionsToolStripMenuItem
            // 
            this.orderOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewOrdersToolStripMenuItem});
            this.orderOptionsToolStripMenuItem.Name = "orderOptionsToolStripMenuItem";
            this.orderOptionsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.orderOptionsToolStripMenuItem.Text = "Options";
            // 
            // viewOrdersToolStripMenuItem
            // 
            this.viewOrdersToolStripMenuItem.Name = "viewOrdersToolStripMenuItem";
            this.viewOrdersToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.viewOrdersToolStripMenuItem.Text = "View Orders";
            this.viewOrdersToolStripMenuItem.Click += new System.EventHandler(this.viewOrdersToolStripMenuItem_Click);
            // 
            // CGCLogo
            // 
            this.CGCLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CGCLogo.BackgroundImage")));
            this.CGCLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CGCLogo.Image = ((System.Drawing.Image)(resources.GetObject("CGCLogo.Image")));
            this.CGCLogo.Location = new System.Drawing.Point(872, 16);
            this.CGCLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CGCLogo.Name = "CGCLogo";
            this.CGCLogo.Size = new System.Drawing.Size(100, 89);
            this.CGCLogo.TabIndex = 0;
            this.CGCLogo.TabStop = false;
            // 
            // Employeeinfodisplay
            // 
            this.Employeeinfodisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Employeeinfodisplay.Controls.Add(this.CHomeButton);
            this.Employeeinfodisplay.Controls.Add(this.CGCLogo);
            this.Employeeinfodisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.Employeeinfodisplay.Location = new System.Drawing.Point(0, 28);
            this.Employeeinfodisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Employeeinfodisplay.Name = "Employeeinfodisplay";
            this.Employeeinfodisplay.Size = new System.Drawing.Size(1067, 127);
            this.Employeeinfodisplay.TabIndex = 36;
            // 
            // CHomeButton
            // 
            this.CHomeButton.BackColor = System.Drawing.Color.Red;
            this.CHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CHomeButton.ForeColor = System.Drawing.Color.Snow;
            this.CHomeButton.Location = new System.Drawing.Point(3, 2);
            this.CHomeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CHomeButton.Name = "CHomeButton";
            this.CHomeButton.Size = new System.Drawing.Size(75, 23);
            this.CHomeButton.TabIndex = 42;
            this.CHomeButton.Text = "Home";
            this.CHomeButton.UseVisualStyleBackColor = false;
            this.CHomeButton.Click += new System.EventHandler(this.CHomeButton_Click);
            // 
            // tbOrderType
            // 
            this.tbOrderType.Location = new System.Drawing.Point(411, 271);
            this.tbOrderType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbOrderType.Name = "tbOrderType";
            this.tbOrderType.Size = new System.Drawing.Size(195, 22);
            this.tbOrderType.TabIndex = 41;
            // 
            // tbItemAmount
            // 
            this.tbItemAmount.Location = new System.Drawing.Point(288, 366);
            this.tbItemAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbItemAmount.Name = "tbItemAmount";
            this.tbItemAmount.Size = new System.Drawing.Size(184, 22);
            this.tbItemAmount.TabIndex = 42;
            // 
            // tbOrderID
            // 
            this.tbOrderID.Location = new System.Drawing.Point(115, 271);
            this.tbOrderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbOrderID.Name = "tbOrderID";
            this.tbOrderID.Size = new System.Drawing.Size(184, 22);
            this.tbOrderID.TabIndex = 43;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(567, 334);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(132, 30);
            this.lblTotalCost.TabIndex = 37;
            this.lblTotalCost.Text = "Total Cost";
            // 
            // lblTypeOfItem
            // 
            this.lblTypeOfItem.AutoSize = true;
            this.lblTypeOfItem.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOfItem.Location = new System.Drawing.Point(417, 239);
            this.lblTypeOfItem.Name = "lblTypeOfItem";
            this.lblTypeOfItem.Size = new System.Drawing.Size(171, 30);
            this.lblTypeOfItem.TabIndex = 38;
            this.lblTypeOfItem.Text = "Type Of Item";
            // 
            // lblInventoryId
            // 
            this.lblInventoryId.AutoSize = true;
            this.lblInventoryId.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryId.Location = new System.Drawing.Point(141, 239);
            this.lblInventoryId.Name = "lblInventoryId";
            this.lblInventoryId.Size = new System.Drawing.Size(119, 30);
            this.lblInventoryId.TabIndex = 39;
            this.lblInventoryId.Text = "Order ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 40;
            this.label1.Text = "Orders";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(724, 498);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 28);
            this.btnSubmit.TabIndex = 44;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(548, 366);
            this.txtTotalCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(184, 22);
            this.txtTotalCost.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 30);
            this.label2.TabIndex = 37;
            this.label2.Text = "Item Amount";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(696, 271);
            this.txtCustID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(184, 22);
            this.txtCustID.TabIndex = 42;
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.Location = new System.Drawing.Point(707, 239);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(163, 30);
            this.lblCustID.TabIndex = 38;
            this.lblCustID.Text = "Customer ID";
            // 
            // OrdersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 622);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbOrderType);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.tbItemAmount);
            this.Controls.Add(this.tbOrderID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.lblTypeOfItem);
            this.Controls.Add(this.lblInventoryId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Employeeinfodisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrdersWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders Window";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CGCLogo)).EndInit();
            this.Employeeinfodisplay.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem orderOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOrdersToolStripMenuItem;
        private System.Windows.Forms.PictureBox CGCLogo;
        private System.Windows.Forms.Panel Employeeinfodisplay;
        private System.Windows.Forms.Button CHomeButton;
        private System.Windows.Forms.TextBox tbOrderType;
        private System.Windows.Forms.TextBox tbItemAmount;
        private System.Windows.Forms.TextBox tbOrderID;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblTypeOfItem;
        private System.Windows.Forms.Label lblInventoryId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label lblCustID;
    }
}