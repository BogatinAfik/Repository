namespace KallkarProject
{
    partial class OrderMenu
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
            this.create_order = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.search_dates = new System.Windows.Forms.Button();
            this.Orders_list = new System.Windows.Forms.ListView();
            this.OrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TargetDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreateDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Capacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Recent_Order = new System.Windows.Forms.Label();
            this.Customerinsert = new System.Windows.Forms.Label();
            this.Id_Input = new System.Windows.Forms.TextBox();
            this.Submut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // create_order
            // 
            this.create_order.Location = new System.Drawing.Point(12, 93);
            this.create_order.Name = "create_order";
            this.create_order.Size = new System.Drawing.Size(164, 54);
            this.create_order.TabIndex = 0;
            this.create_order.Text = "Create new order";
            this.create_order.UseVisualStyleBackColor = true;
            this.create_order.Click += new System.EventHandler(this.create_order_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search order by customer ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // search_dates
            // 
            this.search_dates.Location = new System.Drawing.Point(520, 93);
            this.search_dates.Name = "search_dates";
            this.search_dates.Size = new System.Drawing.Size(134, 54);
            this.search_dates.TabIndex = 3;
            this.search_dates.Text = "Search order by Date";
            this.search_dates.UseVisualStyleBackColor = true;
            this.search_dates.Click += new System.EventHandler(this.search_dates_Click_1);
            // 
            // Orders_list
            // 
            this.Orders_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderID,
            this.CustomerID,
            this.Status,
            this.TargetDate,
            this.CreateDate,
            this.Capacity,
            this.Price});
            this.Orders_list.HideSelection = false;
            this.Orders_list.Location = new System.Drawing.Point(23, 274);
            this.Orders_list.Name = "Orders_list";
            this.Orders_list.Size = new System.Drawing.Size(729, 164);
            this.Orders_list.TabIndex = 4;
            this.Orders_list.UseCompatibleStateImageBehavior = false;
            this.Orders_list.View = System.Windows.Forms.View.Details;
            this.Orders_list.SelectedIndexChanged += new System.EventHandler(this.Orders_list_SelectedIndexChanged);
            // 
            // OrderID
            // 
            this.OrderID.Text = "OrderID";
            // 
            // CustomerID
            // 
            this.CustomerID.Text = "CustomerID";
            // 
            // Status
            // 
            this.Status.Text = "Status";
            // 
            // TargetDate
            // 
            this.TargetDate.Text = "TargetDate";
            // 
            // CreateDate
            // 
            this.CreateDate.Text = "CreateDate";
            // 
            // Capacity
            // 
            this.Capacity.Text = "Capacity";
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // Recent_Order
            // 
            this.Recent_Order.AutoSize = true;
            this.Recent_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Recent_Order.Location = new System.Drawing.Point(259, 195);
            this.Recent_Order.Name = "Recent_Order";
            this.Recent_Order.Size = new System.Drawing.Size(185, 24);
            this.Recent_Order.TabIndex = 5;
            this.Recent_Order.Text = "Most recent orders";
            // 
            // Customerinsert
            // 
            this.Customerinsert.AutoSize = true;
            this.Customerinsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Customerinsert.Location = new System.Drawing.Point(70, 24);
            this.Customerinsert.Name = "Customerinsert";
            this.Customerinsert.Size = new System.Drawing.Size(321, 20);
            this.Customerinsert.TabIndex = 6;
            this.Customerinsert.Text = "Please insert Customer Id for the order";
            this.Customerinsert.Click += new System.EventHandler(this.Customerinsert_Click);
            // 
            // Id_Input
            // 
            this.Id_Input.Location = new System.Drawing.Point(423, 24);
            this.Id_Input.Name = "Id_Input";
            this.Id_Input.Size = new System.Drawing.Size(100, 20);
            this.Id_Input.TabIndex = 7;
            this.Id_Input.TextChanged += new System.EventHandler(this.Id_Input_TextChanged);
            // 
            // Submut
            // 
            this.Submut.Location = new System.Drawing.Point(552, 12);
            this.Submut.Name = "Submut";
            this.Submut.Size = new System.Drawing.Size(92, 48);
            this.Submut.TabIndex = 8;
            this.Submut.Text = "Submit";
            this.Submut.UseVisualStyleBackColor = true;
            this.Submut.Click += new System.EventHandler(this.Submut_Click);
            // 
            // OrderMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Submut);
            this.Controls.Add(this.Id_Input);
            this.Controls.Add(this.Customerinsert);
            this.Controls.Add(this.Recent_Order);
            this.Controls.Add(this.Orders_list);
            this.Controls.Add(this.search_dates);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.create_order);
            this.Name = "OrderMenu";
            this.Text = "OrderMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create_order;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button search_dates;
        private System.Windows.Forms.ListView Orders_list;
        private System.Windows.Forms.Label Recent_Order;
        private System.Windows.Forms.ColumnHeader OrderID;
        private System.Windows.Forms.ColumnHeader CustomerID;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader TargetDate;
        private System.Windows.Forms.ColumnHeader CreateDate;
        private System.Windows.Forms.ColumnHeader Capacity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Label Customerinsert;
        private System.Windows.Forms.TextBox Id_Input;
        private System.Windows.Forms.Button Submut;
    }
}