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
            this.SuspendLayout();
            // 
            // Comments_input
            // 
            this.Comments_input.Location = new System.Drawing.Point(137, 99);
            this.Comments_input.Name = "Comments_input";
            this.Comments_input.Size = new System.Drawing.Size(351, 207);
            this.Comments_input.TabIndex = 0;
            this.Comments_input.Text = "";
            // 
            // Comments
            // 
            this.Comments.AutoSize = true;
            this.Comments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Comments.Location = new System.Drawing.Point(134, 42);
            this.Comments.Name = "Comments";
            this.Comments.Size = new System.Drawing.Size(386, 16);
            this.Comments.TabIndex = 1;
            this.Comments.Text = "Please explain what do you want to change in the order";
            this.Comments.Click += new System.EventHandler(this.Comments_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(96, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = " please note that the factory will look at the changes and approved it";
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Submit.Location = new System.Drawing.Point(521, 146);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(228, 115);
            this.Submit.TabIndex = 3;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Update_My_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Comments);
            this.Controls.Add(this.Comments_input);
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
    }
}