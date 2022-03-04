namespace CouncilGamingClub
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.Employeeinfodisplay = new System.Windows.Forms.Panel();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.CGCLogo = new System.Windows.Forms.PictureBox();
            this.CustomerInfoButton = new System.Windows.Forms.Button();
            this.SuppliersButton = new System.Windows.Forms.Button();
            this.InventoryButton = new System.Windows.Forms.Button();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.Employeeinfodisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CGCLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Employeeinfodisplay
            // 
            this.Employeeinfodisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Employeeinfodisplay.Controls.Add(this.LogoutButton);
            this.Employeeinfodisplay.Controls.Add(this.CGCLogo);
            this.Employeeinfodisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.Employeeinfodisplay.Location = new System.Drawing.Point(0, 0);
            this.Employeeinfodisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Employeeinfodisplay.Name = "Employeeinfodisplay";
            this.Employeeinfodisplay.Size = new System.Drawing.Size(790, 118);
            this.Employeeinfodisplay.TabIndex = 5;
            // 
            // LogoutButton
            // 
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogoutButton.ForeColor = System.Drawing.Color.Gold;
            this.LogoutButton.Location = new System.Drawing.Point(104, 80);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(58, 20);
            this.LogoutButton.TabIndex = 5;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            // 
            // CGCLogo
            // 
            this.CGCLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CGCLogo.BackgroundImage")));
            this.CGCLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CGCLogo.Image = ((System.Drawing.Image)(resources.GetObject("CGCLogo.Image")));
            this.CGCLogo.Location = new System.Drawing.Point(654, 27);
            this.CGCLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CGCLogo.Name = "CGCLogo";
            this.CGCLogo.Size = new System.Drawing.Size(75, 72);
            this.CGCLogo.TabIndex = 0;
            this.CGCLogo.TabStop = false;
            // 
            // CustomerInfoButton
            // 
            this.CustomerInfoButton.Location = new System.Drawing.Point(83, 351);
            this.CustomerInfoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CustomerInfoButton.Name = "CustomerInfoButton";
            this.CustomerInfoButton.Size = new System.Drawing.Size(79, 61);
            this.CustomerInfoButton.TabIndex = 9;
            this.CustomerInfoButton.Text = "Customer Information";
            this.CustomerInfoButton.UseVisualStyleBackColor = true;
            this.CustomerInfoButton.Click += new System.EventHandler(this.CustomerInfoButton_Click);
            // 
            // SuppliersButton
            // 
            this.SuppliersButton.Location = new System.Drawing.Point(449, 351);
            this.SuppliersButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SuppliersButton.Name = "SuppliersButton";
            this.SuppliersButton.Size = new System.Drawing.Size(73, 61);
            this.SuppliersButton.TabIndex = 8;
            this.SuppliersButton.Text = "Suppliers";
            this.SuppliersButton.UseVisualStyleBackColor = true;
            this.SuppliersButton.Click += new System.EventHandler(this.SuppliersButton_Click);
            // 
            // InventoryButton
            // 
            this.InventoryButton.Location = new System.Drawing.Point(449, 204);
            this.InventoryButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InventoryButton.Name = "InventoryButton";
            this.InventoryButton.Size = new System.Drawing.Size(73, 61);
            this.InventoryButton.TabIndex = 7;
            this.InventoryButton.Text = "Inventory";
            this.InventoryButton.UseVisualStyleBackColor = true;
            this.InventoryButton.Click += new System.EventHandler(this.InventoryButton_Click);
            // 
            // OrdersButton
            // 
            this.OrdersButton.Location = new System.Drawing.Point(83, 204);
            this.OrdersButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(79, 61);
            this.OrdersButton.TabIndex = 6;
            this.OrdersButton.Text = "Orders";
            this.OrdersButton.UseVisualStyleBackColor = true;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(790, 524);
            this.Controls.Add(this.Employeeinfodisplay);
            this.Controls.Add(this.CustomerInfoButton);
            this.Controls.Add(this.SuppliersButton);
            this.Controls.Add(this.InventoryButton);
            this.Controls.Add(this.OrdersButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainPage";
            this.Text = "Form1";
            this.Employeeinfodisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CGCLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Employeeinfodisplay;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.PictureBox CGCLogo;
        private System.Windows.Forms.Button CustomerInfoButton;
        private System.Windows.Forms.Button SuppliersButton;
        private System.Windows.Forms.Button InventoryButton;
        private System.Windows.Forms.Button OrdersButton;
    }
}

