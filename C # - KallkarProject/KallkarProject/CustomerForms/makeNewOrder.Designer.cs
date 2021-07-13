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
            this.catalog.BackColor = System.Drawing.Color.PaleTurquoise;
            this.catalog.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.catalog.Location = new System.Drawing.Point(665, 264);
            this.catalog.Name = "catalog";
            this.catalog.Size = new System.Drawing.Size(258, 37);
            this.catalog.TabIndex = 0;
            this.catalog.Text = "choose from catalog";
            this.catalog.UseVisualStyleBackColor = false;
            this.catalog.Click += new System.EventHandler(this.catalog_Click);
            // 
            // newProduct
            // 
            this.newProduct.BackColor = System.Drawing.Color.Turquoise;
            this.newProduct.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.newProduct.Location = new System.Drawing.Point(333, 264);
            this.newProduct.Name = "newProduct";
            this.newProduct.Size = new System.Drawing.Size(338, 37);
            this.newProduct.TabIndex = 1;
            this.newProduct.Text = "ask for special product";
            this.newProduct.UseVisualStyleBackColor = false;
            this.newProduct.Click += new System.EventHandler(this.newProduct_Click);
            // 
            // previwesOrder
            // 
            this.previwesOrder.BackColor = System.Drawing.Color.DarkTurquoise;
            this.previwesOrder.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.previwesOrder.Location = new System.Drawing.Point(-5, 264);
            this.previwesOrder.Name = "previwesOrder";
            this.previwesOrder.Size = new System.Drawing.Size(343, 37);
            this.previwesOrder.TabIndex = 2;
            this.previwesOrder.Text = "choose from previous orders";
            this.previwesOrder.UseVisualStyleBackColor = false;
            this.previwesOrder.Click += new System.EventHandler(this.previwesOrder_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(356, 165);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 26);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // targetDate
            // 
            this.targetDate.AutoSize = true;
            this.targetDate.Font = new System.Drawing.Font("Levenim MT", 10F, System.Drawing.FontStyle.Bold);
            this.targetDate.Location = new System.Drawing.Point(309, 98);
            this.targetDate.Name = "targetDate";
            this.targetDate.Size = new System.Drawing.Size(334, 27);
            this.targetDate.TabIndex = 4;
            this.targetDate.Text = "Please Choose your Target Date:";
            this.targetDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Black;
            this.Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(87, 35);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // makeNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 473);
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
