namespace KallkarProject
{
    partial class SearchOrder_ByDate
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
            this.Choose_target = new System.Windows.Forms.Label();
            this.OrderList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TargetDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreateDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Capacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Choose_target
            // 
            this.Choose_target.AutoSize = true;
            this.Choose_target.Font = new System.Drawing.Font("Levenim MT", 14F);
            this.Choose_target.Location = new System.Drawing.Point(196, 52);
            this.Choose_target.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Choose_target.Name = "Choose_target";
            this.Choose_target.Size = new System.Drawing.Size(494, 37);
            this.Choose_target.TabIndex = 0;
            this.Choose_target.Text = "Please choose specific target date";
            // 
            // OrderList
            // 
            this.OrderList.BackColor = System.Drawing.Color.PaleTurquoise;
            this.OrderList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.TargetDate,
            this.CreateDate,
            this.Status,
            this.Capacity,
            this.Weight});
            this.OrderList.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.OrderList.HideSelection = false;
            this.OrderList.Location = new System.Drawing.Point(70, 191);
            this.OrderList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrderList.Name = "OrderList";
            this.OrderList.Size = new System.Drawing.Size(743, 195);
            this.OrderList.TabIndex = 4;
            this.OrderList.UseCompatibleStateImageBehavior = false;
            this.OrderList.View = System.Windows.Forms.View.Details;
            this.OrderList.SelectedIndexChanged += new System.EventHandler(this.OrderList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order ID";
            this.columnHeader1.Width = 73;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Levenim MT", 12F);
            this.button1.Location = new System.Drawing.Point(611, 111);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(267, 117);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(308, 26);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back_button.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.back_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_button.Location = new System.Drawing.Point(21, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(82, 49);
            this.back_button.TabIndex = 7;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // SearchOrder_ByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(890, 470);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OrderList);
            this.Controls.Add(this.Choose_target);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SearchOrder_ByDate";
            this.Text = "SearchOrder_ByDate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Choose_target;
        private System.Windows.Forms.ListView OrderList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader TargetDate;
        private System.Windows.Forms.ColumnHeader CreateDate;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader Capacity;
        private System.Windows.Forms.ColumnHeader Weight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button back_button;
    }
}