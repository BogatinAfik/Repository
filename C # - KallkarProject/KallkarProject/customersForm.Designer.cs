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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newCustomer
            // 
            this.newCustomer.BackColor = System.Drawing.Color.DarkTurquoise;
            this.newCustomer.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCustomer.ForeColor = System.Drawing.SystemColors.InfoText;
            this.newCustomer.Location = new System.Drawing.Point(651, 232);
            this.newCustomer.Name = "newCustomer";
            this.newCustomer.Size = new System.Drawing.Size(292, 219);
            this.newCustomer.TabIndex = 0;
            this.newCustomer.Text = "New Customer";
            this.newCustomer.UseVisualStyleBackColor = false;
            this.newCustomer.Click += new System.EventHandler(this.newCustomer_Click);
            // 
            // existCustomer
            // 
            this.existCustomer.BackColor = System.Drawing.Color.DodgerBlue;
            this.existCustomer.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existCustomer.Location = new System.Drawing.Point(225, 232);
            this.existCustomer.Name = "existCustomer";
            this.existCustomer.Size = new System.Drawing.Size(273, 219);
            this.existCustomer.TabIndex = 1;
            this.existCustomer.Text = "Existing Customer";
            this.existCustomer.UseVisualStyleBackColor = false;
            this.existCustomer.Click += new System.EventHandler(this.existCustomer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(745, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 93);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // customersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.existCustomer);
            this.Controls.Add(this.newCustomer);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "customersForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newCustomer;
        private System.Windows.Forms.Button existCustomer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

