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
            this.label1 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Create_new_product
            // 
            this.Create_new_product.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Create_new_product.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.Create_new_product.Location = new System.Drawing.Point(0, 116);
            this.Create_new_product.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Create_new_product.Name = "Create_new_product";
            this.Create_new_product.Size = new System.Drawing.Size(399, 45);
            this.Create_new_product.TabIndex = 0;
            this.Create_new_product.Text = "Create new product";
            this.Create_new_product.UseVisualStyleBackColor = false;
            this.Create_new_product.Click += new System.EventHandler(this.Create_new_product_Click);
            // 
            // Update_Product_details
            // 
            this.Update_Product_details.BackColor = System.Drawing.Color.Turquoise;
            this.Update_Product_details.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.Update_Product_details.Location = new System.Drawing.Point(397, 116);
            this.Update_Product_details.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Update_Product_details.Name = "Update_Product_details";
            this.Update_Product_details.Size = new System.Drawing.Size(409, 45);
            this.Update_Product_details.TabIndex = 1;
            this.Update_Product_details.Text = "Update Product Details";
            this.Update_Product_details.UseVisualStyleBackColor = false;
            this.Update_Product_details.Click += new System.EventHandler(this.Update_Product_details_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Levenim MT", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Products";
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back_button.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.back_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_button.Location = new System.Drawing.Point(12, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(88, 32);
            this.back_button.TabIndex = 3;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // ProductMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::KallkarProject.Properties.Resources.WhatsApp_Image_2020_06_24_at_12_49_37;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 407);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Update_Product_details);
            this.Controls.Add(this.Create_new_product);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductMenu";
            this.Text = "ProducMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create_new_product;
        private System.Windows.Forms.Button Update_Product_details;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_button;
    }
}