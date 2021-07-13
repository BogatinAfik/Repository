namespace KallkarProject
{
    partial class Update_Emp_Information
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
            this.FullName_Input = new System.Windows.Forms.TextBox();
            this.FullName = new System.Windows.Forms.Label();
            this.Gender_Input = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Email_Input = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.Role_Input = new System.Windows.Forms.ComboBox();
            this.Emp_Role = new System.Windows.Forms.Label();
            this.Password_Input = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FullName_Input
            // 
            this.FullName_Input.Location = new System.Drawing.Point(159, 74);
            this.FullName_Input.Name = "FullName_Input";
            this.FullName_Input.Size = new System.Drawing.Size(100, 20);
            this.FullName_Input.TabIndex = 0;
            this.FullName_Input.TextChanged += new System.EventHandler(this.FullName_Input_TextChanged);
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Location = new System.Drawing.Point(40, 81);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(54, 13);
            this.FullName.TabIndex = 1;
            this.FullName.Text = "Full Name";
            // 
            // Gender_Input
            // 
            this.Gender_Input.FormattingEnabled = true;
            this.Gender_Input.Location = new System.Drawing.Point(159, 137);
            this.Gender_Input.Name = "Gender_Input";
            this.Gender_Input.Size = new System.Drawing.Size(121, 21);
            this.Gender_Input.TabIndex = 2;
            this.Gender_Input.SelectedIndexChanged += new System.EventHandler(this.Gender_Input_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gender";
            // 
            // Email_Input
            // 
            this.Email_Input.Location = new System.Drawing.Point(159, 191);
            this.Email_Input.Name = "Email_Input";
            this.Email_Input.Size = new System.Drawing.Size(100, 20);
            this.Email_Input.TabIndex = 6;
            this.Email_Input.TextChanged += new System.EventHandler(this.Email_Input_TextChanged);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(40, 194);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 7;
            this.Email.Text = "Email";
            // 
            // Role_Input
            // 
            this.Role_Input.FormattingEnabled = true;
            this.Role_Input.Location = new System.Drawing.Point(457, 81);
            this.Role_Input.Name = "Role_Input";
            this.Role_Input.Size = new System.Drawing.Size(121, 21);
            this.Role_Input.TabIndex = 8;
            this.Role_Input.SelectedIndexChanged += new System.EventHandler(this.Role_Input_SelectedIndexChanged);
            // 
            // Emp_Role
            // 
            this.Emp_Role.AutoSize = true;
            this.Emp_Role.Location = new System.Drawing.Point(373, 81);
            this.Emp_Role.Name = "Emp_Role";
            this.Emp_Role.Size = new System.Drawing.Size(29, 13);
            this.Emp_Role.TabIndex = 9;
            this.Emp_Role.Text = "Role";
            // 
            // Password_Input
            // 
            this.Password_Input.Location = new System.Drawing.Point(457, 145);
            this.Password_Input.Name = "Password_Input";
            this.Password_Input.PasswordChar = '*';
            this.Password_Input.Size = new System.Drawing.Size(100, 20);
            this.Password_Input.TabIndex = 10;
            this.Password_Input.TextChanged += new System.EventHandler(this.Password_Input_TextChanged);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(373, 145);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 11;
            this.Password.Text = "Password";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(257, 247);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(206, 57);
            this.Save.TabIndex = 12;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(713, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 13;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Update_Emp_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Password_Input);
            this.Controls.Add(this.Emp_Role);
            this.Controls.Add(this.Role_Input);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Email_Input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gender_Input);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.FullName_Input);
            this.Name = "Update_Emp_Information";
            this.Text = "Update_Emp_Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FullName_Input;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.ComboBox Gender_Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Email_Input;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.ComboBox Role_Input;
        private System.Windows.Forms.Label Emp_Role;
        private System.Windows.Forms.TextBox Password_Input;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Exit;
    }
}
