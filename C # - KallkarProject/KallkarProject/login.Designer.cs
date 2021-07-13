namespace KallkarProject
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Id_Number = new System.Windows.Forms.TextBox();
            this.login_in_button = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Forget_Password = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Id_Number
            // 
            this.Id_Number.Location = new System.Drawing.Point(292, 162);
            this.Id_Number.Name = "Id_Number";
            this.Id_Number.Size = new System.Drawing.Size(208, 26);
            this.Id_Number.TabIndex = 1;
            this.Id_Number.TextChanged += new System.EventHandler(this.Id_Number_TextChanged);
            // 
            // login_in_button
            // 
            this.login_in_button.AutoSize = true;
            this.login_in_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.login_in_button.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_in_button.Location = new System.Drawing.Point(572, 192);
            this.login_in_button.Name = "login_in_button";
            this.login_in_button.Size = new System.Drawing.Size(124, 71);
            this.login_in_button.TabIndex = 2;
            this.login_in_button.Text = "login";
            this.login_in_button.Click += new System.EventHandler(this.log_in_button_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(294, 263);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(206, 26);
            this.Password.TabIndex = 3;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(124, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(124, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Forget_Password
            // 
            this.Forget_Password.Location = new System.Drawing.Point(381, 378);
            this.Forget_Password.Name = "Forget_Password";
            this.Forget_Password.Size = new System.Drawing.Size(75, 23);
            this.Forget_Password.TabIndex = 6;
            this.Forget_Password.Text = "Forget Password";
            this.Forget_Password.UseVisualStyleBackColor = true;
            this.Forget_Password.Click += new System.EventHandler(this.Forget_Password_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.Forget_Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.login_in_button);
            this.Controls.Add(this.Id_Number);
            this.Name = "login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox Id_Number;
        private System.Windows.Forms.Label login_in_button;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Forget_Password;
    }
}