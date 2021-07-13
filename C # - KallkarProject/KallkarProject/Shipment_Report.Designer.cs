namespace KallkarProject
{
    partial class Shipment_Report
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
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sADM_4DataSet = new KallkarProject.SADM_4DataSet();
            this.orderTableAdapter = new KallkarProject.SADM_4DataSetTableAdapters.OrderTableAdapter();
            this.truckBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Nubmer_Of_Drivers = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areaTableAdapter = new KallkarProject.SADM_4DataSetTableAdapters.areaTableAdapter();
            this.truckTableAdapter = new KallkarProject.SADM_4DataSetTableAdapters.TruckTableAdapter();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Order_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TargetDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Capacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Destenation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Shipment1Text = new System.Windows.Forms.Label();
            this.Shipment2Text = new System.Windows.Forms.Label();
            this.Shipment3Text = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Shipment5Text = new System.Windows.Forms.Label();
            this.Shipment1 = new System.Windows.Forms.ListView();
            this.OrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TruckID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView4 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView5 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView6 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumOfDrivers = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Waze = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sADM_4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.sADM_4DataSet;
            // 
            // sADM_4DataSet
            // 
            this.sADM_4DataSet.DataSetName = "SADM_4DataSet";
            this.sADM_4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // truckBindingSource
            // 
            this.truckBindingSource.DataMember = "Truck";
            this.truckBindingSource.DataSource = this.sADM_4DataSet;
            // 
            // Nubmer_Of_Drivers
            // 
            this.Nubmer_Of_Drivers.AutoSize = true;
            this.Nubmer_Of_Drivers.Location = new System.Drawing.Point(12, 44);
            this.Nubmer_Of_Drivers.Name = "Nubmer_Of_Drivers";
            this.Nubmer_Of_Drivers.Size = new System.Drawing.Size(139, 20);
            this.Nubmer_Of_Drivers.TabIndex = 3;
            this.Nubmer_Of_Drivers.Text = "Nubmer Of Drivers";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(173, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 26);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date Of Shipment";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Match delivery to truck";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataMember = "area";
            this.areaBindingSource.DataSource = this.sADM_4DataSet;
            // 
            // areaTableAdapter
            // 
            this.areaTableAdapter.ClearBeforeFill = true;
            // 
            // truckTableAdapter
            // 
            this.truckTableAdapter.ClearBeforeFill = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Order_Id,
            this.OrderDate,
            this.TargetDate,
            this.Capacity,
            this.Weight,
            this.Destenation});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(432, 44);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(711, 199);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Order_Id
            // 
            this.Order_Id.Text = "Order Id";
            this.Order_Id.Width = 114;
            // 
            // OrderDate
            // 
            this.OrderDate.Text = "OrderDate";
            this.OrderDate.Width = 123;
            // 
            // TargetDate
            // 
            this.TargetDate.Text = "TargetDate";
            this.TargetDate.Width = 131;
            // 
            // Capacity
            // 
            this.Capacity.DisplayIndex = 4;
            this.Capacity.Text = "Capacity";
            this.Capacity.Width = 82;
            // 
            // Weight
            // 
            this.Weight.DisplayIndex = 5;
            this.Weight.Text = "Weight";
            this.Weight.Width = 100;
            // 
            // Destenation
            // 
            this.Destenation.DisplayIndex = 3;
            this.Destenation.Text = "Destenation";
            this.Destenation.Width = 151;
            // 
            // Shipment1Text
            // 
            this.Shipment1Text.AutoSize = true;
            this.Shipment1Text.Location = new System.Drawing.Point(1053, 297);
            this.Shipment1Text.Name = "Shipment1Text";
            this.Shipment1Text.Size = new System.Drawing.Size(90, 20);
            this.Shipment1Text.TabIndex = 8;
            this.Shipment1Text.Text = "Shipment 1";
            this.Shipment1Text.Click += new System.EventHandler(this.Shipment1Text_Click);
            // 
            // Shipment2Text
            // 
            this.Shipment2Text.AutoSize = true;
            this.Shipment2Text.Location = new System.Drawing.Point(917, 297);
            this.Shipment2Text.Name = "Shipment2Text";
            this.Shipment2Text.Size = new System.Drawing.Size(90, 20);
            this.Shipment2Text.TabIndex = 9;
            this.Shipment2Text.Text = "Shipment 2";
            this.Shipment2Text.Click += new System.EventHandler(this.Shipment2Text_Click);
            // 
            // Shipment3Text
            // 
            this.Shipment3Text.AutoSize = true;
            this.Shipment3Text.Location = new System.Drawing.Point(694, 297);
            this.Shipment3Text.Name = "Shipment3Text";
            this.Shipment3Text.Size = new System.Drawing.Size(90, 20);
            this.Shipment3Text.TabIndex = 10;
            this.Shipment3Text.Text = "Shipment 3";
            this.Shipment3Text.Click += new System.EventHandler(this.Shipment3Text_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Shipment 4";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Shipment5Text
            // 
            this.Shipment5Text.AutoSize = true;
            this.Shipment5Text.Location = new System.Drawing.Point(283, 297);
            this.Shipment5Text.Name = "Shipment5Text";
            this.Shipment5Text.Size = new System.Drawing.Size(90, 20);
            this.Shipment5Text.TabIndex = 12;
            this.Shipment5Text.Text = "Shipment 5";
            this.Shipment5Text.Click += new System.EventHandler(this.Shipment5Text_Click);
            // 
            // Shipment1
            // 
            this.Shipment1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderID,
            this.TruckID});
            this.Shipment1.HideSelection = false;
            this.Shipment1.Location = new System.Drawing.Point(827, 320);
            this.Shipment1.Name = "Shipment1";
            this.Shipment1.Size = new System.Drawing.Size(193, 198);
            this.Shipment1.TabIndex = 13;
            this.Shipment1.UseCompatibleStateImageBehavior = false;
            this.Shipment1.View = System.Windows.Forms.View.Details;
            this.Shipment1.SelectedIndexChanged += new System.EventHandler(this.Shipment1_SelectedIndexChanged);
            // 
            // OrderID
            // 
            this.OrderID.Text = "Order- ID ";
            this.OrderID.Width = 115;
            // 
            // TruckID
            // 
            this.TruckID.Text = "TruckID";
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5});
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(628, 320);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(193, 198);
            this.listView3.TabIndex = 14;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            this.listView3.SelectedIndexChanged += new System.EventHandler(this.listView3_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order- ID ";
            this.columnHeader1.Width = 138;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "TruckID";
            // 
            // listView4
            // 
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader6});
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(1026, 320);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(193, 198);
            this.listView4.TabIndex = 15;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            this.listView4.SelectedIndexChanged += new System.EventHandler(this.listView4_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Order- ID ";
            this.columnHeader2.Width = 115;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "TruckID";
            // 
            // listView5
            // 
            this.listView5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.listView5.HideSelection = false;
            this.listView5.Location = new System.Drawing.Point(429, 320);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(193, 198);
            this.listView5.TabIndex = 16;
            this.listView5.UseCompatibleStateImageBehavior = false;
            this.listView5.View = System.Windows.Forms.View.Details;
            this.listView5.SelectedIndexChanged += new System.EventHandler(this.listView5_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Order- ID ";
            this.columnHeader3.Width = 115;
            // 
            // listView6
            // 
            this.listView6.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.listView6.HideSelection = false;
            this.listView6.Location = new System.Drawing.Point(230, 320);
            this.listView6.Name = "listView6";
            this.listView6.Size = new System.Drawing.Size(193, 198);
            this.listView6.TabIndex = 17;
            this.listView6.UseCompatibleStateImageBehavior = false;
            this.listView6.View = System.Windows.Forms.View.Details;
            this.listView6.SelectedIndexChanged += new System.EventHandler(this.listView6_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Order- ID ";
            this.columnHeader4.Width = 115;
            // 
            // NumOfDrivers
            // 
            this.NumOfDrivers.Location = new System.Drawing.Point(173, 44);
            this.NumOfDrivers.Name = "NumOfDrivers";
            this.NumOfDrivers.Size = new System.Drawing.Size(172, 26);
            this.NumOfDrivers.TabIndex = 18;
            this.NumOfDrivers.TextChanged += new System.EventHandler(this.NumOfDrivers_TextChanged);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(22, 447);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(175, 62);
            this.Exit.TabIndex = 19;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Waze
            // 
            this.Waze.Location = new System.Drawing.Point(127, 212);
            this.Waze.Name = "Waze";
            this.Waze.Size = new System.Drawing.Size(85, 31);
            this.Waze.TabIndex = 20;
            this.Waze.Text = "Waze";
            this.Waze.UseVisualStyleBackColor = true;
            this.Waze.Click += new System.EventHandler(this.Waze_Click);
            // 
            // Shipment_Report
            // 
            this.ClientSize = new System.Drawing.Size(1316, 592);
            this.Controls.Add(this.Waze);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.NumOfDrivers);
            this.Controls.Add(this.listView6);
            this.Controls.Add(this.listView5);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.Shipment1);
            this.Controls.Add(this.Shipment5Text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Shipment3Text);
            this.Controls.Add(this.Shipment2Text);
            this.Controls.Add(this.Shipment1Text);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Nubmer_Of_Drivers);
            this.Name = "Shipment_Report";
            this.Text = "Shipment Report";
            this.Load += new System.EventHandler(this.Shipment_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sADM_4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SADM_4DataSet sADM_4DataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private SADM_4DataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.Label Nubmer_Of_Drivers;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private SADM_4DataSetTableAdapters.areaTableAdapter areaTableAdapter;
        private System.Windows.Forms.BindingSource truckBindingSource;
        private SADM_4DataSetTableAdapters.TruckTableAdapter truckTableAdapter;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Order_Id;
        private System.Windows.Forms.ColumnHeader OrderDate;
        private System.Windows.Forms.ColumnHeader TargetDate;
        private System.Windows.Forms.ColumnHeader Capacity;
        private System.Windows.Forms.ColumnHeader Weight;
        private System.Windows.Forms.ColumnHeader Destenation;
        private System.Windows.Forms.Label Shipment1Text;
        private System.Windows.Forms.Label Shipment2Text;
        private System.Windows.Forms.Label Shipment3Text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Shipment5Text;
        private System.Windows.Forms.ListView Shipment1;
        private System.Windows.Forms.ColumnHeader OrderID;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listView5;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listView6;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox NumOfDrivers;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ColumnHeader TruckID;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button Waze;
    }
}


