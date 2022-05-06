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
            this.tbInvID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTypeOfItem = new System.Windows.Forms.TextBox();
            this.tbItemAmount = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblInventoryId = new System.Windows.Forms.Label();
            this.lblTypeOfItem = new System.Windows.Forms.Label();
            this.lblItemAmount = new System.Windows.Forms.Label();
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
            this.Employeeinfodisplay.Margin = new System.Windows.Forms.Padding(2);
            this.Employeeinfodisplay.Name = "Employeeinfodisplay";
            this.Employeeinfodisplay.Size = new System.Drawing.Size(790, 118);
            this.Employeeinfodisplay.TabIndex = 24;
            // 
            // OHomeButton
            // 
            this.OHomeButton.BackColor = System.Drawing.Color.Red;
            this.OHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OHomeButton.ForeColor = System.Drawing.Color.Snow;
            this.OHomeButton.Location = new System.Drawing.Point(26, 80);
            this.OHomeButton.Margin = new System.Windows.Forms.Padding(2);
            this.OHomeButton.Name = "OHomeButton";
            this.OHomeButton.Size = new System.Drawing.Size(56, 19);
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
            this.CGCLogo.Location = new System.Drawing.Point(654, 27);
            this.CGCLogo.Margin = new System.Windows.Forms.Padding(2);
            this.CGCLogo.Name = "CGCLogo";
            this.CGCLogo.Size = new System.Drawing.Size(75, 72);
            this.CGCLogo.TabIndex = 0;
            this.CGCLogo.TabStop = false;
            // 
            // inventoryMmenuStrip
            // 
            this.inventoryMmenuStrip.AllowMerge = false;
            this.inventoryMmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryOptionsToolStripMenuItem});
            this.inventoryMmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.inventoryMmenuStrip.Name = "inventoryMmenuStrip";
            this.inventoryMmenuStrip.Size = new System.Drawing.Size(790, 24);
            this.inventoryMmenuStrip.TabIndex = 35;
            this.inventoryMmenuStrip.Text = "inventoryStrip";
            // 
            // inventoryOptionsToolStripMenuItem
            // 
            this.inventoryOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInventoryToolStripMenuItem});
            this.inventoryOptionsToolStripMenuItem.Name = "inventoryOptionsToolStripMenuItem";
            this.inventoryOptionsToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.inventoryOptionsToolStripMenuItem.Text = "Inventory Options";
            // 
            // viewInventoryToolStripMenuItem
            // 
            this.viewInventoryToolStripMenuItem.Name = "viewInventoryToolStripMenuItem";
            this.viewInventoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewInventoryToolStripMenuItem.Text = "View Inventory";
            this.viewInventoryToolStripMenuItem.Click += new System.EventHandler(this.viewInventoryToolStripMenuItem_Click);
            // 
            // tbInvID
            // 
            this.tbInvID.Location = new System.Drawing.Point(87, 218);
            this.tbInvID.Margin = new System.Windows.Forms.Padding(2);
            this.tbInvID.Name = "tbInvID";
            this.tbInvID.Size = new System.Drawing.Size(171, 20);
            this.tbInvID.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Inventory";
            // 
            // tbTypeOfItem
            // 
            this.tbTypeOfItem.Location = new System.Drawing.Point(307, 218);
            this.tbTypeOfItem.Margin = new System.Windows.Forms.Padding(2);
            this.tbTypeOfItem.Name = "tbTypeOfItem";
            this.tbTypeOfItem.Size = new System.Drawing.Size(171, 20);
            this.tbTypeOfItem.TabIndex = 32;
            // 
            // tbItemAmount
            // 
            this.tbItemAmount.Location = new System.Drawing.Point(548, 218);
            this.tbItemAmount.Margin = new System.Windows.Forms.Padding(2);
            this.tbItemAmount.Name = "tbItemAmount";
            this.tbItemAmount.Size = new System.Drawing.Size(171, 20);
            this.tbItemAmount.TabIndex = 32;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(585, 422);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 33;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblInventoryId
            // 
            this.lblInventoryId.AutoSize = true;
            this.lblInventoryId.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryId.Location = new System.Drawing.Point(115, 188);
            this.lblInventoryId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInventoryId.Name = "lblInventoryId";
            this.lblInventoryId.Size = new System.Drawing.Size(126, 24);
            this.lblInventoryId.TabIndex = 25;
            this.lblInventoryId.Text = "Inventory ID";
            // 
            // lblTypeOfItem
            // 
            this.lblTypeOfItem.AutoSize = true;
            this.lblTypeOfItem.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOfItem.Location = new System.Drawing.Point(317, 188);
            this.lblTypeOfItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeOfItem.Name = "lblTypeOfItem";
            this.lblTypeOfItem.Size = new System.Drawing.Size(131, 24);
            this.lblTypeOfItem.TabIndex = 25;
            this.lblTypeOfItem.Text = "Type Of Item";
            // 
            // lblItemAmount
            // 
            this.lblItemAmount.AutoSize = true;
            this.lblItemAmount.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemAmount.Location = new System.Drawing.Point(581, 188);
            this.lblItemAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemAmount.Name = "lblItemAmount";
            this.lblItemAmount.Size = new System.Drawing.Size(130, 24);
            this.lblItemAmount.TabIndex = 25;
            this.lblItemAmount.Text = "Item Amount";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(790, 524);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.Employeeinfodisplay);
            this.Controls.Add(this.tbItemAmount);
            this.Controls.Add(this.tbTypeOfItem);
            this.Controls.Add(this.tbInvID);
            this.Controls.Add(this.lblItemAmount);
            this.Controls.Add(this.lblTypeOfItem);
            this.Controls.Add(this.lblInventoryId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.inventoryMmenuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox tbInvID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTypeOfItem;
        private System.Windows.Forms.TextBox tbItemAmount;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button OHomeButton;
        private System.Windows.Forms.MenuStrip inventoryMmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem inventoryOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInventoryToolStripMenuItem;
        private System.Windows.Forms.Label lblInventoryId;
        private System.Windows.Forms.Label lblTypeOfItem;
        private System.Windows.Forms.Label lblItemAmount;
    }
}