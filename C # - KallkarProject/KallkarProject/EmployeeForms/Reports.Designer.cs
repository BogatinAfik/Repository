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
            this.label1 = new System.Windows.Forms.Label();
            this.back_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Generate_Shipment_Report
            // 
            this.Generate_Shipment_Report.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Generate_Shipment_Report.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.Generate_Shipment_Report.Location = new System.Drawing.Point(27, 221);
            this.Generate_Shipment_Report.Name = "Generate_Shipment_Report";
            this.Generate_Shipment_Report.Size = new System.Drawing.Size(320, 45);
            this.Generate_Shipment_Report.TabIndex = 0;
            this.Generate_Shipment_Report.Text = "Generate Shipment Report";
            this.Generate_Shipment_Report.UseVisualStyleBackColor = false;
            this.Generate_Shipment_Report.Click += new System.EventHandler(this.Generate_Shipment_Report_Click);
            // 
            // Generate_Production_Report
            // 
            this.Generate_Production_Report.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Generate_Production_Report.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.Generate_Production_Report.Location = new System.Drawing.Point(438, 221);
            this.Generate_Production_Report.Name = "Generate_Production_Report";
            this.Generate_Production_Report.Size = new System.Drawing.Size(320, 45);
            this.Generate_Production_Report.TabIndex = 1;
            this.Generate_Production_Report.Text = "Generate Production Report";
            this.Generate_Production_Report.UseVisualStyleBackColor = false;
            this.Generate_Production_Report.Click += new System.EventHandler(this.Generate_Production_Report_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Levenim MT", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reports";
            // 
            // back_button1
            // 
            this.back_button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back_button1.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.back_button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_button1.Location = new System.Drawing.Point(12, 12);
            this.back_button1.Name = "back_button1";
            this.back_button1.Size = new System.Drawing.Size(86, 36);
            this.back_button1.TabIndex = 3;
            this.back_button1.Text = "back";
            this.back_button1.UseVisualStyleBackColor = false;
            this.back_button1.Click += new System.EventHandler(this.back_button1_Click);
            // 
            // Reports
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::KallkarProject.Properties.Resources.WhatsApp_Image_2020_06_24_at_12_49_37;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Generate_Production_Report);
            this.Controls.Add(this.Generate_Shipment_Report);
            this.Name = "Reports";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generate_Shipment_Report;
        private System.Windows.Forms.Button Generate_Production_Report;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_button1;
    }
}
