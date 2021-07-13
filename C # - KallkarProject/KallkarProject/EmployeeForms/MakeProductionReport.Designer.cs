namespace KallkarProject
{
    partial class MakeProductionReport
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
            this.Submit = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.send_email = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.back_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Submit.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.Submit.Location = new System.Drawing.Point(553, 76);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(129, 49);
            this.Submit.TabIndex = 1;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(364, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 29);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.richTextBox1.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.richTextBox1.Location = new System.Drawing.Point(12, 159);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(763, 244);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // send_email
            // 
            this.send_email.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.send_email.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.send_email.Location = new System.Drawing.Point(285, 421);
            this.send_email.Name = "send_email";
            this.send_email.Size = new System.Drawing.Size(238, 39);
            this.send_email.TabIndex = 5;
            this.send_email.Text = "send to my mail";
            this.send_email.UseVisualStyleBackColor = false;
            this.send_email.Click += new System.EventHandler(this.send_email_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.label2.Location = new System.Drawing.Point(29, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "choose number of days to produce";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Levenim MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 49);
            this.label3.TabIndex = 8;
            this.label3.Text = "Production Report";
            // 
            // back_button1
            // 
            this.back_button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back_button1.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.back_button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_button1.Location = new System.Drawing.Point(12, 12);
            this.back_button1.Name = "back_button1";
            this.back_button1.Size = new System.Drawing.Size(80, 37);
            this.back_button1.TabIndex = 9;
            this.back_button1.Text = "back";
            this.back_button1.UseVisualStyleBackColor = false;
            this.back_button1.Click += new System.EventHandler(this.back_button1_Click);
            // 
            // MakeProductionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(815, 472);
            this.Controls.Add(this.back_button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.send_email);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Submit);
            this.Name = "MakeProductionReport";
            this.Text = "MakeProductionReport";
            this.Load += new System.EventHandler(this.MakeProductionReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button send_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button back_button1;
    }
}