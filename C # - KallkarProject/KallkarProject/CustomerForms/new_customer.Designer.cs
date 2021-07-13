namespace KallkarProject
{
    partial class new_customer
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
            this.new_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.new_fname = new System.Windows.Forms.TextBox();
            this.new_lname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.ComboBox();
            this.type = new System.Windows.Forms.ComboBox();
            this.new_phone = new System.Windows.Forms.TextBox();
            this.new_email = new System.Windows.Forms.TextBox();
            this.new_address = new System.Windows.Forms.TextBox();
            this.new_password = new System.Windows.Forms.TextBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.back_button = new System.Windows.Forms.Button();
            this.succeeded_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // new_id
            // 
            this.new_id.Location = new System.Drawing.Point(214, 130);
            this.new_id.Name = "new_id";
            this.new_id.Size = new System.Drawing.Size(168, 26);
            this.new_id.TabIndex = 0;
            this.new_id.TextChanged += new System.EventHandler(this.new_id_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(100, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // new_fname
            // 
            this.new_fname.Location = new System.Drawing.Point(214, 172);
            this.new_fname.Name = "new_fname";
            this.new_fname.Size = new System.Drawing.Size(168, 26);
            this.new_fname.TabIndex = 2;
            // 
            // new_lname
            // 
            this.new_lname.Location = new System.Drawing.Point(213, 219);
            this.new_lname.Name = "new_lname";
            this.new_lname.Size = new System.Drawing.Size(167, 26);
            this.new_lname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(98, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(100, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(100, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(100, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(100, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Date Of Birth:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(494, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(494, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 22);
            this.label8.TabIndex = 10;
            this.label8.Text = "Password:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(500, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 22);
            this.label9.TabIndex = 11;
            this.label9.Text = "Gender:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(509, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 22);
            this.label10.TabIndex = 12;
            this.label10.Text = "Type:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // gender
            // 
            this.gender.BackColor = System.Drawing.SystemColors.HighlightText;
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.FormattingEnabled = true;
            this.gender.Location = new System.Drawing.Point(590, 281);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(139, 28);
            this.gender.TabIndex = 13;
            this.gender.SelectedIndexChanged += new System.EventHandler(this.gender_SelectedIndexChanged);
            // 
            // type
            // 
            this.type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(590, 337);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(139, 28);
            this.type.TabIndex = 14;
            this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // new_phone
            // 
            this.new_phone.Location = new System.Drawing.Point(214, 260);
            this.new_phone.Name = "new_phone";
            this.new_phone.Size = new System.Drawing.Size(166, 26);
            this.new_phone.TabIndex = 15;
            // 
            // new_email
            // 
            this.new_email.Location = new System.Drawing.Point(214, 302);
            this.new_email.Name = "new_email";
            this.new_email.Size = new System.Drawing.Size(166, 26);
            this.new_email.TabIndex = 16;
            // 
            // new_address
            // 
            this.new_address.Location = new System.Drawing.Point(595, 126);
            this.new_address.Name = "new_address";
            this.new_address.Size = new System.Drawing.Size(164, 26);
            this.new_address.TabIndex = 18;
            // 
            // new_password
            // 
            this.new_password.Location = new System.Drawing.Point(595, 172);
            this.new_password.Name = "new_password";
            this.new_password.PasswordChar = '*';
            this.new_password.Size = new System.Drawing.Size(164, 26);
            this.new_password.TabIndex = 19;
            // 
            // submit_button
            // 
            this.submit_button.BackColor = System.Drawing.Color.DarkTurquoise;
            this.submit_button.Font = new System.Drawing.Font("Levenim MT", 16F);
            this.submit_button.Location = new System.Drawing.Point(355, 425);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(190, 50);
            this.submit_button.TabIndex = 20;
            this.submit_button.Text = "submit";
            this.submit_button.UseVisualStyleBackColor = false;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Levenim MT", 16F);
            this.label11.Location = new System.Drawing.Point(279, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(405, 42);
            this.label11.TabIndex = 21;
            this.label11.Text = "please enter your details";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePicker1.Location = new System.Drawing.Point(218, 355);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 26);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Black;
            this.back_button.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(12, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(88, 37);
            this.back_button.TabIndex = 23;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // succeeded_button
            // 
            this.succeeded_button.BackColor = System.Drawing.Color.Gray;
            this.succeeded_button.Font = new System.Drawing.Font("Levenim MT", 14F);
            this.succeeded_button.Location = new System.Drawing.Point(266, 191);
            this.succeeded_button.Name = "succeeded_button";
            this.succeeded_button.Size = new System.Drawing.Size(379, 160);
            this.succeeded_button.TabIndex = 24;
            this.succeeded_button.Text = "your action succeeded. click here to login";
            this.succeeded_button.UseVisualStyleBackColor = false;
            this.succeeded_button.Click += new System.EventHandler(this.succeeded_button_Click);
            // 
            // new_customer
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 514);
            this.Controls.Add(this.succeeded_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.new_password);
            this.Controls.Add(this.new_address);
            this.Controls.Add(this.new_email);
            this.Controls.Add(this.new_phone);
            this.Controls.Add(this.type);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.new_lname);
            this.Controls.Add(this.new_fname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.new_id);
            this.Name = "new_customer";
            this.Load += new System.EventHandler(this.new_customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox new_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox new_fname;
        private System.Windows.Forms.TextBox new_lname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.TextBox new_phone;
        private System.Windows.Forms.TextBox new_email;
        private System.Windows.Forms.TextBox new_address;
        private System.Windows.Forms.TextBox new_password;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button succeeded_button;
    }
}
