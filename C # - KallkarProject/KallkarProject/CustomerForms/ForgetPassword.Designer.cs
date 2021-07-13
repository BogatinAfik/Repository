namespace KallkarProject
{
    partial class ForgetPassword
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
            this.Enter_Id = new System.Windows.Forms.Label();
            this.Enter_Email = new System.Windows.Forms.Label();
            this.Id_Input = new System.Windows.Forms.TextBox();
            this.Email_Input = new System.Windows.Forms.TextBox();
            this.Resend_Password = new System.Windows.Forms.Button();
            this.email_send_button = new System.Windows.Forms.Button();
            this.home_page_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Enter_Id
            // 
            this.Enter_Id.AutoSize = true;
            this.Enter_Id.Font = new System.Drawing.Font("Levenim MT", 14F);
            this.Enter_Id.Location = new System.Drawing.Point(128, 163);
            this.Enter_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Enter_Id.Name = "Enter_Id";
            this.Enter_Id.Size = new System.Drawing.Size(126, 37);
            this.Enter_Id.TabIndex = 0;
            this.Enter_Id.Text = "Enter ID:";
            // 
            // Enter_Email
            // 
            this.Enter_Email.AutoSize = true;
            this.Enter_Email.Font = new System.Drawing.Font("Levenim MT", 14F);
            this.Enter_Email.Location = new System.Drawing.Point(128, 241);
            this.Enter_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Enter_Email.Name = "Enter_Email";
            this.Enter_Email.Size = new System.Drawing.Size(171, 37);
            this.Enter_Email.TabIndex = 1;
            this.Enter_Email.Text = "Enter Email:";
            // 
            // Id_Input
            // 
            this.Id_Input.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Id_Input.Location = new System.Drawing.Point(319, 170);
            this.Id_Input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Id_Input.Name = "Id_Input";
            this.Id_Input.Size = new System.Drawing.Size(258, 30);
            this.Id_Input.TabIndex = 2;
            this.Id_Input.TextChanged += new System.EventHandler(this.Id_Input_TextChanged);
            // 
            // Email_Input
            // 
            this.Email_Input.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Email_Input.Location = new System.Drawing.Point(319, 249);
            this.Email_Input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Email_Input.Name = "Email_Input";
            this.Email_Input.Size = new System.Drawing.Size(258, 30);
            this.Email_Input.TabIndex = 3;
            this.Email_Input.TextChanged += new System.EventHandler(this.Email_Input_TextChanged);
            // 
            // Resend_Password
            // 
            this.Resend_Password.BackColor = System.Drawing.Color.White;
            this.Resend_Password.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.Resend_Password.Location = new System.Drawing.Point(319, 331);
            this.Resend_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Resend_Password.Name = "Resend_Password";
            this.Resend_Password.Size = new System.Drawing.Size(260, 37);
            this.Resend_Password.TabIndex = 4;
            this.Resend_Password.Text = "Resend My password";
            this.Resend_Password.UseVisualStyleBackColor = false;
            this.Resend_Password.Click += new System.EventHandler(this.Resend_Password_Click);
            // 
            // email_send_button
            // 
            this.email_send_button.BackColor = System.Drawing.Color.White;
            this.email_send_button.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.email_send_button.Location = new System.Drawing.Point(267, 298);
            this.email_send_button.Name = "email_send_button";
            this.email_send_button.Size = new System.Drawing.Size(352, 143);
            this.email_send_button.TabIndex = 5;
            this.email_send_button.Text = "please check your email and click here to login again";
            this.email_send_button.UseVisualStyleBackColor = false;
            this.email_send_button.Click += new System.EventHandler(this.email_send_button_Click);
            // 
            // home_page_button
            // 
            this.home_page_button.BackColor = System.Drawing.Color.Black;
            this.home_page_button.ForeColor = System.Drawing.Color.White;
            this.home_page_button.Location = new System.Drawing.Point(25, 12);
            this.home_page_button.Name = "home_page_button";
            this.home_page_button.Size = new System.Drawing.Size(122, 37);
            this.home_page_button.TabIndex = 6;
            this.home_page_button.Text = "home page";
            this.home_page_button.UseVisualStyleBackColor = false;
            this.home_page_button.Click += new System.EventHandler(this.home_page_button_Click);
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(785, 491);
            this.Controls.Add(this.home_page_button);
            this.Controls.Add(this.email_send_button);
            this.Controls.Add(this.Resend_Password);
            this.Controls.Add(this.Email_Input);
            this.Controls.Add(this.Id_Input);
            this.Controls.Add(this.Enter_Email);
            this.Controls.Add(this.Enter_Id);
            this.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ForgetPassword";
            this.Text = "ForgetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Enter_Id;
        private System.Windows.Forms.Label Enter_Email;
        private System.Windows.Forms.TextBox Id_Input;
        private System.Windows.Forms.TextBox Email_Input;
        private System.Windows.Forms.Button Resend_Password;
        private System.Windows.Forms.Button email_send_button;
        private System.Windows.Forms.Button home_page_button;
    }
}

