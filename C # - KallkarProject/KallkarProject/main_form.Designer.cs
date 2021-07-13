namespace KallkarProject
{
    partial class main_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.worker_button = new System.Windows.Forms.Button();
            this.customer_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aboutus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Levenim MT", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(803, 109);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Kalkar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // worker_button
            // 
            this.worker_button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.worker_button.Font = new System.Drawing.Font("Levenim MT", 12F);
            this.worker_button.Location = new System.Drawing.Point(679, 150);
            this.worker_button.Name = "worker_button";
            this.worker_button.Size = new System.Drawing.Size(360, 49);
            this.worker_button.TabIndex = 1;
            this.worker_button.Text = "Employee";
            this.worker_button.UseVisualStyleBackColor = false;
            this.worker_button.Click += new System.EventHandler(this.worker_button_Click);
            // 
            // customer_button
            // 
            this.customer_button.BackColor = System.Drawing.Color.DarkTurquoise;
            this.customer_button.Font = new System.Drawing.Font("Levenim MT", 12F);
            this.customer_button.Location = new System.Drawing.Point(351, 150);
            this.customer_button.Name = "customer_button";
            this.customer_button.Size = new System.Drawing.Size(336, 49);
            this.customer_button.TabIndex = 2;
            this.customer_button.Text = "Customer";
            this.customer_button.UseVisualStyleBackColor = false;
            this.customer_button.Click += new System.EventHandler(this.customer_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Levenim MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(355, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "Polystyrene products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Levenim MT", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(522, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(500, 71);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quality is our base";
            // 
            // aboutus
            // 
            this.aboutus.BackColor = System.Drawing.Color.Turquoise;
            this.aboutus.Font = new System.Drawing.Font("Levenim MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.aboutus.Location = new System.Drawing.Point(-3, 150);
            this.aboutus.Name = "aboutus";
            this.aboutus.Size = new System.Drawing.Size(358, 49);
            this.aboutus.TabIndex = 4;
            this.aboutus.Text = "About Us";
            this.aboutus.UseVisualStyleBackColor = false;
            this.aboutus.Click += new System.EventHandler(this.aboutus_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::KallkarProject.Properties.Resources.WhatsApp_Image_2020_06_24_at_12_49_37;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 579);
            this.Controls.Add(this.aboutus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customer_button);
            this.Controls.Add(this.worker_button);
            this.Controls.Add(this.label1);
            this.Name = "main_form";
            this.Text = "main_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button worker_button;
        private System.Windows.Forms.Button customer_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button aboutus;
    }
}