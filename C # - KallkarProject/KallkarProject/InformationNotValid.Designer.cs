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
            this.Information_is_not_Valid.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Information_is_not_Valid.Location = new System.Drawing.Point(131, 83);
            this.Information_is_not_Valid.Name = "Information_is_not_Valid";
            this.Information_is_not_Valid.Size = new System.Drawing.Size(548, 55);
            this.Information_is_not_Valid.TabIndex = 0;
            this.Information_is_not_Valid.Text = "Information is not Valid!";
            this.Information_is_not_Valid.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(250, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 108);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Close_Click);
            // 
            // InformationNotValid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Information_is_not_Valid);
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