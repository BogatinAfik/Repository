namespace KallkarProject
{
    partial class Employee_login
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
            this.label1 = new System.Windows.Forms.Label();
            this.User_Name_Input = new System.Windows.Forms.TextBox();
            this.Password_Input = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Levenim MT", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(96, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // User_Name_Input
            // 
            this.User_Name_Input.BackColor = System.Drawing.Color.PaleTurquoise;
            this.User_Name_Input.Location = new System.Drawing.Point(268, 85);
            this.User_Name_Input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.User_Name_Input.Name = "User_Name_Input";
            this.User_Name_Input.Size = new System.Drawing.Size(207, 26);
            this.User_Name_Input.TabIndex = 1;
            // 
            // Password_Input
            // 
            this.Password_Input.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Password_Input.Location = new System.Drawing.Point(268, 152);
            this.Password_Input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Password_Input.Name = "Password_Input";
            this.Password_Input.PasswordChar = '*';
            this.Password_Input.Size = new System.Drawing.Size(207, 26);
            this.Password_Input.TabIndex = 2;
            this.Password_Input.TextChanged += new System.EventHandler(this.Password_Input_TextChanged);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Levenim MT", 12F, System.Drawing.FontStyle.Bold);
            this.Password.Location = new System.Drawing.Point(96, 152);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(124, 33);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Levenim MT", 16F);
            this.button1.Location = new System.Drawing.Point(302, 235);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 67);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Login_Click);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back_button.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.back_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_button.Location = new System.Drawing.Point(12, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(124, 39);
            this.back_button.TabIndex = 5;
            this.back_button.Text = "home page";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Employee_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(698, 363);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Password_Input);
            this.Controls.Add(this.User_Name_Input);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Employee_login";
            this.Text = "Employee_login";
            this.Load += new System.EventHandler(this.Employee_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox User_Name_Input;
        private System.Windows.Forms.TextBox Password_Input;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button back_button;
    }
}


