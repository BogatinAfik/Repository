namespace KallkarProject
{
    partial class customersForm
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
            this.newCustomer = new System.Windows.Forms.Button();
            this.existCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.home_page = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newCustomer
            // 
            this.newCustomer.BackColor = System.Drawing.Color.Turquoise;
            this.newCustomer.Font = new System.Drawing.Font("Levenim MT", 16F);
            this.newCustomer.ForeColor = System.Drawing.SystemColors.InfoText;
            this.newCustomer.Location = new System.Drawing.Point(229, 356);
            this.newCustomer.Name = "newCustomer";
            this.newCustomer.Size = new System.Drawing.Size(319, 70);
            this.newCustomer.TabIndex = 0;
            this.newCustomer.Text = "New Customer";
            this.newCustomer.UseVisualStyleBackColor = false;
            this.newCustomer.Click += new System.EventHandler(this.newCustomer_Click);
            // 
            // existCustomer
            // 
            this.existCustomer.BackColor = System.Drawing.Color.PaleTurquoise;
            this.existCustomer.Font = new System.Drawing.Font("Levenim MT", 16F);
            this.existCustomer.Location = new System.Drawing.Point(229, 262);
            this.existCustomer.Name = "existCustomer";
            this.existCustomer.Size = new System.Drawing.Size(319, 70);
            this.existCustomer.TabIndex = 1;
            this.existCustomer.Text = "Existing Customer";
            this.existCustomer.UseVisualStyleBackColor = false;
            this.existCustomer.Click += new System.EventHandler(this.existCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Levenim MT", 20F);
            this.label1.Location = new System.Drawing.Point(128, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "Glad to give you service";
            // 
            // home_page
            // 
            this.home_page.BackColor = System.Drawing.Color.Black;
            this.home_page.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.home_page.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.home_page.Location = new System.Drawing.Point(12, 12);
            this.home_page.Name = "home_page";
            this.home_page.Size = new System.Drawing.Size(119, 39);
            this.home_page.TabIndex = 3;
            this.home_page.Text = "home page";
            this.home_page.UseVisualStyleBackColor = false;
            this.home_page.Click += new System.EventHandler(this.home_page_Click);
            // 
            // customersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(753, 482);
            this.Controls.Add(this.home_page);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.existCustomer);
            this.Controls.Add(this.newCustomer);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "customersForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newCustomer;
        private System.Windows.Forms.Button existCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button home_page;
    }
}

