namespace CouncilGamingClub
{
    partial class CustomerInfoPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerInfoPage));
            this.Employeeinfodisplay = new System.Windows.Forms.Panel();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.CHomeButton = new System.Windows.Forms.Button();
            this.CGCLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUniqueID = new System.Windows.Forms.TextBox();
            this.txtcustFName = new System.Windows.Forms.TextBox();
            this.txtcustLName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnViewData = new System.Windows.Forms.Button();
            this.Employeeinfodisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CGCLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Employeeinfodisplay
            // 
            this.Employeeinfodisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Employeeinfodisplay.Controls.Add(this.LogoutButton);
            this.Employeeinfodisplay.Controls.Add(this.CHomeButton);
            this.Employeeinfodisplay.Controls.Add(this.CGCLogo);
            this.Employeeinfodisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.Employeeinfodisplay.Location = new System.Drawing.Point(0, 0);
            this.Employeeinfodisplay.Margin = new System.Windows.Forms.Padding(2);
            this.Employeeinfodisplay.Name = "Employeeinfodisplay";
            this.Employeeinfodisplay.Size = new System.Drawing.Size(790, 118);
            this.Employeeinfodisplay.TabIndex = 35;
            // 
            // LogoutButton
            // 
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogoutButton.ForeColor = System.Drawing.Color.Gold;
            this.LogoutButton.Location = new System.Drawing.Point(104, 80);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(58, 20);
            this.LogoutButton.TabIndex = 5;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            // 
            // CHomeButton
            // 
            this.CHomeButton.BackColor = System.Drawing.Color.Red;
            this.CHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CHomeButton.ForeColor = System.Drawing.Color.Snow;
            this.CHomeButton.Location = new System.Drawing.Point(44, 80);
            this.CHomeButton.Margin = new System.Windows.Forms.Padding(2);
            this.CHomeButton.Name = "CHomeButton";
            this.CHomeButton.Size = new System.Drawing.Size(56, 19);
            this.CHomeButton.TabIndex = 42;
            this.CHomeButton.Text = "Home";
            this.CHomeButton.UseVisualStyleBackColor = false;
            this.CHomeButton.Click += new System.EventHandler(this.CHomeButton_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Customer Information";
            // 
            // txtUniqueID
            // 
            this.txtUniqueID.Location = new System.Drawing.Point(141, 200);
            this.txtUniqueID.Name = "txtUniqueID";
            this.txtUniqueID.Size = new System.Drawing.Size(100, 20);
            this.txtUniqueID.TabIndex = 37;
            // 
            // txtcustFName
            // 
            this.txtcustFName.Location = new System.Drawing.Point(141, 251);
            this.txtcustFName.Name = "txtcustFName";
            this.txtcustFName.Size = new System.Drawing.Size(100, 20);
            this.txtcustFName.TabIndex = 37;
            // 
            // txtcustLName
            // 
            this.txtcustLName.Location = new System.Drawing.Point(369, 251);
            this.txtcustLName.Name = "txtcustLName";
            this.txtcustLName.Size = new System.Drawing.Size(100, 20);
            this.txtcustLName.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(40, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Unique ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(40, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(278, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Last Name";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(141, 300);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(163, 55);
            this.txtAddress.TabIndex = 37;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(369, 198);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(100, 20);
            this.txtOrderID.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(281, 196);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Order ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(40, 298);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(40, 389);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(141, 391);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 37;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(303, 391);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 38);
            this.btnSubmit.TabIndex = 39;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnViewData
            // 
            this.btnViewData.Location = new System.Drawing.Point(403, 393);
            this.btnViewData.Name = "btnViewData";
            this.btnViewData.Size = new System.Drawing.Size(95, 36);
            this.btnViewData.TabIndex = 40;
            this.btnViewData.Text = "VIEW  DATA";
            this.btnViewData.UseVisualStyleBackColor = true;
            this.btnViewData.Click += new System.EventHandler(this.btnViewData_Click_1);
            // 
            // CustomerInfoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(790, 524);
            this.Controls.Add(this.btnViewData);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtcustLName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtcustFName);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.txtUniqueID);
            this.Controls.Add(this.Employeeinfodisplay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerInfoPage";
            this.Text = "CustomerInfoPage";
            this.Employeeinfodisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CGCLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Employeeinfodisplay;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.PictureBox CGCLogo;
        private System.Windows.Forms.Button CHomeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUniqueID;
        private System.Windows.Forms.TextBox txtcustFName;
        private System.Windows.Forms.TextBox txtcustLName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnViewData;
    }
}