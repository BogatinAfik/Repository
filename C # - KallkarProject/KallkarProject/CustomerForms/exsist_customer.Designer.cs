
using System;

namespace KallkarProject
{
    partial class exsist_customer
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
            this.button = new System.Windows.Forms.Button();
            this.update_customer_information = new System.Windows.Forms.Button();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Name_input = new System.Windows.Forms.TextBox();
            this.Phone_input = new System.Windows.Forms.TextBox();
            this.Email_input = new System.Windows.Forms.TextBox();
            this.Birthday_input = new System.Windows.Forms.TextBox();
            this.Address_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Gender_input = new System.Windows.Forms.TextBox();
            this.Type_input = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ID_input = new System.Windows.Forms.TextBox();
            this.First_Name_input = new System.Windows.Forms.TextBox();
            this.UpdateOrder = new System.Windows.Forms.Button();
            this.home_page_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button.Location = new System.Drawing.Point(12, 355);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(235, 41);
            this.button.TabIndex = 0;
            this.button.Text = "Create New Order ";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.New_Order);
            // 
            // update_customer_information
            // 
            this.update_customer_information.BackColor = System.Drawing.Color.Turquoise;
            this.update_customer_information.Location = new System.Drawing.Point(324, 355);
            this.update_customer_information.Name = "update_customer_information";
            this.update_customer_information.Size = new System.Drawing.Size(233, 41);
            this.update_customer_information.TabIndex = 4;
            this.update_customer_information.Text = "Update Customer Information";
            this.update_customer_information.UseVisualStyleBackColor = false;
            this.update_customer_information.Click += new System.EventHandler(this.update_customer_information_Click);
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.Width = 150;
            // 
            // EmployeeId
            // 
            this.EmployeeId.DataPropertyName = "EmployeeId";
            this.EmployeeId.HeaderText = "EmployeeId";
            this.EmployeeId.MinimumWidth = 8;
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.Width = 150;
            // 
            // dOBDataGridViewTextBoxColumn1
            // 
            this.dOBDataGridViewTextBoxColumn1.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn1.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dOBDataGridViewTextBoxColumn1.Name = "dOBDataGridViewTextBoxColumn1";
            this.dOBDataGridViewTextBoxColumn1.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CustomerID";
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Last_Name_input
            // 
            this.Last_Name_input.Location = new System.Drawing.Point(246, 222);
            this.Last_Name_input.Name = "Last_Name_input";
            this.Last_Name_input.Size = new System.Drawing.Size(179, 26);
            this.Last_Name_input.TabIndex = 7;
            this.Last_Name_input.TextChanged += new System.EventHandler(this.Last_Name_input_TextChanged);
            // 
            // Phone_input
            // 
            this.Phone_input.Location = new System.Drawing.Point(246, 254);
            this.Phone_input.Name = "Phone_input";
            this.Phone_input.Size = new System.Drawing.Size(179, 26);
            this.Phone_input.TabIndex = 8;
            this.Phone_input.TextChanged += new System.EventHandler(this.Phone_input_TextChanged);
            // 
            // Email_input
            // 
            this.Email_input.Location = new System.Drawing.Point(246, 289);
            this.Email_input.Name = "Email_input";
            this.Email_input.Size = new System.Drawing.Size(179, 26);
            this.Email_input.TabIndex = 9;
            this.Email_input.TextChanged += new System.EventHandler(this.Email_input_TextChanged);
            // 
            // Birthday_input
            // 
            this.Birthday_input.Location = new System.Drawing.Point(616, 151);
            this.Birthday_input.Name = "Birthday_input";
            this.Birthday_input.Size = new System.Drawing.Size(179, 26);
            this.Birthday_input.TabIndex = 10;
            this.Birthday_input.TextChanged += new System.EventHandler(this.Birthday_input_TextChanged);
            // 
            // Address_input
            // 
            this.Address_input.Location = new System.Drawing.Point(616, 190);
            this.Address_input.Name = "Address_input";
            this.Address_input.Size = new System.Drawing.Size(179, 26);
            this.Address_input.TabIndex = 12;
            this.Address_input.TextChanged += new System.EventHandler(this.Address_input_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(139, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(137, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(136, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Last Name:";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold);
            this.Phone.Location = new System.Drawing.Point(139, 257);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(64, 22);
            this.Phone.TabIndex = 17;
            this.Phone.Text = "Phone:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold);
            this.Email.Location = new System.Drawing.Point(139, 289);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(57, 22);
            this.Email.TabIndex = 18;
            this.Email.Text = "Email:";
            // 
            // birthday
            // 
            this.birthday.AutoSize = true;
            this.birthday.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold);
            this.birthday.Location = new System.Drawing.Point(520, 155);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(81, 22);
            this.birthday.TabIndex = 19;
            this.birthday.Text = "birthday:";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold);
            this.Address.Location = new System.Drawing.Point(521, 194);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(80, 22);
            this.Address.TabIndex = 21;
            this.Address.Text = "Address:";
            // 
            // Gender_input
            // 
            this.Gender_input.Location = new System.Drawing.Point(616, 226);
            this.Gender_input.Name = "Gender_input";
            this.Gender_input.Size = new System.Drawing.Size(179, 26);
            this.Gender_input.TabIndex = 22;
            this.Gender_input.TextChanged += new System.EventHandler(this.Gender_input_TextChanged);
            // 
            // Type_input
            // 
            this.Type_input.Location = new System.Drawing.Point(616, 258);
            this.Type_input.Name = "Type_input";
            this.Type_input.Size = new System.Drawing.Size(179, 26);
            this.Type_input.TabIndex = 23;
            this.Type_input.TextChanged += new System.EventHandler(this.Type_input_TextChanged);
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold);
            this.Gender.Location = new System.Drawing.Point(521, 230);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(74, 22);
            this.Gender.TabIndex = 24;
            this.Gender.Text = "Gender:";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold);
            this.Type.Location = new System.Drawing.Point(521, 262);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(52, 22);
            this.Type.TabIndex = 25;
            this.Type.Text = "Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Levenim MT", 16F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(334, 56);
            this.label5.MaximumSize = new System.Drawing.Size(1000, 6000);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(394, 43);
            this.label5.TabIndex = 26;
            this.label5.Text = "My Personal Information";
            // 
            // ID_input
            // 
            this.ID_input.Location = new System.Drawing.Point(246, 155);
            this.ID_input.Name = "ID_input";
            this.ID_input.Size = new System.Drawing.Size(179, 26);
            this.ID_input.TabIndex = 27;
            this.ID_input.TextChanged += new System.EventHandler(this.ID_input_TextChanged);
            // 
            // First_Name_input
            // 
            this.First_Name_input.Location = new System.Drawing.Point(246, 190);
            this.First_Name_input.Name = "First_Name_input";
            this.First_Name_input.Size = new System.Drawing.Size(179, 26);
            this.First_Name_input.TabIndex = 28;
            this.First_Name_input.TextChanged += new System.EventHandler(this.First_Name_input_TextChanged);
            // 
            // UpdateOrder
            // 
            this.UpdateOrder.BackColor = System.Drawing.Color.PaleTurquoise;
            this.UpdateOrder.Location = new System.Drawing.Point(637, 355);
            this.UpdateOrder.Name = "UpdateOrder";
            this.UpdateOrder.Size = new System.Drawing.Size(215, 41);
            this.UpdateOrder.TabIndex = 29;
            this.UpdateOrder.Text = "Update Order";
            this.UpdateOrder.UseVisualStyleBackColor = false;
            this.UpdateOrder.Click += new System.EventHandler(this.UpdateOrder_Click);
            // 
            // home_page_button
            // 
            this.home_page_button.BackColor = System.Drawing.Color.Black;
            this.home_page_button.ForeColor = System.Drawing.Color.White;
            this.home_page_button.Location = new System.Drawing.Point(29, 12);
            this.home_page_button.Name = "home_page_button";
            this.home_page_button.Size = new System.Drawing.Size(111, 34);
            this.home_page_button.TabIndex = 30;
            this.home_page_button.Text = "home page";
            this.home_page_button.UseVisualStyleBackColor = false;
            this.home_page_button.Click += new System.EventHandler(this.home_page_button_Click);
            // 
            // exsist_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(879, 440);
            this.Controls.Add(this.home_page_button);
            this.Controls.Add(this.UpdateOrder);
            this.Controls.Add(this.First_Name_input);
            this.Controls.Add(this.ID_input);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Type_input);
            this.Controls.Add(this.Gender_input);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Address_input);
            this.Controls.Add(this.Birthday_input);
            this.Controls.Add(this.Email_input);
            this.Controls.Add(this.Phone_input);
            this.Controls.Add(this.Last_Name_input);
            this.Controls.Add(this.update_customer_information);
            this.Controls.Add(this.button);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "exsist_customer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Customer_details_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button update_customer_information;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox Last_Name_input;
        private System.Windows.Forms.TextBox Phone_input;
        private System.Windows.Forms.TextBox Email_input;
        private System.Windows.Forms.TextBox Birthday_input;
        private System.Windows.Forms.TextBox Address_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label birthday;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox Gender_input;
        private System.Windows.Forms.TextBox Type_input;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ID_input;
        private System.Windows.Forms.TextBox First_Name_input;
        private System.Windows.Forms.Button UpdateOrder;
        private System.Windows.Forms.Button home_page_button;
    }
}
