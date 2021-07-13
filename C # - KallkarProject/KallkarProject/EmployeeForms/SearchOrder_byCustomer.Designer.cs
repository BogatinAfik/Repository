namespace KallkarProject
{
    partial class SearchOrder_byCustomer
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
            this.Customer_ID = new System.Windows.Forms.Label();
            this.ID_Input = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.OrderList = new System.Windows.Forms.ListView();
            this.OrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TargetDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreateDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Capacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Customer_ID
            // 
            this.Customer_ID.AutoSize = true;
            this.Customer_ID.Font = new System.Drawing.Font("Levenim MT", 12F);
            this.Customer_ID.Location = new System.Drawing.Point(89, 82);
            this.Customer_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Customer_ID.Name = "Customer_ID";
            this.Customer_ID.Size = new System.Drawing.Size(312, 32);
            this.Customer_ID.TabIndex = 0;
            this.Customer_ID.Text = "Please insert Customer ID";
            // 
            // ID_Input
            // 
            this.ID_Input.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.ID_Input.Location = new System.Drawing.Point(436, 88);
            this.ID_Input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ID_Input.Name = "ID_Input";
            this.ID_Input.Size = new System.Drawing.Size(190, 30);
            this.ID_Input.TabIndex = 1;
            this.ID_Input.TextChanged += new System.EventHandler(this.ID_Input_TextChanged);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Search.Font = new System.Drawing.Font("Levenim MT", 12F);
            this.Search.Location = new System.Drawing.Point(682, 72);
            this.Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(212, 52);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // OrderList
            // 
            this.OrderList.BackColor = System.Drawing.Color.PaleTurquoise;
            this.OrderList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderID,
            this.TargetDate,
            this.CreateDate,
            this.Status,
            this.Capacity,
            this.Weight});
            this.OrderList.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.OrderList.HideSelection = false;
            this.OrderList.Location = new System.Drawing.Point(33, 158);
            this.OrderList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrderList.Name = "OrderList";
            this.OrderList.Size = new System.Drawing.Size(918, 270);
            this.OrderList.TabIndex = 3;
            this.OrderList.UseCompatibleStateImageBehavior = false;
            this.OrderList.View = System.Windows.Forms.View.Details;
            // 
            // OrderID
            // 
            this.OrderID.Text = "Order ID";
            this.OrderID.Width = 73;
            // 
            // TargetDate
            // 
            this.TargetDate.Text = "Target Date";
            this.TargetDate.Width = 105;
            // 
            // CreateDate
            // 
            this.CreateDate.Text = "CreateDate";
            this.CreateDate.Width = 110;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 106;
            // 
            // Capacity
            // 
            this.Capacity.Text = "Capacity";
            this.Capacity.Width = 80;
            // 
            // Weight
            // 
            this.Weight.Text = "Weight";
            this.Weight.Width = 72;
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exit_button.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.exit_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit_button.Location = new System.Drawing.Point(12, 12);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(96, 34);
            this.exit_button.TabIndex = 4;
            this.exit_button.Text = "back";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // SearchOrder_byCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(978, 504);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.OrderList);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.ID_Input);
            this.Controls.Add(this.Customer_ID);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SearchOrder_byCustomer";
            this.Text = "SearchOrder_byCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Customer_ID;
        private System.Windows.Forms.TextBox ID_Input;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ListView OrderList;
        private System.Windows.Forms.ColumnHeader OrderID;
        private System.Windows.Forms.ColumnHeader TargetDate;
        private System.Windows.Forms.ColumnHeader CreateDate;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader Capacity;
        private System.Windows.Forms.ColumnHeader Weight;
        private System.Windows.Forms.Button exit_button;
    }
}