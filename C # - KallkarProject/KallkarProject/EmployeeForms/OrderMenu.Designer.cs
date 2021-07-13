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
            this.label1 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // create_order
            // 
            this.create_order.BackColor = System.Drawing.Color.DarkTurquoise;
            this.create_order.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.create_order.Location = new System.Drawing.Point(1, 98);
            this.create_order.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.create_order.Name = "create_order";
            this.create_order.Size = new System.Drawing.Size(310, 41);
            this.create_order.TabIndex = 0;
            this.create_order.Text = "Create new order";
            this.create_order.UseVisualStyleBackColor = false;
            this.create_order.Click += new System.EventHandler(this.create_order_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.button1.Location = new System.Drawing.Point(316, 98);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search order by customer ID";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // search_dates
            // 
            this.search_dates.BackColor = System.Drawing.Color.DarkTurquoise;
            this.search_dates.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.search_dates.Location = new System.Drawing.Point(634, 98);
            this.search_dates.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search_dates.Name = "search_dates";
            this.search_dates.Size = new System.Drawing.Size(310, 41);
            this.search_dates.TabIndex = 3;
            this.search_dates.Text = "Search order by Date";
            this.search_dates.UseVisualStyleBackColor = false;
            this.search_dates.Click += new System.EventHandler(this.search_dates_Click_1);
            // 
            // Orders_list
            // 
            this.Orders_list.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Orders_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderID,
            this.CustomerID,
            this.Status,
            this.TargetDate,
            this.CreateDate,
            this.Capacity,
            this.Price});
            this.Orders_list.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.Orders_list.HideSelection = false;
            this.Orders_list.Location = new System.Drawing.Point(92, 289);
            this.Orders_list.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Orders_list.Name = "Orders_list";
            this.Orders_list.Size = new System.Drawing.Size(738, 250);
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
            this.Recent_Order.Font = new System.Drawing.Font("Levenim MT", 14F);
            this.Recent_Order.Location = new System.Drawing.Point(330, 247);
            this.Recent_Order.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Recent_Order.Name = "Recent_Order";
            this.Recent_Order.Size = new System.Drawing.Size(269, 37);
            this.Recent_Order.TabIndex = 5;
            this.Recent_Order.Text = "Most recent orders";
            // 
            // Customerinsert
            // 
            this.Customerinsert.AutoSize = true;
            this.Customerinsert.Font = new System.Drawing.Font("Levenim MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customerinsert.Location = new System.Drawing.Point(27, 175);
            this.Customerinsert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Customerinsert.Name = "Customerinsert";
            this.Customerinsert.Size = new System.Drawing.Size(463, 33);
            this.Customerinsert.TabIndex = 6;
            this.Customerinsert.Text = "Please insert Customer Id for the order";
            this.Customerinsert.Click += new System.EventHandler(this.Customerinsert_Click);
            // 
            // Id_Input
            // 
            this.Id_Input.Location = new System.Drawing.Point(515, 171);
            this.Id_Input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Id_Input.Name = "Id_Input";
            this.Id_Input.Size = new System.Drawing.Size(148, 26);
            this.Id_Input.TabIndex = 7;
            this.Id_Input.TextChanged += new System.EventHandler(this.Id_Input_TextChanged);
            // 
            // Submut
            // 
            this.Submut.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Submut.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.Submut.Location = new System.Drawing.Point(692, 171);
            this.Submut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Submut.Name = "Submut";
            this.Submut.Size = new System.Drawing.Size(138, 74);
            this.Submut.TabIndex = 8;
            this.Submut.Text = "Submit";
            this.Submut.UseVisualStyleBackColor = false;
            this.Submut.Click += new System.EventHandler(this.Submut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Levenim MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 65);
            this.label1.TabIndex = 9;
            this.label1.Text = "Orders Menu";
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back_button.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.back_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_button.Location = new System.Drawing.Point(12, 0);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(86, 44);
            this.back_button.TabIndex = 10;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // OrderMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(964, 565);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Submut);
            this.Controls.Add(this.Id_Input);
            this.Controls.Add(this.Customerinsert);
            this.Controls.Add(this.Recent_Order);
            this.Controls.Add(this.Orders_list);
            this.Controls.Add(this.search_dates);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.create_order);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderMenu";
            this.Text = "OrderMenu";
            this.Load += new System.EventHandler(this.OrderMenu_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_button;
    }
}