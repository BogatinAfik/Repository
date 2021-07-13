namespace KallkarProject
{
    partial class Update_My_Orders
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
            this.Comments_input = new System.Windows.Forms.RichTextBox();
            this.Comments = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Comments_input
            // 
            this.Comments_input.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Comments_input.Location = new System.Drawing.Point(102, 92);
            this.Comments_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Comments_input.Name = "Comments_input";
            this.Comments_input.Size = new System.Drawing.Size(670, 221);
            this.Comments_input.TabIndex = 0;
            this.Comments_input.Text = "";
            // 
            // Comments
            // 
            this.Comments.AutoSize = true;
            this.Comments.Font = new System.Drawing.Font("Levenim MT", 12F);
            this.Comments.Location = new System.Drawing.Point(96, 55);
            this.Comments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Comments.Name = "Comments";
            this.Comments.Size = new System.Drawing.Size(689, 32);
            this.Comments.TabIndex = 1;
            this.Comments.Text = "Please explain what do you want to change in the order";
            this.Comments.Click += new System.EventHandler(this.Comments_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.label1.Location = new System.Drawing.Point(124, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = " please note that the factory will look at the changes and contact with you";
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Levenim MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(370, 355);
            this.Submit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(175, 62);
            this.Submit.TabIndex = 3;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Black;
            this.back_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_button.Location = new System.Drawing.Point(12, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(91, 41);
            this.back_button.TabIndex = 4;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Update_My_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Comments);
            this.Controls.Add(this.Comments_input);
            this.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Update_My_Orders";
            this.Text = "Update_My_Orders";
            this.Load += new System.EventHandler(this.Update_My_Orders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Comments_input;
        private System.Windows.Forms.Label Comments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button back_button;
    }
}