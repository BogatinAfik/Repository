namespace KallkarProject
{
    partial class MyOrders_ForUpdate
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
            this.OrderDetails = new System.Windows.Forms.ListView();
            this.Order_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Target_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.Order_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.ProductInOrder = new System.Windows.Forms.ListView();
            this.OrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Capacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product_inOrder = new System.Windows.Forms.Label();
            this.Update_Order = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrderDetails
            // 
            this.OrderDetails.BackColor = System.Drawing.Color.PaleTurquoise;
            this.OrderDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Order_ID,
            this.Target_Date,
            this.Status});
            this.OrderDetails.HideSelection = false;
            this.OrderDetails.Location = new System.Drawing.Point(29, 59);
            this.OrderDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrderDetails.Name = "OrderDetails";
            this.OrderDetails.Size = new System.Drawing.Size(864, 195);
            this.OrderDetails.TabIndex = 0;
            this.OrderDetails.UseCompatibleStateImageBehavior = false;
            this.OrderDetails.View = System.Windows.Forms.View.Details;
            // 
            // Order_ID
            // 
            this.Order_ID.Text = "Order ID";
            this.Order_ID.Width = 288;
            // 
            // Target_Date
            // 
            this.Target_Date.Text = "Target Date";
            this.Target_Date.Width = 249;
            // 
            // Status
            // 
            this.Status.Text = "Orde status";
            this.Status.Width = 234;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Levenim MT", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(271, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Update My Orders";
            // 
            // Order_input
            // 
            this.Order_input.Location = new System.Drawing.Point(414, 270);
            this.Order_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Order_input.Name = "Order_input";
            this.Order_input.Size = new System.Drawing.Size(148, 26);
            this.Order_input.TabIndex = 2;
            this.Order_input.TextChanged += new System.EventHandler(this.Order_input_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 274);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Order Id to see full details";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Search.Location = new System.Drawing.Point(590, 266);
            this.Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(112, 35);
            this.Search.TabIndex = 4;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // ProductInOrder
            // 
            this.ProductInOrder.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ProductInOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderID,
            this.ProductID,
            this.Product_Name,
            this.Weight,
            this.Capacity,
            this.Price,
            this.Category,
            this.Quantity});
            this.ProductInOrder.HideSelection = false;
            this.ProductInOrder.Location = new System.Drawing.Point(29, 345);
            this.ProductInOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductInOrder.Name = "ProductInOrder";
            this.ProductInOrder.Size = new System.Drawing.Size(854, 179);
            this.ProductInOrder.TabIndex = 5;
            this.ProductInOrder.UseCompatibleStateImageBehavior = false;
            this.ProductInOrder.View = System.Windows.Forms.View.Details;
            this.ProductInOrder.SelectedIndexChanged += new System.EventHandler(this.ProductInOrder_SelectedIndexChanged);
            // 
            // OrderID
            // 
            this.OrderID.Text = "OrderID";
            this.OrderID.Width = 86;
            // 
            // ProductID
            // 
            this.ProductID.Text = "ProductID";
            this.ProductID.Width = 100;
            // 
            // Product_Name
            // 
            this.Product_Name.Text = "Product name";
            this.Product_Name.Width = 121;
            // 
            // Weight
            // 
            this.Weight.Text = "Weight";
            this.Weight.Width = 109;
            // 
            // Capacity
            // 
            this.Capacity.Text = "Capacity";
            this.Capacity.Width = 104;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 74;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 97;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 77;
            // 
            // Product_inOrder
            // 
            this.Product_inOrder.AutoSize = true;
            this.Product_inOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Product_inOrder.Location = new System.Drawing.Point(34, 315);
            this.Product_inOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Product_inOrder.Name = "Product_inOrder";
            this.Product_inOrder.Size = new System.Drawing.Size(171, 25);
            this.Product_inOrder.TabIndex = 6;
            this.Product_inOrder.Text = "Product In Order";
            this.Product_inOrder.Click += new System.EventHandler(this.Product_inOrder_Click);
            // 
            // Update_Order
            // 
            this.Update_Order.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Update_Order.Font = new System.Drawing.Font("Levenim MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Order.Location = new System.Drawing.Point(362, 534);
            this.Update_Order.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Update_Order.Name = "Update_Order";
            this.Update_Order.Size = new System.Drawing.Size(186, 35);
            this.Update_Order.TabIndex = 7;
            this.Update_Order.Text = "Update Order";
            this.Update_Order.UseVisualStyleBackColor = false;
            this.Update_Order.Click += new System.EventHandler(this.Update_Order_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Black;
            this.exit.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit.Location = new System.Drawing.Point(18, 18);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(84, 31);
            this.exit.TabIndex = 8;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // MyOrders_ForUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 586);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Update_Order);
            this.Controls.Add(this.Product_inOrder);
            this.Controls.Add(this.ProductInOrder);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Order_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderDetails);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MyOrders_ForUpdate";
            this.Text = "MyOrders_ForUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView OrderDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Order_ID;
        private System.Windows.Forms.ColumnHeader Target_Date;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.TextBox Order_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ListView ProductInOrder;
        private System.Windows.Forms.ColumnHeader OrderID;
        private System.Windows.Forms.ColumnHeader Product_Name;
        private System.Windows.Forms.Label Product_inOrder;
        private System.Windows.Forms.ColumnHeader Weight;
        private System.Windows.Forms.ColumnHeader Capacity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader ProductID;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.Button Update_Order;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.Button exit;
    }
}