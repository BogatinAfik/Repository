namespace KallkarProject
{
    partial class ProductMenu
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
            this.Create_new_product = new System.Windows.Forms.Button();
            this.Update_Product_details = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Create_new_product
            // 
            this.Create_new_product.Location = new System.Drawing.Point(44, 85);
            this.Create_new_product.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Create_new_product.Name = "Create_new_product";
            this.Create_new_product.Size = new System.Drawing.Size(194, 149);
            this.Create_new_product.TabIndex = 0;
            this.Create_new_product.Text = "Create new product";
            this.Create_new_product.UseVisualStyleBackColor = true;
            this.Create_new_product.Click += new System.EventHandler(this.Create_new_product_Click);
            // 
            // Update_Product_details
            // 
            this.Update_Product_details.Location = new System.Drawing.Point(686, 85);
            this.Update_Product_details.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Update_Product_details.Name = "Update_Product_details";
            this.Update_Product_details.Size = new System.Drawing.Size(201, 149);
            this.Update_Product_details.TabIndex = 1;
            this.Update_Product_details.Text = "Update Product Details";
            this.Update_Product_details.UseVisualStyleBackColor = true;
            this.Update_Product_details.Click += new System.EventHandler(this.Update_Product_details_Click_1);
            // 
            // ProductMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.Update_Product_details);
            this.Controls.Add(this.Create_new_product);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductMenu";
            this.Text = "ProducMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Create_new_product;
        private System.Windows.Forms.Button Update_Product_details;
    }
}