namespace KallkarProject
{
    partial class Reports
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
            this.Generate_Shipment_Report = new System.Windows.Forms.Button();
            this.Generate_Production_Report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Generate_Shipment_Report
            // 
            this.Generate_Shipment_Report.Location = new System.Drawing.Point(27, 111);
            this.Generate_Shipment_Report.Name = "Generate_Shipment_Report";
            this.Generate_Shipment_Report.Size = new System.Drawing.Size(320, 181);
            this.Generate_Shipment_Report.TabIndex = 0;
            this.Generate_Shipment_Report.Text = "Generate Shipment Report";
            this.Generate_Shipment_Report.UseVisualStyleBackColor = true;
            this.Generate_Shipment_Report.Click += new System.EventHandler(this.Generate_Shipment_Report_Click);
            // 
            // Generate_Production_Report
            // 
            this.Generate_Production_Report.Location = new System.Drawing.Point(432, 111);
            this.Generate_Production_Report.Name = "Generate_Production_Report";
            this.Generate_Production_Report.Size = new System.Drawing.Size(320, 181);
            this.Generate_Production_Report.TabIndex = 1;
            this.Generate_Production_Report.Text = "Generate Production Report";
            this.Generate_Production_Report.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Generate_Production_Report);
            this.Controls.Add(this.Generate_Shipment_Report);
            this.Name = "Reports";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Generate_Shipment_Report;
        private System.Windows.Forms.Button Generate_Production_Report;
    }
}
