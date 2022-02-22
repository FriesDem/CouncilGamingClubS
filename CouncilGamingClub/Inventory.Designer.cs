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
            this.LogoutButton = new System.Windows.Forms.Button();
            this.CGCLogo = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IHomeButton = new System.Windows.Forms.Button();
            this.IEditButton = new System.Windows.Forms.Button();
            this.IDeleteButton = new System.Windows.Forms.Button();
            this.IAddButton = new System.Windows.Forms.Button();
            this.ISearchButton = new System.Windows.Forms.Button();
            this.InventoryDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Employeeinfodisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CGCLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataGrid)).BeginInit();
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
            this.Employeeinfodisplay.TabIndex = 24;
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
            this.textBox4.Location = new System.Drawing.Point(681, 415);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(227, 22);
            this.textBox4.TabIndex = 35;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(681, 357);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(227, 22);
            this.textBox3.TabIndex = 34;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(681, 298);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 22);
            this.textBox2.TabIndex = 33;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(681, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 22);
            this.textBox1.TabIndex = 32;
            // 
            // IHomeButton
            // 
            this.IHomeButton.BackColor = System.Drawing.Color.Red;
            this.IHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IHomeButton.ForeColor = System.Drawing.Color.Snow;
            this.IHomeButton.Location = new System.Drawing.Point(784, 583);
            this.IHomeButton.Name = "IHomeButton";
            this.IHomeButton.Size = new System.Drawing.Size(75, 23);
            this.IHomeButton.TabIndex = 31;
            this.IHomeButton.Text = "Home";
            this.IHomeButton.UseVisualStyleBackColor = false;
            this.IHomeButton.Click += new System.EventHandler(this.IHomeButton_Click);
            // 
            // IEditButton
            // 
            this.IEditButton.BackColor = System.Drawing.Color.Red;
            this.IEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IEditButton.ForeColor = System.Drawing.Color.Snow;
            this.IEditButton.Location = new System.Drawing.Point(930, 356);
            this.IEditButton.Name = "IEditButton";
            this.IEditButton.Size = new System.Drawing.Size(75, 23);
            this.IEditButton.TabIndex = 30;
            this.IEditButton.Text = "Edit";
            this.IEditButton.UseVisualStyleBackColor = false;
            // 
            // IDeleteButton
            // 
            this.IDeleteButton.BackColor = System.Drawing.Color.Red;
            this.IDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IDeleteButton.ForeColor = System.Drawing.Color.Snow;
            this.IDeleteButton.Location = new System.Drawing.Point(930, 414);
            this.IDeleteButton.Name = "IDeleteButton";
            this.IDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.IDeleteButton.TabIndex = 29;
            this.IDeleteButton.Text = "Delete";
            this.IDeleteButton.UseVisualStyleBackColor = false;
            // 
            // IAddButton
            // 
            this.IAddButton.BackColor = System.Drawing.Color.Red;
            this.IAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IAddButton.ForeColor = System.Drawing.Color.Snow;
            this.IAddButton.Location = new System.Drawing.Point(930, 298);
            this.IAddButton.Name = "IAddButton";
            this.IAddButton.Size = new System.Drawing.Size(75, 23);
            this.IAddButton.TabIndex = 28;
            this.IAddButton.Text = "Add";
            this.IAddButton.UseVisualStyleBackColor = false;
            // 
            // ISearchButton
            // 
            this.ISearchButton.BackColor = System.Drawing.Color.Red;
            this.ISearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ISearchButton.ForeColor = System.Drawing.Color.Snow;
            this.ISearchButton.Location = new System.Drawing.Point(930, 228);
            this.ISearchButton.Name = "ISearchButton";
            this.ISearchButton.Size = new System.Drawing.Size(75, 23);
            this.ISearchButton.TabIndex = 27;
            this.ISearchButton.Text = "Search";
            this.ISearchButton.UseVisualStyleBackColor = false;
            // 
            // InventoryDataGrid
            // 
            this.InventoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryDataGrid.Location = new System.Drawing.Point(22, 228);
            this.InventoryDataGrid.Name = "InventoryDataGrid";
            this.InventoryDataGrid.RowHeadersWidth = 51;
            this.InventoryDataGrid.RowTemplate.Height = 24;
            this.InventoryDataGrid.Size = new System.Drawing.Size(604, 378);
            this.InventoryDataGrid.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Inventory";
            // 
            // Inventory
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
            this.Controls.Add(this.IHomeButton);
            this.Controls.Add(this.IEditButton);
            this.Controls.Add(this.IDeleteButton);
            this.Controls.Add(this.IAddButton);
            this.Controls.Add(this.ISearchButton);
            this.Controls.Add(this.InventoryDataGrid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Employeeinfodisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CGCLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataGrid)).EndInit();
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
        private System.Windows.Forms.Button IHomeButton;
        private System.Windows.Forms.Button IEditButton;
        private System.Windows.Forms.Button IDeleteButton;
        private System.Windows.Forms.Button IAddButton;
        private System.Windows.Forms.Button ISearchButton;
        private System.Windows.Forms.DataGridView InventoryDataGrid;
        private System.Windows.Forms.Label label1;
    }
}