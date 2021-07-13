namespace KallkarProject
{
    partial class view_orders
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Submit = new System.Windows.Forms.Button();
            this.insertOrderNum = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.richTextBox1.Font = new System.Drawing.Font("Levenim MT", 12F);
            this.richTextBox1.Location = new System.Drawing.Point(12, 70);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(760, 260);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Submit.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.Submit.Location = new System.Drawing.Point(514, 361);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(113, 44);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // insertOrderNum
            // 
            this.insertOrderNum.AutoSize = true;
            this.insertOrderNum.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.insertOrderNum.Location = new System.Drawing.Point(24, 369);
            this.insertOrderNum.Name = "insertOrderNum";
            this.insertOrderNum.Size = new System.Drawing.Size(246, 27);
            this.insertOrderNum.TabIndex = 3;
            this.insertOrderNum.Text = "insert an Order number:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.textBox1.Location = new System.Drawing.Point(292, 366);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 30);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Black;
            this.Back.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Back.Location = new System.Drawing.Point(12, 9);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(79, 32);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Levenim MT", 20F);
            this.label1.Location = new System.Drawing.Point(268, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 53);
            this.label1.TabIndex = 6;
            this.label1.Text = "My Orders";
            // 
            // view_orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.insertOrderNum);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.richTextBox1);
            this.Name = "view_orders";
            this.Text = "view_orders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label insertOrderNum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
    }
}
