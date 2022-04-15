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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.InventoryButton = new System.Windows.Forms.Button();
            this.CustomerInfoButton = new System.Windows.Forms.Button();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.SuppliersButton = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.Employeeinfodisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CGCLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Employeeinfodisplay
            // 
            this.Employeeinfodisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Employeeinfodisplay.Controls.Add(this.btnManage);
            this.Employeeinfodisplay.Controls.Add(this.LogoutButton);
            this.Employeeinfodisplay.Controls.Add(this.CGCLogo);
            this.Employeeinfodisplay.Location = new System.Drawing.Point(0, 0);
            this.Employeeinfodisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Employeeinfodisplay.Name = "Employeeinfodisplay";
            this.Employeeinfodisplay.Size = new System.Drawing.Size(1053, 145);
            this.Employeeinfodisplay.TabIndex = 5;
            // 
            // LogoutButton
            // 
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogoutButton.ForeColor = System.Drawing.Color.Gold;
            this.LogoutButton.Location = new System.Drawing.Point(40, 97);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(77, 25);
            this.LogoutButton.TabIndex = 5;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 255);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(599, 255);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // InventoryButton
            // 
            this.InventoryButton.FlatAppearance.BorderSize = 0;
            this.InventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InventoryButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryButton.Image = global::CouncilGamingClub.Properties.Resources.info_icon_edit_1;
            this.InventoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InventoryButton.Location = new System.Drawing.Point(599, 255);
            this.InventoryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InventoryButton.Name = "InventoryButton";
            this.InventoryButton.Size = new System.Drawing.Size(181, 55);
            this.InventoryButton.TabIndex = 9;
            this.InventoryButton.Text = "Inventory";
            this.InventoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InventoryButton.UseVisualStyleBackColor = true;
            this.InventoryButton.Click += new System.EventHandler(this.InventoryButton_Click);
            // 
            // CustomerInfoButton
            // 
            this.CustomerInfoButton.FlatAppearance.BorderSize = 0;
            this.CustomerInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerInfoButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerInfoButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CustomerInfoButton.Image = global::CouncilGamingClub.Properties.Resources.user_icon_esit_;
            this.CustomerInfoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomerInfoButton.Location = new System.Drawing.Point(152, 432);
            this.CustomerInfoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerInfoButton.Name = "CustomerInfoButton";
            this.CustomerInfoButton.Size = new System.Drawing.Size(213, 75);
            this.CustomerInfoButton.TabIndex = 9;
            this.CustomerInfoButton.Text = "Customer Info";
            this.CustomerInfoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CustomerInfoButton.UseVisualStyleBackColor = true;
            this.CustomerInfoButton.Click += new System.EventHandler(this.CustomerInfoButton_Click);
            // 
            // OrdersButton
            // 
            this.OrdersButton.FlatAppearance.BorderSize = 0;
            this.OrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdersButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdersButton.Image = global::CouncilGamingClub.Properties.Resources.order_icon_edit_;
            this.OrdersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrdersButton.Location = new System.Drawing.Point(152, 255);
            this.OrdersButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(157, 55);
            this.OrdersButton.TabIndex = 9;
            this.OrdersButton.Text = "Orders";
            this.OrdersButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OrdersButton.UseVisualStyleBackColor = true;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // SuppliersButton
            // 
            this.SuppliersButton.FlatAppearance.BorderSize = 0;
            this.SuppliersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SuppliersButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppliersButton.Image = ((System.Drawing.Image)(resources.GetObject("SuppliersButton.Image")));
            this.SuppliersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SuppliersButton.Location = new System.Drawing.Point(599, 432);
            this.SuppliersButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SuppliersButton.Name = "SuppliersButton";
            this.SuppliersButton.Size = new System.Drawing.Size(181, 75);
            this.SuppliersButton.TabIndex = 8;
            this.SuppliersButton.Text = "Suppliers";
            this.SuppliersButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SuppliersButton.UseVisualStyleBackColor = true;
            this.SuppliersButton.Click += new System.EventHandler(this.SuppliersButton_Click);
            // 
            // btnManage
            // 
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManage.ForeColor = System.Drawing.Color.Gold;
            this.btnManage.Location = new System.Drawing.Point(123, 97);
            this.btnManage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(122, 25);
            this.btnManage.TabIndex = 6;
            this.btnManage.Text = "ManageStaff";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1053, 645);
            this.Controls.Add(this.InventoryButton);
            this.Controls.Add(this.CustomerInfoButton);
            this.Controls.Add(this.OrdersButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Employeeinfodisplay);
            this.Controls.Add(this.SuppliersButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.Employeeinfodisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CGCLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Employeeinfodisplay;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.PictureBox CGCLogo;
        private System.Windows.Forms.Button SuppliersButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button OrdersButton;
        private System.Windows.Forms.Button InventoryButton;
        private System.Windows.Forms.Button CustomerInfoButton;
        private System.Windows.Forms.Button btnManage;
    }
}

