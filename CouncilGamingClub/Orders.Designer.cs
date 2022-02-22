namespace CouncilGamingClub
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.Employeeinfodisplay = new System.Windows.Forms.Panel();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.CGCLogo = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OHomeButton = new System.Windows.Forms.Button();
            this.OEditButton = new System.Windows.Forms.Button();
            this.ODeleteButton = new System.Windows.Forms.Button();
            this.OAddButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.OrderDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Employeeinfodisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CGCLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Employeeinfodisplay
            // 
            this.Employeeinfodisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Employeeinfodisplay.Controls.Add(this.LogoutButton);
            this.Employeeinfodisplay.Controls.Add(this.CGCLogo);
            this.Employeeinfodisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.Employeeinfodisplay.Location = new System.Drawing.Point(0, 0);
            this.Employeeinfodisplay.Name = "Employeeinfodisplay";
            this.Employeeinfodisplay.Size = new System.Drawing.Size(1053, 145);
            this.Employeeinfodisplay.TabIndex = 13;
            // 
            // LogoutButton
            // 
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogoutButton.ForeColor = System.Drawing.Color.Gold;
            this.LogoutButton.Location = new System.Drawing.Point(138, 98);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(78, 24);
            this.LogoutButton.TabIndex = 5;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            // 
            // CGCLogo
            // 
            this.CGCLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CGCLogo.BackgroundImage")));
            this.CGCLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CGCLogo.Image = ((System.Drawing.Image)(resources.GetObject("CGCLogo.Image")));
            this.CGCLogo.Location = new System.Drawing.Point(872, 33);
            this.CGCLogo.Name = "CGCLogo";
            this.CGCLogo.Size = new System.Drawing.Size(100, 89);
            this.CGCLogo.TabIndex = 0;
            this.CGCLogo.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(687, 405);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(227, 22);
            this.textBox4.TabIndex = 24;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(687, 347);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(227, 22);
            this.textBox3.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(687, 288);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 22);
            this.textBox2.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(687, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 22);
            this.textBox1.TabIndex = 21;
            // 
            // OHomeButton
            // 
            this.OHomeButton.BackColor = System.Drawing.Color.Red;
            this.OHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OHomeButton.ForeColor = System.Drawing.Color.Snow;
            this.OHomeButton.Location = new System.Drawing.Point(790, 573);
            this.OHomeButton.Name = "OHomeButton";
            this.OHomeButton.Size = new System.Drawing.Size(75, 23);
            this.OHomeButton.TabIndex = 20;
            this.OHomeButton.Text = "Home";
            this.OHomeButton.UseVisualStyleBackColor = false;
            this.OHomeButton.Click += new System.EventHandler(this.OHomeButton_Click);
            // 
            // OEditButton
            // 
            this.OEditButton.BackColor = System.Drawing.Color.Red;
            this.OEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OEditButton.ForeColor = System.Drawing.Color.Snow;
            this.OEditButton.Location = new System.Drawing.Point(936, 346);
            this.OEditButton.Name = "OEditButton";
            this.OEditButton.Size = new System.Drawing.Size(75, 23);
            this.OEditButton.TabIndex = 19;
            this.OEditButton.Text = "Edit";
            this.OEditButton.UseVisualStyleBackColor = false;
            // 
            // ODeleteButton
            // 
            this.ODeleteButton.BackColor = System.Drawing.Color.Red;
            this.ODeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ODeleteButton.ForeColor = System.Drawing.Color.Snow;
            this.ODeleteButton.Location = new System.Drawing.Point(936, 404);
            this.ODeleteButton.Name = "ODeleteButton";
            this.ODeleteButton.Size = new System.Drawing.Size(75, 23);
            this.ODeleteButton.TabIndex = 18;
            this.ODeleteButton.Text = "Delete";
            this.ODeleteButton.UseVisualStyleBackColor = false;
            // 
            // OAddButton
            // 
            this.OAddButton.BackColor = System.Drawing.Color.Red;
            this.OAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OAddButton.ForeColor = System.Drawing.Color.Snow;
            this.OAddButton.Location = new System.Drawing.Point(936, 288);
            this.OAddButton.Name = "OAddButton";
            this.OAddButton.Size = new System.Drawing.Size(75, 23);
            this.OAddButton.TabIndex = 17;
            this.OAddButton.Text = "Add";
            this.OAddButton.UseVisualStyleBackColor = false;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Red;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchButton.ForeColor = System.Drawing.Color.Snow;
            this.SearchButton.Location = new System.Drawing.Point(936, 218);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 16;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // OrderDataGrid
            // 
            this.OrderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDataGrid.Location = new System.Drawing.Point(28, 218);
            this.OrderDataGrid.Name = "OrderDataGrid";
            this.OrderDataGrid.RowHeadersWidth = 51;
            this.OrderDataGrid.RowTemplate.Height = 24;
            this.OrderDataGrid.Size = new System.Drawing.Size(604, 378);
            this.OrderDataGrid.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Orders";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1053, 645);
            this.Controls.Add(this.Employeeinfodisplay);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OHomeButton);
            this.Controls.Add(this.OEditButton);
            this.Controls.Add(this.ODeleteButton);
            this.Controls.Add(this.OAddButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.OrderDataGrid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Orders";
            this.Text = "Orders";
            this.Employeeinfodisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CGCLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Employeeinfodisplay;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.PictureBox CGCLogo;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button OHomeButton;
        private System.Windows.Forms.Button OEditButton;
        private System.Windows.Forms.Button ODeleteButton;
        private System.Windows.Forms.Button OAddButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView OrderDataGrid;
        private System.Windows.Forms.Label label1;
    }
}