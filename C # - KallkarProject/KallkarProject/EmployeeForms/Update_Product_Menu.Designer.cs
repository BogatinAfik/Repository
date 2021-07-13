namespace KallkarProject
{
    partial class Update_Product_Menu
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
            this.ProductID_forsearch = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sADM_4DataSet = new KallkarProject.SADM_4DataSet();
            this.productTableAdapter = new KallkarProject.SADM_4DataSetTableAdapters.ProductTableAdapter();
            this.product_list = new System.Windows.Forms.ListView();
            this.Product_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Capacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Picture_URL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Create_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.back_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sADM_4DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductID_forsearch
            // 
            this.ProductID_forsearch.AutoSize = true;
            this.ProductID_forsearch.Font = new System.Drawing.Font("Levenim MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ProductID_forsearch.Location = new System.Drawing.Point(64, 89);
            this.ProductID_forsearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductID_forsearch.Name = "ProductID_forsearch";
            this.ProductID_forsearch.Size = new System.Drawing.Size(351, 39);
            this.ProductID_forsearch.TabIndex = 0;
            this.ProductID_forsearch.Text = "Please Insert Product ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(443, 97);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.search.Font = new System.Drawing.Font("Levenim MT", 12F);
            this.search.Location = new System.Drawing.Point(481, 149);
            this.search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(162, 52);
            this.search.TabIndex = 2;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Update.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.Update.Location = new System.Drawing.Point(701, 52);
            this.Update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(212, 76);
            this.Update.TabIndex = 3;
            this.Update.Text = "Update Product details";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.sADM_4DataSet;
            // 
            // sADM_4DataSet
            // 
            this.sADM_4DataSet.DataSetName = "SADM_4DataSet";
            this.sADM_4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // product_list
            // 
            this.product_list.BackColor = System.Drawing.Color.PaleTurquoise;
            this.product_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Product_ID,
            this.Product_Name,
            this.weight,
            this.Capacity,
            this.Price,
            this.Picture_URL,
            this.Create_Date,
            this.Category});
            this.product_list.HideSelection = false;
            this.product_list.Location = new System.Drawing.Point(36, 243);
            this.product_list.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.product_list.Name = "product_list";
            this.product_list.Size = new System.Drawing.Size(877, 177);
            this.product_list.TabIndex = 4;
            this.product_list.UseCompatibleStateImageBehavior = false;
            this.product_list.View = System.Windows.Forms.View.Details;
            this.product_list.SelectedIndexChanged += new System.EventHandler(this.product_list_SelectedIndexChanged);
            // 
            // Product_ID
            // 
            this.Product_ID.Text = "Product ID";
            this.Product_ID.Width = 109;
            // 
            // Product_Name
            // 
            this.Product_Name.Text = "Product Name";
            this.Product_Name.Width = 103;
            // 
            // weight
            // 
            this.weight.Text = "Weight";
            this.weight.Width = 98;
            // 
            // Capacity
            // 
            this.Capacity.Text = "Capacity";
            this.Capacity.Width = 101;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // Picture_URL
            // 
            this.Picture_URL.Text = "Picture URL";
            this.Picture_URL.Width = 137;
            // 
            // Create_Date
            // 
            this.Create_Date.Text = "Create date";
            this.Create_Date.Width = 95;
            // 
            // Category
            // 
            this.Category.Text = "Catgory";
            this.Category.Width = 104;
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_button.Location = new System.Drawing.Point(12, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(103, 38);
            this.back_button.TabIndex = 5;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Update_Product_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(952, 483);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.product_list);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ProductID_forsearch);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Update_Product_Menu";
            this.Text = "Update_Product_Info";
            this.Load += new System.EventHandler(this.Update_Product_Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sADM_4DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductID_forsearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button Update;
        private SADM_4DataSet sADM_4DataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private SADM_4DataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.ListView product_list;
        private System.Windows.Forms.ColumnHeader Product_ID;
        private System.Windows.Forms.ColumnHeader Product_Name;
        private System.Windows.Forms.ColumnHeader weight;
        private System.Windows.Forms.ColumnHeader Capacity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Picture_URL;
        private System.Windows.Forms.ColumnHeader Create_Date;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.Button back_button;
    }
}
