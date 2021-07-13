namespace KallkarProject
{
    partial class Employee_Menu
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
            this.FullNameFill = new System.Windows.Forms.TextBox();
            this.EmailFill = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.DOB_Fill = new System.Windows.Forms.TextBox();
            this.Date_OF_Birth = new System.Windows.Forms.Label();
            this.emp_Role = new System.Windows.Forms.ComboBox();
            this.Role = new System.Windows.Forms.Label();
            this.KalKar_Factory = new System.Windows.Forms.Label();
            this.User_ID = new System.Windows.Forms.TextBox();
            this.ID_Number = new System.Windows.Forms.Label();
            this.Update_Emp_Details = new System.Windows.Forms.Button();
            this.Products = new System.Windows.Forms.Button();
            this.Orders = new System.Windows.Forms.Button();
            this.Production = new System.Windows.Forms.Button();
            this.Reports = new System.Windows.Forms.Button();
            this.storage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 251);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
            // 
            // FullNameFill
            // 
            this.FullNameFill.Location = new System.Drawing.Point(178, 251);
            this.FullNameFill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FullNameFill.Name = "FullNameFill";
            this.FullNameFill.Size = new System.Drawing.Size(148, 26);
            this.FullNameFill.TabIndex = 1;
            this.FullNameFill.TextChanged += new System.EventHandler(this.FullNameFill_TextChanged);
            // 
            // EmailFill
            // 
            this.EmailFill.Location = new System.Drawing.Point(178, 322);
            this.EmailFill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmailFill.Name = "EmailFill";
            this.EmailFill.Size = new System.Drawing.Size(148, 26);
            this.EmailFill.TabIndex = 2;
            this.EmailFill.TextChanged += new System.EventHandler(this.EmailFill_TextChanged);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(54, 326);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(48, 20);
            this.Email.TabIndex = 3;
            this.Email.Text = "Email";
            // 
            // DOB_Fill
            // 
            this.DOB_Fill.Location = new System.Drawing.Point(178, 388);
            this.DOB_Fill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DOB_Fill.Name = "DOB_Fill";
            this.DOB_Fill.Size = new System.Drawing.Size(148, 26);
            this.DOB_Fill.TabIndex = 4;
            this.DOB_Fill.TextChanged += new System.EventHandler(this.DOB_Fill_TextChanged);
            // 
            // Date_OF_Birth
            // 
            this.Date_OF_Birth.AutoSize = true;
            this.Date_OF_Birth.Location = new System.Drawing.Point(54, 398);
            this.Date_OF_Birth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Date_OF_Birth.Name = "Date_OF_Birth";
            this.Date_OF_Birth.Size = new System.Drawing.Size(99, 20);
            this.Date_OF_Birth.TabIndex = 5;
            this.Date_OF_Birth.Text = "Date of Birth";
            this.Date_OF_Birth.Click += new System.EventHandler(this.Date_OF_Birth_Click);
            // 
            // emp_Role
            // 
            this.emp_Role.FormattingEnabled = true;
            this.emp_Role.Location = new System.Drawing.Point(178, 454);
            this.emp_Role.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emp_Role.Name = "emp_Role";
            this.emp_Role.Size = new System.Drawing.Size(148, 28);
            this.emp_Role.TabIndex = 6;
            this.emp_Role.SelectedIndexChanged += new System.EventHandler(this.emp_Role_SelectedIndexChanged);
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Location = new System.Drawing.Point(58, 458);
            this.Role.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(42, 20);
            this.Role.TabIndex = 7;
            this.Role.Text = "Role";
            this.Role.Click += new System.EventHandler(this.label2_Click);
            // 
            // KalKar_Factory
            // 
            this.KalKar_Factory.AutoSize = true;
            this.KalKar_Factory.Font = new System.Drawing.Font("Levenim MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.KalKar_Factory.Location = new System.Drawing.Point(382, 42);
            this.KalKar_Factory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KalKar_Factory.Name = "KalKar_Factory";
            this.KalKar_Factory.Size = new System.Drawing.Size(385, 65);
            this.KalKar_Factory.TabIndex = 8;
            this.KalKar_Factory.Text = "Kal Kar Factory";
            // 
            // User_ID
            // 
            this.User_ID.Location = new System.Drawing.Point(177, 169);
            this.User_ID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.User_ID.Name = "User_ID";
            this.User_ID.Size = new System.Drawing.Size(148, 26);
            this.User_ID.TabIndex = 9;
            this.User_ID.TextChanged += new System.EventHandler(this.User_ID_TextChanged);
            // 
            // ID_Number
            // 
            this.ID_Number.AutoSize = true;
            this.ID_Number.Location = new System.Drawing.Point(54, 174);
            this.ID_Number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID_Number.Name = "ID_Number";
            this.ID_Number.Size = new System.Drawing.Size(86, 20);
            this.ID_Number.TabIndex = 10;
            this.ID_Number.Text = "ID Number";
            this.ID_Number.Click += new System.EventHandler(this.ID_Number_Click);
            // 
            // Update_Emp_Details
            // 
            this.Update_Emp_Details.Location = new System.Drawing.Point(825, 158);
            this.Update_Emp_Details.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Update_Emp_Details.Name = "Update_Emp_Details";
            this.Update_Emp_Details.Size = new System.Drawing.Size(264, 35);
            this.Update_Emp_Details.TabIndex = 11;
            this.Update_Emp_Details.Text = "Update Personal Information";
            this.Update_Emp_Details.UseVisualStyleBackColor = true;
            this.Update_Emp_Details.Click += new System.EventHandler(this.Update_Emp_Details_Click);
            // 
            // Products
            // 
            this.Products.Location = new System.Drawing.Point(825, 214);
            this.Products.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(264, 35);
            this.Products.TabIndex = 12;
            this.Products.Text = "Products";
            this.Products.UseVisualStyleBackColor = true;
            this.Products.Click += new System.EventHandler(this.Products_Click);
            // 
            // Orders
            // 
            this.Orders.Location = new System.Drawing.Point(825, 276);
            this.Orders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(264, 35);
            this.Orders.TabIndex = 13;
            this.Orders.Text = "Orders";
            this.Orders.UseVisualStyleBackColor = true;
            this.Orders.Click += new System.EventHandler(this.Orders_Click);
            // 
            // Production
            // 
            this.Production.Location = new System.Drawing.Point(825, 326);
            this.Production.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Production.Name = "Production";
            this.Production.Size = new System.Drawing.Size(264, 35);
            this.Production.TabIndex = 14;
            this.Production.Text = "Production";
            this.Production.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            this.Reports.Location = new System.Drawing.Point(825, 384);
            this.Reports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(264, 35);
            this.Reports.TabIndex = 15;
            this.Reports.Text = "Reports";
            this.Reports.UseVisualStyleBackColor = true;
            this.Reports.Click += new System.EventHandler(this.Reports_Click);
            // 
            // storage
            // 
            this.storage.Location = new System.Drawing.Point(825, 444);
            this.storage.Name = "storage";
            this.storage.Size = new System.Drawing.Size(264, 34);
            this.storage.TabIndex = 16;
            this.storage.Text = "storage";
            this.storage.UseVisualStyleBackColor = true;
            this.storage.Click += new System.EventHandler(this.storage_Click);
            // 
            // Employee_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.storage);
            this.Controls.Add(this.Reports);
            this.Controls.Add(this.Production);
            this.Controls.Add(this.Orders);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.Update_Emp_Details);
            this.Controls.Add(this.ID_Number);
            this.Controls.Add(this.User_ID);
            this.Controls.Add(this.KalKar_Factory);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.emp_Role);
            this.Controls.Add(this.Date_OF_Birth);
            this.Controls.Add(this.DOB_Fill);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.EmailFill);
            this.Controls.Add(this.FullNameFill);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Employee_Menu";
            this.Text = "Employee_Menu";
            this.Load += new System.EventHandler(this.Employee_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FullNameFill;
        private System.Windows.Forms.TextBox EmailFill;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox DOB_Fill;
        private System.Windows.Forms.Label Date_OF_Birth;
        private System.Windows.Forms.ComboBox emp_Role;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.Label KalKar_Factory;
        private System.Windows.Forms.TextBox User_ID;
        private System.Windows.Forms.Label ID_Number;
        private System.Windows.Forms.Button Update_Emp_Details;
        private System.Windows.Forms.Button Products;
        private System.Windows.Forms.Button Orders;
        private System.Windows.Forms.Button Production;
        private System.Windows.Forms.Button Reports;
        private System.Windows.Forms.Button storage;
        //    private System.Windows.Forms.Button storage_button;
    }
}