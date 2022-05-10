namespace CouncilGamingClub
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.Employeeinfodisplay = new System.Windows.Forms.Panel();
            this.OHomeButton = new System.Windows.Forms.Button();
            this.CGCLogo = new System.Windows.Forms.PictureBox();
            this.inventoryMmenuStrip = new System.Windows.Forms.MenuStrip();
            this.inventoryOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbItemID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.tbItemAmount = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblInventoryId = new System.Windows.Forms.Label();
            this.lblTypeOfItem = new System.Windows.Forms.Label();
            this.lblItemAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTypeOfItem = new System.Windows.Forms.TextBox();
            this.tbSupplierID = new System.Windows.Forms.TextBox();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.Employeeinfodisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CGCLogo)).BeginInit();
            this.inventoryMmenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Employeeinfodisplay
            // 
            this.Employeeinfodisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Employeeinfodisplay.Controls.Add(this.OHomeButton);
            this.Employeeinfodisplay.Controls.Add(this.CGCLogo);
            this.Employeeinfodisplay.Controls.Add(this.inventoryMmenuStrip);
            this.Employeeinfodisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.Employeeinfodisplay.Location = new System.Drawing.Point(0, 0);
            this.Employeeinfodisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Employeeinfodisplay.Name = "Employeeinfodisplay";
            this.Employeeinfodisplay.Size = new System.Drawing.Size(1053, 145);
            this.Employeeinfodisplay.TabIndex = 24;
            // 
            // OHomeButton
            // 
            this.OHomeButton.BackColor = System.Drawing.Color.Red;
            this.OHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OHomeButton.ForeColor = System.Drawing.Color.Snow;
            this.OHomeButton.Location = new System.Drawing.Point(35, 98);
            this.OHomeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OHomeButton.Name = "OHomeButton";
            this.OHomeButton.Size = new System.Drawing.Size(75, 23);
            this.OHomeButton.TabIndex = 34;
            this.OHomeButton.Text = "Home";
            this.OHomeButton.UseVisualStyleBackColor = false;
            this.OHomeButton.Click += new System.EventHandler(this.OHomeButton_Click);
            // 
            // CGCLogo
            // 
            this.CGCLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CGCLogo.BackgroundImage")));
            this.CGCLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CGCLogo.Image = ((System.Drawing.Image)(resources.GetObject("CGCLogo.Image")));
            this.CGCLogo.Location = new System.Drawing.Point(872, 33);
            this.CGCLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CGCLogo.Name = "CGCLogo";
            this.CGCLogo.Size = new System.Drawing.Size(100, 89);
            this.CGCLogo.TabIndex = 0;
            this.CGCLogo.TabStop = false;
            // 
            // inventoryMmenuStrip
            // 
            this.inventoryMmenuStrip.AllowMerge = false;
            this.inventoryMmenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.inventoryMmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryOptionsToolStripMenuItem});
            this.inventoryMmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.inventoryMmenuStrip.Name = "inventoryMmenuStrip";
            this.inventoryMmenuStrip.Size = new System.Drawing.Size(1053, 28);
            this.inventoryMmenuStrip.TabIndex = 35;
            this.inventoryMmenuStrip.Text = "inventoryStrip";
            // 
            // inventoryOptionsToolStripMenuItem
            // 
            this.inventoryOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInventoryToolStripMenuItem});
            this.inventoryOptionsToolStripMenuItem.Name = "inventoryOptionsToolStripMenuItem";
            this.inventoryOptionsToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.inventoryOptionsToolStripMenuItem.Text = "Inventory Options";
            // 
            // viewInventoryToolStripMenuItem
            // 
            this.viewInventoryToolStripMenuItem.Name = "viewInventoryToolStripMenuItem";
            this.viewInventoryToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.viewInventoryToolStripMenuItem.Text = "View Inventory";
            this.viewInventoryToolStripMenuItem.Click += new System.EventHandler(this.viewInventoryToolStripMenuItem_Click);
            // 
            // tbItemID
            // 
            this.tbItemID.Location = new System.Drawing.Point(116, 268);
            this.tbItemID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbItemID.Name = "tbItemID";
            this.tbItemID.Size = new System.Drawing.Size(227, 22);
            this.tbItemID.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Inventory";
            // 
            // tbItemName
            // 
            this.tbItemName.Location = new System.Drawing.Point(409, 268);
            this.tbItemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(227, 22);
            this.tbItemName.TabIndex = 32;
            // 
            // tbItemAmount
            // 
            this.tbItemAmount.Location = new System.Drawing.Point(731, 268);
            this.tbItemAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbItemAmount.Name = "tbItemAmount";
            this.tbItemAmount.Size = new System.Drawing.Size(227, 22);
            this.tbItemAmount.TabIndex = 32;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(825, 514);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(133, 43);
            this.btnSubmit.TabIndex = 33;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblInventoryId
            // 
            this.lblInventoryId.AutoSize = true;
            this.lblInventoryId.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryId.Location = new System.Drawing.Point(169, 231);
            this.lblInventoryId.Name = "lblInventoryId";
            this.lblInventoryId.Size = new System.Drawing.Size(107, 30);
            this.lblInventoryId.TabIndex = 25;
            this.lblInventoryId.Text = "Item ID";
            // 
            // lblTypeOfItem
            // 
            this.lblTypeOfItem.AutoSize = true;
            this.lblTypeOfItem.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOfItem.Location = new System.Drawing.Point(145, 358);
            this.lblTypeOfItem.Name = "lblTypeOfItem";
            this.lblTypeOfItem.Size = new System.Drawing.Size(171, 30);
            this.lblTypeOfItem.TabIndex = 25;
            this.lblTypeOfItem.Text = "Type Of Item";
            // 
            // lblItemAmount
            // 
            this.lblItemAmount.AutoSize = true;
            this.lblItemAmount.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemAmount.Location = new System.Drawing.Point(760, 231);
            this.lblItemAmount.Name = "lblItemAmount";
            this.lblItemAmount.Size = new System.Drawing.Size(168, 30);
            this.lblItemAmount.TabIndex = 25;
            this.lblItemAmount.Text = "Item Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 30);
            this.label2.TabIndex = 25;
            this.label2.Text = "Item Name";
            // 
            // tbTypeOfItem
            // 
            this.tbTypeOfItem.Location = new System.Drawing.Point(116, 390);
            this.tbTypeOfItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTypeOfItem.Name = "tbTypeOfItem";
            this.tbTypeOfItem.Size = new System.Drawing.Size(227, 22);
            this.tbTypeOfItem.TabIndex = 32;
            // 
            // tbSupplierID
            // 
            this.tbSupplierID.Location = new System.Drawing.Point(409, 390);
            this.tbSupplierID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSupplierID.Name = "tbSupplierID";
            this.tbSupplierID.Size = new System.Drawing.Size(227, 22);
            this.tbSupplierID.TabIndex = 32;
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierID.Location = new System.Drawing.Point(447, 358);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(148, 30);
            this.lblSupplierID.TabIndex = 25;
            this.lblSupplierID.Text = "Supplier ID";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1053, 645);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.Employeeinfodisplay);
            this.Controls.Add(this.tbItemAmount);
            this.Controls.Add(this.tbSupplierID);
            this.Controls.Add(this.tbTypeOfItem);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.tbItemID);
            this.Controls.Add(this.lblItemAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSupplierID);
            this.Controls.Add(this.lblTypeOfItem);
            this.Controls.Add(this.lblInventoryId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.inventoryMmenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Employeeinfodisplay.ResumeLayout(false);
            this.Employeeinfodisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CGCLogo)).EndInit();
            this.inventoryMmenuStrip.ResumeLayout(false);
            this.inventoryMmenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Employeeinfodisplay;
        private System.Windows.Forms.PictureBox CGCLogo;
        private System.Windows.Forms.TextBox tbItemID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.TextBox tbItemAmount;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button OHomeButton;
        private System.Windows.Forms.MenuStrip inventoryMmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem inventoryOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInventoryToolStripMenuItem;
        private System.Windows.Forms.Label lblInventoryId;
        private System.Windows.Forms.Label lblTypeOfItem;
        private System.Windows.Forms.Label lblItemAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTypeOfItem;
        private System.Windows.Forms.TextBox tbSupplierID;
        private System.Windows.Forms.Label lblSupplierID;
    }
}