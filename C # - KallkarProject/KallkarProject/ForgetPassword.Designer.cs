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
            this.SuspendLayout();
            // 
            // Enter_Id
            // 
            this.Enter_Id.AutoSize = true;
            this.Enter_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Enter_Id.Location = new System.Drawing.Point(172, 94);
            this.Enter_Id.Name = "Enter_Id";
            this.Enter_Id.Size = new System.Drawing.Size(107, 29);
            this.Enter_Id.TabIndex = 0;
            this.Enter_Id.Text = "Enter ID";
            // 
            // Enter_Email
            // 
            this.Enter_Email.AutoSize = true;
            this.Enter_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Enter_Email.Location = new System.Drawing.Point(172, 154);
            this.Enter_Email.Name = "Enter_Email";
            this.Enter_Email.Size = new System.Drawing.Size(148, 29);
            this.Enter_Email.TabIndex = 1;
            this.Enter_Email.Text = "Enter Email";
            // 
            // Id_Input
            // 
            this.Id_Input.Location = new System.Drawing.Point(350, 94);
            this.Id_Input.Name = "Id_Input";
            this.Id_Input.Size = new System.Drawing.Size(115, 20);
            this.Id_Input.TabIndex = 2;
            this.Id_Input.TextChanged += new System.EventHandler(this.Id_Input_TextChanged);
            // 
            // Email_Input
            // 
            this.Email_Input.Location = new System.Drawing.Point(350, 154);
            this.Email_Input.Name = "Email_Input";
            this.Email_Input.Size = new System.Drawing.Size(115, 20);
            this.Email_Input.TabIndex = 3;
            this.Email_Input.TextChanged += new System.EventHandler(this.Email_Input_TextChanged);
            // 
            // Resend_Password
            // 
            this.Resend_Password.Location = new System.Drawing.Point(309, 230);
            this.Resend_Password.Name = "Resend_Password";
            this.Resend_Password.Size = new System.Drawing.Size(156, 23);
            this.Resend_Password.TabIndex = 4;
            this.Resend_Password.Text = "Resend My password";
            this.Resend_Password.UseVisualStyleBackColor = true;
            this.Resend_Password.Click += new System.EventHandler(this.Resend_Password_Click);
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Resend_Password);
            this.Controls.Add(this.Email_Input);
            this.Controls.Add(this.Id_Input);
            this.Controls.Add(this.Enter_Email);
            this.Controls.Add(this.Enter_Id);
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
    }
}

