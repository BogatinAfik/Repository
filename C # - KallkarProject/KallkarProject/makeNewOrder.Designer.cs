namespace KallkarProject
{
    partial class makeNewOrder
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
            this.catalog = new System.Windows.Forms.Button();
            this.newProduct = new System.Windows.Forms.Button();
            this.previwesOrder = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.targetDate = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // catalog
            // 
            this.catalog.Location = new System.Drawing.Point(636, 71);
            this.catalog.Name = "catalog";
            this.catalog.Size = new System.Drawing.Size(96, 50);
            this.catalog.TabIndex = 0;
            this.catalog.Text = "catalog";
            this.catalog.UseVisualStyleBackColor = true;
            this.catalog.Click += new System.EventHandler(this.catalog_Click);
            // 
            // newProduct
            // 
            this.newProduct.Location = new System.Drawing.Point(388, 71);
            this.newProduct.Name = "newProduct";
            this.newProduct.Size = new System.Drawing.Size(86, 50);
            this.newProduct.TabIndex = 1;
            this.newProduct.Text = "new product";
            this.newProduct.UseVisualStyleBackColor = true;
            this.newProduct.Click += new System.EventHandler(this.newProduct_Click);
            // 
            // previwesOrder
            // 
            this.previwesOrder.Location = new System.Drawing.Point(108, 71);
            this.previwesOrder.Name = "previwesOrder";
            this.previwesOrder.Size = new System.Drawing.Size(109, 50);
            this.previwesOrder.TabIndex = 2;
            this.previwesOrder.Text = "previwes order";
            this.previwesOrder.UseVisualStyleBackColor = true;
            this.previwesOrder.Click += new System.EventHandler(this.previwesOrder_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(362, 281);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 26);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // targetDate
            // 
            this.targetDate.AutoSize = true;
            this.targetDate.Location = new System.Drawing.Point(262, 281);
            this.targetDate.Name = "targetDate";
            this.targetDate.Size = new System.Drawing.Size(98, 20);
            this.targetDate.TabIndex = 4;
            this.targetDate.Text = "Target Date:";
            this.targetDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(713, 409);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 29);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // makeNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.targetDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.previwesOrder);
            this.Controls.Add(this.newProduct);
            this.Controls.Add(this.catalog);
            this.Name = "makeNewOrder";
            this.Text = "makeNewOrder";
            this.Load += new System.EventHandler(this.makeNewOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button catalog;
        private System.Windows.Forms.Button newProduct;
        private System.Windows.Forms.Button previwesOrder;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label targetDate;
        private System.Windows.Forms.Button Back;
    }
}
