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
            this.lblItemAmount = new System.Windows.Forms.Label();
            this.lblTypeOfItem = new System.Windows.Forms.Label();
            this.lblInventoryId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CGCLogo)).BeginInit();
            this.Employeeinfodisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderOptionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // orderOptionsToolStripMenuItem
            // 
            this.orderOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewOrdersToolStripMenuItem});
            this.orderOptionsToolStripMenuItem.Name = "orderOptionsToolStripMenuItem";
            this.orderOptionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.orderOptionsToolStripMenuItem.Text = "Options";
            // 
            // viewOrdersToolStripMenuItem
            // 
            this.viewOrdersToolStripMenuItem.Name = "viewOrdersToolStripMenuItem";
            this.viewOrdersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewOrdersToolStripMenuItem.Text = "View Orders";
            // 
            // CGCLogo
            // 
            this.CGCLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CGCLogo.BackgroundImage")));
            this.CGCLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CGCLogo.Image = ((System.Drawing.Image)(resources.GetObject("CGCLogo.Image")));
            this.CGCLogo.Location = new System.Drawing.Point(654, 13);
            this.CGCLogo.Margin = new System.Windows.Forms.Padding(2);
            this.CGCLogo.Name = "CGCLogo";
            this.CGCLogo.Size = new System.Drawing.Size(75, 72);
            this.CGCLogo.TabIndex = 0;
            this.CGCLogo.TabStop = false;
            // 
            // Employeeinfodisplay
            // 
            this.Employeeinfodisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Employeeinfodisplay.Controls.Add(this.CHomeButton);
            this.Employeeinfodisplay.Controls.Add(this.CGCLogo);
            this.Employeeinfodisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.Employeeinfodisplay.Location = new System.Drawing.Point(0, 24);
            this.Employeeinfodisplay.Margin = new System.Windows.Forms.Padding(2);
            this.Employeeinfodisplay.Name = "Employeeinfodisplay";
            this.Employeeinfodisplay.Size = new System.Drawing.Size(800, 103);
            this.Employeeinfodisplay.TabIndex = 36;
            // 
            // CHomeButton
            // 
            this.CHomeButton.BackColor = System.Drawing.Color.Red;
            this.CHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CHomeButton.ForeColor = System.Drawing.Color.Snow;
            this.CHomeButton.Location = new System.Drawing.Point(45, 66);
            this.CHomeButton.Margin = new System.Windows.Forms.Padding(2);
            this.CHomeButton.Name = "CHomeButton";
            this.CHomeButton.Size = new System.Drawing.Size(56, 19);
            this.CHomeButton.TabIndex = 42;
            this.CHomeButton.Text = "Home";
            this.CHomeButton.UseVisualStyleBackColor = false;
            // 
            // tbOrderType
            // 
            this.tbOrderType.Location = new System.Drawing.Point(353, 220);
            this.tbOrderType.Margin = new System.Windows.Forms.Padding(2);
            this.tbOrderType.Name = "tbOrderType";
            this.tbOrderType.Size = new System.Drawing.Size(147, 20);
            this.tbOrderType.TabIndex = 41;
            // 
            // tbItemAmount
            // 
            this.tbItemAmount.Location = new System.Drawing.Point(114, 297);
            this.tbItemAmount.Margin = new System.Windows.Forms.Padding(2);
            this.tbItemAmount.Name = "tbItemAmount";
            this.tbItemAmount.Size = new System.Drawing.Size(139, 20);
            this.tbItemAmount.TabIndex = 42;
            // 
            // tbOrderID
            // 
            this.tbOrderID.Location = new System.Drawing.Point(114, 220);
            this.tbOrderID.Margin = new System.Windows.Forms.Padding(2);
            this.tbOrderID.Name = "tbOrderID";
            this.tbOrderID.Size = new System.Drawing.Size(139, 20);
            this.tbOrderID.TabIndex = 43;
            // 
            // lblItemAmount
            // 
            this.lblItemAmount.AutoSize = true;
            this.lblItemAmount.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemAmount.Location = new System.Drawing.Point(123, 271);
            this.lblItemAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemAmount.Name = "lblItemAmount";
            this.lblItemAmount.Size = new System.Drawing.Size(130, 24);
            this.lblItemAmount.TabIndex = 37;
            this.lblItemAmount.Text = "Item Amount";
            // 
            // lblTypeOfItem
            // 
            this.lblTypeOfItem.AutoSize = true;
            this.lblTypeOfItem.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOfItem.Location = new System.Drawing.Point(360, 190);
            this.lblTypeOfItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeOfItem.Name = "lblTypeOfItem";
            this.lblTypeOfItem.Size = new System.Drawing.Size(131, 24);
            this.lblTypeOfItem.TabIndex = 38;
            this.lblTypeOfItem.Text = "Type Of Item";
            // 
            // lblInventoryId
            // 
            this.lblInventoryId.AutoSize = true;
            this.lblInventoryId.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryId.Location = new System.Drawing.Point(123, 194);
            this.lblInventoryId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInventoryId.Name = "lblInventoryId";
            this.lblInventoryId.Size = new System.Drawing.Size(92, 24);
            this.lblInventoryId.TabIndex = 39;
            this.lblInventoryId.Text = "Order ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "Orders";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(543, 405);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 44;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // OrdersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbOrderType);
            this.Controls.Add(this.tbItemAmount);
            this.Controls.Add(this.tbOrderID);
            this.Controls.Add(this.lblItemAmount);
            this.Controls.Add(this.lblTypeOfItem);
            this.Controls.Add(this.lblInventoryId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Employeeinfodisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.Label lblItemAmount;
        private System.Windows.Forms.Label lblTypeOfItem;
        private System.Windows.Forms.Label lblInventoryId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
    }
}