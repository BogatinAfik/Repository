namespace KallkarProject
{
    partial class InformationNotValid
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
            this.Information_is_not_Valid = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Information_is_not_Valid
            // 
            this.Information_is_not_Valid.AutoSize = true;
            this.Information_is_not_Valid.Font = new System.Drawing.Font("Levenim MT", 20F);
            this.Information_is_not_Valid.Location = new System.Drawing.Point(118, 84);
            this.Information_is_not_Valid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Information_is_not_Valid.Name = "Information_is_not_Valid";
            this.Information_is_not_Valid.Size = new System.Drawing.Size(479, 53);
            this.Information_is_not_Valid.TabIndex = 0;
            this.Information_is_not_Valid.Text = "Information is not Valid!";
            this.Information_is_not_Valid.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.Font = new System.Drawing.Font("Levenim MT", 16F);
            this.button1.Location = new System.Drawing.Point(238, 178);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 103);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Close_Click);
            // 
            // InformationNotValid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 407);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Information_is_not_Valid);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InformationNotValid";
            this.Text = "InformationNotValid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Information_is_not_Valid;
        private System.Windows.Forms.Button button1;
    }
}