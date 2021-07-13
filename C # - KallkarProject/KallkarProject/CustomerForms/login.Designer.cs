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
            this.back_button = new System.Windows.Forms.Button();
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
            this.Id_Number.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Id_Number.Location = new System.Drawing.Point(292, 162);
            this.Id_Number.Name = "Id_Number";
            this.Id_Number.Size = new System.Drawing.Size(208, 26);
            this.Id_Number.TabIndex = 1;
            this.Id_Number.TextChanged += new System.EventHandler(this.Id_Number_TextChanged);
            // 
            // login_in_button
            // 
            this.login_in_button.AutoSize = true;
            this.login_in_button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.login_in_button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_in_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.login_in_button.Font = new System.Drawing.Font("Levenim MT", 16F);
            this.login_in_button.ForeColor = System.Drawing.Color.Black;
            this.login_in_button.Location = new System.Drawing.Point(336, 289);
            this.login_in_button.Name = "login_in_button";
            this.login_in_button.Size = new System.Drawing.Size(95, 44);
            this.login_in_button.TabIndex = 2;
            this.login_in_button.Text = "login";
            this.login_in_button.Click += new System.EventHandler(this.log_in_button_Click);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Password.Location = new System.Drawing.Point(291, 228);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(206, 26);
            this.Password.TabIndex = 3;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Levenim MT", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(119, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Levenim MT", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(119, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customer ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Forget_Password
            // 
            this.Forget_Password.BackColor = System.Drawing.Color.White;
            this.Forget_Password.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.Forget_Password.Location = new System.Drawing.Point(291, 361);
            this.Forget_Password.Name = "Forget_Password";
            this.Forget_Password.Size = new System.Drawing.Size(197, 33);
            this.Forget_Password.TabIndex = 6;
            this.Forget_Password.Text = "Forget Password";
            this.Forget_Password.UseVisualStyleBackColor = false;
            this.Forget_Password.Click += new System.EventHandler(this.Forget_Password_Click);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Black;
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(12, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(95, 34);
            this.back_button.TabIndex = 7;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(709, 480);
            this.Controls.Add(this.back_button);
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
        private System.Windows.Forms.Button back_button;
    }
}