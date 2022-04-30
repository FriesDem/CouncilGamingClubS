namespace CouncilGamingClub
{
    partial class UserManagement
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
            this.btnDeactivateStaff = new System.Windows.Forms.Button();
            this.btnresetpassword = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.gvUserList = new System.Windows.Forms.DataGridView();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnreturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeactivateStaff
            // 
            this.btnDeactivateStaff.Location = new System.Drawing.Point(644, 495);
            this.btnDeactivateStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeactivateStaff.Name = "btnDeactivateStaff";
            this.btnDeactivateStaff.Size = new System.Drawing.Size(213, 64);
            this.btnDeactivateStaff.TabIndex = 3;
            this.btnDeactivateStaff.Text = "Deactivate Staff/Activate Staff";
            this.btnDeactivateStaff.UseVisualStyleBackColor = true;
            this.btnDeactivateStaff.Click += new System.EventHandler(this.btnDeactivateStaff_Click);
            // 
            // btnresetpassword
            // 
            this.btnresetpassword.Location = new System.Drawing.Point(425, 495);
            this.btnresetpassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnresetpassword.Name = "btnresetpassword";
            this.btnresetpassword.Size = new System.Drawing.Size(151, 64);
            this.btnresetpassword.TabIndex = 4;
            this.btnresetpassword.Text = "Reset Password";
            this.btnresetpassword.UseVisualStyleBackColor = true;
            this.btnresetpassword.Click += new System.EventHandler(this.btnresetpassword_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(152, 495);
            this.btnAddStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(151, 64);
            this.btnAddStaff.TabIndex = 5;
            this.btnAddStaff.Text = "Add New Staff";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // gvUserList
            // 
            this.gvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUserList.Location = new System.Drawing.Point(4, 111);
            this.gvUserList.Margin = new System.Windows.Forms.Padding(4);
            this.gvUserList.Name = "gvUserList";
            this.gvUserList.RowHeadersWidth = 51;
            this.gvUserList.Size = new System.Drawing.Size(932, 342);
            this.gvUserList.TabIndex = 2;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(4, 61);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(118, 42);
            this.btnrefresh.TabIndex = 6;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Manage Users";
            // 
            // btnreturn
            // 
            this.btnreturn.Location = new System.Drawing.Point(4, 13);
            this.btnreturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(100, 38);
            this.btnreturn.TabIndex = 11;
            this.btnreturn.Text = "Return";
            this.btnreturn.UseVisualStyleBackColor = true;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(974, 572);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnDeactivateStaff);
            this.Controls.Add(this.btnresetpassword);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.gvUserList);
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeactivateStaff;
        private System.Windows.Forms.Button btnresetpassword;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.DataGridView gvUserList;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnreturn;
    }
}