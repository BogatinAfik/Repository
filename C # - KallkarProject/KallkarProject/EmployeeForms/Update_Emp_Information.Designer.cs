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
            this.Password_Input = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FullName_Input
            // 
            this.FullName_Input.BackColor = System.Drawing.Color.PaleTurquoise;
            this.FullName_Input.Location = new System.Drawing.Point(179, 103);
            this.FullName_Input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FullName_Input.Name = "FullName_Input";
            this.FullName_Input.Size = new System.Drawing.Size(148, 26);
            this.FullName_Input.TabIndex = 0;
            this.FullName_Input.TextChanged += new System.EventHandler(this.FullName_Input_TextChanged);
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullName.Location = new System.Drawing.Point(43, 103);
            this.FullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(89, 22);
            this.FullName.TabIndex = 1;
            this.FullName.Text = "Full Name";
            // 
            // Gender_Input
            // 
            this.Gender_Input.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Gender_Input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender_Input.FormattingEnabled = true;
            this.Gender_Input.Location = new System.Drawing.Point(179, 260);
            this.Gender_Input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Gender_Input.Name = "Gender_Input";
            this.Gender_Input.Size = new System.Drawing.Size(148, 28);
            this.Gender_Input.TabIndex = 2;
            this.Gender_Input.SelectedIndexChanged += new System.EventHandler(this.Gender_Input_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(43, 264);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gender";
            // 
            // Email_Input
            // 
            this.Email_Input.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Email_Input.Location = new System.Drawing.Point(179, 154);
            this.Email_Input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Email_Input.Name = "Email_Input";
            this.Email_Input.Size = new System.Drawing.Size(148, 26);
            this.Email_Input.TabIndex = 6;
            this.Email_Input.TextChanged += new System.EventHandler(this.Email_Input_TextChanged);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold);
            this.Email.Location = new System.Drawing.Point(43, 154);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(52, 22);
            this.Email.TabIndex = 7;
            this.Email.Text = "Email";
            // 
            // Password_Input
            // 
            this.Password_Input.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Password_Input.Location = new System.Drawing.Point(179, 204);
            this.Password_Input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Password_Input.Name = "Password_Input";
            this.Password_Input.PasswordChar = '*';
            this.Password_Input.Size = new System.Drawing.Size(148, 26);
            this.Password_Input.TabIndex = 10;
            this.Password_Input.TextChanged += new System.EventHandler(this.Password_Input_TextChanged);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold);
            this.Password.Location = new System.Drawing.Point(43, 208);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(85, 22);
            this.Password.TabIndex = 11;
            this.Password.Text = "Password";
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Save.Font = new System.Drawing.Font("Levenim MT", 16F);
            this.Save.Location = new System.Drawing.Point(209, 333);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(236, 51);
            this.Save.TabIndex = 12;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(1070, 18);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(112, 35);
            this.Exit.TabIndex = 13;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Levenim MT", 14F);
            this.label2.Location = new System.Drawing.Point(145, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 37);
            this.label2.TabIndex = 14;
            this.label2.Text = "Update My Information";
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back_button.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.back_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_button.Location = new System.Drawing.Point(12, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(70, 37);
            this.back_button.TabIndex = 15;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Update_Emp_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(622, 448);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Password_Input);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Email_Input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gender_Input);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.FullName_Input);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Update_Emp_Information";
            this.Text = "Update_Emp_Information";
            this.Load += new System.EventHandler(this.Update_Emp_Information_Load);
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
        private System.Windows.Forms.TextBox Password_Input;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back_button;
    }
}
