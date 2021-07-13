
namespace KallkarProject
{
    partial class NewProduct
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
            this.product_information = new System.Windows.Forms.Label();
            this.name_input = new System.Windows.Forms.TextBox();
            this.Product_name = new System.Windows.Forms.Label();
            this.Weight_Input = new System.Windows.Forms.TextBox();
            this.capacity_input = new System.Windows.Forms.TextBox();
            this.price_input = new System.Windows.Forms.TextBox();
            this.picture_input = new System.Windows.Forms.TextBox();
            this.Product_Weight = new System.Windows.Forms.Label();
            this.Product_Capacity = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.Label();
            this.Product_Category_Input = new System.Windows.Forms.ComboBox();
            this.Product_Category = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // product_information
            // 
            this.product_information.AutoSize = true;
            this.product_information.Font = new System.Drawing.Font("Levenim MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.product_information.Location = new System.Drawing.Point(242, 14);
            this.product_information.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.product_information.Name = "product_information";
            this.product_information.Size = new System.Drawing.Size(690, 65);
            this.product_information.TabIndex = 0;
            this.product_information.Text = "Please insert product details";
            // 
            // name_input
            // 
            this.name_input.Location = new System.Drawing.Point(254, 206);
            this.name_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(148, 26);
            this.name_input.TabIndex = 3;
            this.name_input.TextChanged += new System.EventHandler(this.name_input_TextChanged);
            // 
            // Product_name
            // 
            this.Product_name.AutoSize = true;
            this.Product_name.Location = new System.Drawing.Point(92, 211);
            this.Product_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Product_name.Name = "Product_name";
            this.Product_name.Size = new System.Drawing.Size(110, 20);
            this.Product_name.TabIndex = 4;
            this.Product_name.Text = "Product Name";
            // 
            // Weight_Input
            // 
            this.Weight_Input.Location = new System.Drawing.Point(254, 291);
            this.Weight_Input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Weight_Input.Name = "Weight_Input";
            this.Weight_Input.Size = new System.Drawing.Size(148, 26);
            this.Weight_Input.TabIndex = 5;
            this.Weight_Input.TextChanged += new System.EventHandler(this.Weight_Input_TextChanged);
            // 
            // capacity_input
            // 
            this.capacity_input.Location = new System.Drawing.Point(254, 368);
            this.capacity_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.capacity_input.Name = "capacity_input";
            this.capacity_input.Size = new System.Drawing.Size(148, 26);
            this.capacity_input.TabIndex = 6;
            this.capacity_input.TextChanged += new System.EventHandler(this.capacity_input_TextChanged);
            // 
            // price_input
            // 
            this.price_input.Location = new System.Drawing.Point(254, 443);
            this.price_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.price_input.Name = "price_input";
            this.price_input.Size = new System.Drawing.Size(148, 26);
            this.price_input.TabIndex = 7;
            this.price_input.TextChanged += new System.EventHandler(this.price_input_TextChanged);
            // 
            // picture_input
            // 
            this.picture_input.Location = new System.Drawing.Point(254, 515);
            this.picture_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picture_input.Name = "picture_input";
            this.picture_input.Size = new System.Drawing.Size(148, 26);
            this.picture_input.TabIndex = 8;
            this.picture_input.TextChanged += new System.EventHandler(this.picture_input_TextChanged);
            // 
            // Product_Weight
            // 
            this.Product_Weight.AutoSize = true;
            this.Product_Weight.Location = new System.Drawing.Point(92, 295);
            this.Product_Weight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Product_Weight.Name = "Product_Weight";
            this.Product_Weight.Size = new System.Drawing.Size(118, 20);
            this.Product_Weight.TabIndex = 9;
            this.Product_Weight.Text = "Product Weight";
            // 
            // Product_Capacity
            // 
            this.Product_Capacity.AutoSize = true;
            this.Product_Capacity.Location = new System.Drawing.Point(92, 378);
            this.Product_Capacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Product_Capacity.Name = "Product_Capacity";
            this.Product_Capacity.Size = new System.Drawing.Size(129, 20);
            this.Product_Capacity.TabIndex = 10;
            this.Product_Capacity.Text = "Product Capacity";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(92, 454);
            this.Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(44, 20);
            this.Price.TabIndex = 11;
            this.Price.Text = "Price";
            // 
            // picture
            // 
            this.picture.AutoSize = true;
            this.picture.Location = new System.Drawing.Point(92, 526);
            this.picture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(128, 20);
            this.picture.TabIndex = 12;
            this.picture.Text = "Picture (optional)";
            // 
            // Product_Category_Input
            // 
            this.Product_Category_Input.FormattingEnabled = true;
            this.Product_Category_Input.Location = new System.Drawing.Point(254, 585);
            this.Product_Category_Input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Product_Category_Input.Name = "Product_Category_Input";
            this.Product_Category_Input.Size = new System.Drawing.Size(148, 28);
            this.Product_Category_Input.TabIndex = 13;
            this.Product_Category_Input.SelectedIndexChanged += new System.EventHandler(this.Product_Category_Input_SelectedIndexChanged);
            // 
            // Product_Category
            // 
            this.Product_Category.AutoSize = true;
            this.Product_Category.Location = new System.Drawing.Point(92, 597);
            this.Product_Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Product_Category.Name = "Product_Category";
            this.Product_Category.Size = new System.Drawing.Size(132, 20);
            this.Product_Category.TabIndex = 14;
            this.Product_Category.Text = "Product Category";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(681, 258);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(196, 94);
            this.Save.TabIndex = 15;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(18, 14);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(112, 35);
            this.Exit.TabIndex = 16;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Product_Category);
            this.Controls.Add(this.Product_Category_Input);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Product_Capacity);
            this.Controls.Add(this.Product_Weight);
            this.Controls.Add(this.picture_input);
            this.Controls.Add(this.price_input);
            this.Controls.Add(this.capacity_input);
            this.Controls.Add(this.Weight_Input);
            this.Controls.Add(this.Product_name);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.product_information);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewProduct";
            this.Text = "NewProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label product_information;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.Label Product_name;
        private System.Windows.Forms.TextBox Weight_Input;
        private System.Windows.Forms.TextBox capacity_input;
        private System.Windows.Forms.TextBox price_input;
        private System.Windows.Forms.TextBox picture_input;
        private System.Windows.Forms.Label Product_Weight;
        private System.Windows.Forms.Label Product_Capacity;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label picture;
        private System.Windows.Forms.ComboBox Product_Category_Input;
        private System.Windows.Forms.Label Product_Category;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Exit;
    }
}
