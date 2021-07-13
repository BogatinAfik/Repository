namespace KallkarProject
{
    partial class Ask_For_New_Product
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
            this.Product_name = new System.Windows.Forms.Label();
            this.ProductName_input = new System.Windows.Forms.TextBox();
            this.Product_Weight = new System.Windows.Forms.Label();
            this.Weight_Input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Product_Capacity_Input = new System.Windows.Forms.TextBox();
            this.Picture_URL = new System.Windows.Forms.Label();
            this.Picture_URL_Input = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Product_Category = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Levenim MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(106, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please insert the following information";
            // 
            // Product_name
            // 
            this.Product_name.AutoSize = true;
            this.Product_name.Location = new System.Drawing.Point(86, 104);
            this.Product_name.Name = "Product_name";
            this.Product_name.Size = new System.Drawing.Size(75, 13);
            this.Product_name.TabIndex = 1;
            this.Product_name.Text = "Product Name";
            // 
            // ProductName_input
            // 
            this.ProductName_input.Location = new System.Drawing.Point(234, 101);
            this.ProductName_input.Name = "ProductName_input";
            this.ProductName_input.Size = new System.Drawing.Size(100, 20);
            this.ProductName_input.TabIndex = 2;
            this.ProductName_input.TextChanged += new System.EventHandler(this.ProductName_input_TextChanged);
            // 
            // Product_Weight
            // 
            this.Product_Weight.AutoSize = true;
            this.Product_Weight.Location = new System.Drawing.Point(86, 164);
            this.Product_Weight.Name = "Product_Weight";
            this.Product_Weight.Size = new System.Drawing.Size(81, 13);
            this.Product_Weight.TabIndex = 3;
            this.Product_Weight.Text = "Product Weight";
            // 
            // Weight_Input
            // 
            this.Weight_Input.Location = new System.Drawing.Point(234, 157);
            this.Weight_Input.Name = "Weight_Input";
            this.Weight_Input.Size = new System.Drawing.Size(100, 20);
            this.Weight_Input.TabIndex = 4;
            this.Weight_Input.TextChanged += new System.EventHandler(this.Weight_Input_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Product Capacity";
            // 
            // Product_Capacity_Input
            // 
            this.Product_Capacity_Input.Location = new System.Drawing.Point(234, 211);
            this.Product_Capacity_Input.Name = "Product_Capacity_Input";
            this.Product_Capacity_Input.Size = new System.Drawing.Size(100, 20);
            this.Product_Capacity_Input.TabIndex = 6;
            this.Product_Capacity_Input.TextChanged += new System.EventHandler(this.Product_Capacity_Input_TextChanged);
            // 
            // Picture_URL
            // 
            this.Picture_URL.AutoSize = true;
            this.Picture_URL.Location = new System.Drawing.Point(86, 269);
            this.Picture_URL.Name = "Picture_URL";
            this.Picture_URL.Size = new System.Drawing.Size(105, 13);
            this.Picture_URL.TabIndex = 7;
            this.Picture_URL.Text = "Product Picture URL";
            // 
            // Picture_URL_Input
            // 
            this.Picture_URL_Input.Location = new System.Drawing.Point(234, 266);
            this.Picture_URL_Input.Name = "Picture_URL_Input";
            this.Picture_URL_Input.Size = new System.Drawing.Size(198, 20);
            this.Picture_URL_Input.TabIndex = 8;
            this.Picture_URL_Input.TextChanged += new System.EventHandler(this.Picture_URL_Input_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(234, 327);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Product_Category
            // 
            this.Product_Category.AutoSize = true;
            this.Product_Category.Location = new System.Drawing.Point(86, 327);
            this.Product_Category.Name = "Product_Category";
            this.Product_Category.Size = new System.Drawing.Size(89, 13);
            this.Product_Category.TabIndex = 10;
            this.Product_Category.Text = "Product Category";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(478, 172);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(156, 104);
            this.Save.TabIndex = 11;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(713, 396);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // Ask_For_New_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Product_Category);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Picture_URL_Input);
            this.Controls.Add(this.Picture_URL);
            this.Controls.Add(this.Product_Capacity_Input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Weight_Input);
            this.Controls.Add(this.Product_Weight);
            this.Controls.Add(this.ProductName_input);
            this.Controls.Add(this.Product_name);
            this.Controls.Add(this.label1);
            this.Name = "Ask_For_New_Product";
            this.Text = "Ask_For_New_Product";
            this.Load += new System.EventHandler(this.Ask_For_New_Product_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Product_name;
        private System.Windows.Forms.TextBox ProductName_input;
        private System.Windows.Forms.Label Product_Weight;
        private System.Windows.Forms.TextBox Weight_Input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Product_Capacity_Input;
        private System.Windows.Forms.Label Picture_URL;
        private System.Windows.Forms.TextBox Picture_URL_Input;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Product_Category;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Exit;
    }
}