
namespace KallkarProject
{
    partial class Update_product_details
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
            this.Product_Id = new System.Windows.Forms.Label();
            this.Id_Input = new System.Windows.Forms.TextBox();
            this.name_input = new System.Windows.Forms.TextBox();
            this.Product_name = new System.Windows.Forms.Label();
            this.weight_input = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.Label();
            this.capacity_input = new System.Windows.Forms.TextBox();
            this.Capacity = new System.Windows.Forms.Label();
            this.price_input = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.url_input = new System.Windows.Forms.TextBox();
            this.Picture_url = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.product_category = new System.Windows.Forms.Label();
            this.Category_input = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Product_Id
            // 
            this.Product_Id.AutoSize = true;
            this.Product_Id.Location = new System.Drawing.Point(62, 58);
            this.Product_Id.Name = "Product_Id";
            this.Product_Id.Size = new System.Drawing.Size(58, 13);
            this.Product_Id.TabIndex = 0;
            this.Product_Id.Text = "Product ID";
            // 
            // Id_Input
            // 
            this.Id_Input.Location = new System.Drawing.Point(162, 58);
            this.Id_Input.Name = "Id_Input";
            this.Id_Input.Size = new System.Drawing.Size(100, 20);
            this.Id_Input.TabIndex = 1;
            this.Id_Input.TextChanged += new System.EventHandler(this.Id_Input_TextChanged);
            // 
            // name_input
            // 
            this.name_input.Location = new System.Drawing.Point(162, 111);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(100, 20);
            this.name_input.TabIndex = 3;
            this.name_input.TextChanged += new System.EventHandler(this.name_input_TextChanged);
            // 
            // Product_name
            // 
            this.Product_name.AutoSize = true;
            this.Product_name.Location = new System.Drawing.Point(62, 111);
            this.Product_name.Name = "Product_name";
            this.Product_name.Size = new System.Drawing.Size(75, 13);
            this.Product_name.TabIndex = 2;
            this.Product_name.Text = "Product Name";
            // 
            // weight_input
            // 
            this.weight_input.Location = new System.Drawing.Point(162, 164);
            this.weight_input.Name = "weight_input";
            this.weight_input.Size = new System.Drawing.Size(100, 20);
            this.weight_input.TabIndex = 5;
            this.weight_input.TextChanged += new System.EventHandler(this.weight_input_TextChanged);
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Location = new System.Drawing.Point(62, 164);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(41, 13);
            this.weight.TabIndex = 4;
            this.weight.Text = "Weight";
            // 
            // capacity_input
            // 
            this.capacity_input.Location = new System.Drawing.Point(162, 223);
            this.capacity_input.Name = "capacity_input";
            this.capacity_input.Size = new System.Drawing.Size(100, 20);
            this.capacity_input.TabIndex = 7;
            this.capacity_input.TextChanged += new System.EventHandler(this.capacity_input_TextChanged);
            // 
            // Capacity
            // 
            this.Capacity.AutoSize = true;
            this.Capacity.Location = new System.Drawing.Point(62, 223);
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(48, 13);
            this.Capacity.TabIndex = 6;
            this.Capacity.Text = "Capacity";
            // 
            // price_input
            // 
            this.price_input.Location = new System.Drawing.Point(474, 58);
            this.price_input.Name = "price_input";
            this.price_input.Size = new System.Drawing.Size(100, 20);
            this.price_input.TabIndex = 9;
            this.price_input.TextChanged += new System.EventHandler(this.price_input_TextChanged);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(374, 58);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(31, 13);
            this.Price.TabIndex = 8;
            this.Price.Text = "Price";
            // 
            // url_input
            // 
            this.url_input.Location = new System.Drawing.Point(474, 111);
            this.url_input.Name = "url_input";
            this.url_input.Size = new System.Drawing.Size(100, 20);
            this.url_input.TabIndex = 11;
            this.url_input.TextChanged += new System.EventHandler(this.url_input_TextChanged);
            // 
            // Picture_url
            // 
            this.Picture_url.AutoSize = true;
            this.Picture_url.Location = new System.Drawing.Point(374, 111);
            this.Picture_url.Name = "Picture_url";
            this.Picture_url.Size = new System.Drawing.Size(65, 13);
            this.Picture_url.TabIndex = 10;
            this.Picture_url.Text = "Picture URL";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(395, 223);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(179, 83);
            this.Save.TabIndex = 16;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 17;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // product_category
            // 
            this.product_category.AutoSize = true;
            this.product_category.Location = new System.Drawing.Point(374, 164);
            this.product_category.Name = "product_category";
            this.product_category.Size = new System.Drawing.Size(89, 13);
            this.product_category.TabIndex = 18;
            this.product_category.Text = "Product Category";
            // 
            // Category_input
            // 
            this.Category_input.FormattingEnabled = true;
            this.Category_input.Location = new System.Drawing.Point(474, 156);
            this.Category_input.Name = "Category_input";
            this.Category_input.Size = new System.Drawing.Size(121, 21);
            this.Category_input.TabIndex = 19;
            this.Category_input.SelectedIndexChanged += new System.EventHandler(this.Category_input_SelectedIndexChanged);
            // 
            // Update_product_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Category_input);
            this.Controls.Add(this.product_category);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.url_input);
            this.Controls.Add(this.Picture_url);
            this.Controls.Add(this.price_input);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.capacity_input);
            this.Controls.Add(this.Capacity);
            this.Controls.Add(this.weight_input);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.Product_name);
            this.Controls.Add(this.Id_Input);
            this.Controls.Add(this.Product_Id);
            this.Name = "Update_product_details";
            this.Text = "Update_product_details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Product_Id;
        private System.Windows.Forms.TextBox Id_Input;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.Label Product_name;
        private System.Windows.Forms.TextBox weight_input;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.TextBox capacity_input;
        private System.Windows.Forms.Label Capacity;
        private System.Windows.Forms.TextBox price_input;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox url_input;
        private System.Windows.Forms.Label Picture_url;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label product_category;
        private System.Windows.Forms.ComboBox Category_input;
    }
}






