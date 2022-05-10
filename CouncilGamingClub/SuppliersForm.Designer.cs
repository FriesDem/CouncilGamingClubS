namespace CouncilGamingClub
{
    partial class SuppliersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppliersForm));
            this.Employeeinfodisplay = new System.Windows.Forms.Panel();
            this.CGCLogo = new System.Windows.Forms.PictureBox();
            this.SHomeButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSuppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSupplierID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbSupplierName = new System.Windows.Forms.TextBox();
            this.Employeeinfodisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CGCLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Employeeinfodisplay
            // 
            this.Employeeinfodisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Employeeinfodisplay.Controls.Add(this.CGCLogo);
            this.Employeeinfodisplay.Controls.Add(this.SHomeButton);
            this.Employeeinfodisplay.Controls.Add(this.menuStrip1);
            this.Employeeinfodisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.Employeeinfodisplay.Location = new System.Drawing.Point(0, 0);
            this.Employeeinfodisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Employeeinfodisplay.Name = "Employeeinfodisplay";
            this.Employeeinfodisplay.Size = new System.Drawing.Size(1053, 145);
            this.Employeeinfodisplay.TabIndex = 46;
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
            // SHomeButton
            // 
            this.SHomeButton.BackColor = System.Drawing.Color.Red;
            this.SHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SHomeButton.ForeColor = System.Drawing.Color.Snow;
            this.SHomeButton.Location = new System.Drawing.Point(3, 33);
            this.SHomeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SHomeButton.Name = "SHomeButton";
            this.SHomeButton.Size = new System.Drawing.Size(75, 23);
            this.SHomeButton.TabIndex = 53;
            this.SHomeButton.Text = "Home";
            this.SHomeButton.UseVisualStyleBackColor = false;
            this.SHomeButton.Click += new System.EventHandler(this.SHomeButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1053, 28);
            this.menuStrip1.TabIndex = 54;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSuppliersToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // viewSuppliersToolStripMenuItem
            // 
            this.viewSuppliersToolStripMenuItem.Name = "viewSuppliersToolStripMenuItem";
            this.viewSuppliersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewSuppliersToolStripMenuItem.Text = "View Suppliers";
            this.viewSuppliersToolStripMenuItem.Click += new System.EventHandler(this.viewSuppliersToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 47;
            this.label1.Text = "Suppliers";
            // 
            // tbSupplierID
            // 
            this.tbSupplierID.Location = new System.Drawing.Point(51, 251);
            this.tbSupplierID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSupplierID.Name = "tbSupplierID";
            this.tbSupplierID.Size = new System.Drawing.Size(241, 22);
            this.tbSupplierID.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 30);
            this.label2.TabIndex = 47;
            this.label2.Text = "Supplier ID";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(717, 251);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(223, 74);
            this.tbAddress.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 30);
            this.label3.TabIndex = 47;
            this.label3.Text = "Supplier Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(720, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 30);
            this.label5.TabIndex = 47;
            this.label5.Text = "Address";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(837, 436);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(135, 47);
            this.btnSubmit.TabIndex = 49;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbSupplierName
            // 
            this.tbSupplierName.Location = new System.Drawing.Point(381, 251);
            this.tbSupplierName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSupplierName.Name = "tbSupplierName";
            this.tbSupplierName.Size = new System.Drawing.Size(241, 22);
            this.tbSupplierName.TabIndex = 48;
            // 
            // SuppliersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1053, 645);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbSupplierName);
            this.Controls.Add(this.tbSupplierID);
            this.Controls.Add(this.Employeeinfodisplay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SuppliersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suppliers Form";
            this.Employeeinfodisplay.ResumeLayout(false);
            this.Employeeinfodisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CGCLogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Employeeinfodisplay;
        private System.Windows.Forms.PictureBox CGCLogo;
        private System.Windows.Forms.Button SHomeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSuppliersToolStripMenuItem;
        private System.Windows.Forms.TextBox tbSupplierID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbSupplierName;
    }
}