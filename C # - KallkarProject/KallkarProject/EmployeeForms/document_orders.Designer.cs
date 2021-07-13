namespace KallkarProject
{
    partial class document_orders
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
            this.order_input = new System.Windows.Forms.TextBox();
            this.order_label = new System.Windows.Forms.Label();
            this.move_to_storage = new System.Windows.Forms.Button();
            this.in_production_text = new System.Windows.Forms.RichTextBox();
            this.in_production_label = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // order_input
            // 
            this.order_input.Location = new System.Drawing.Point(352, 333);
            this.order_input.Name = "order_input";
            this.order_input.Size = new System.Drawing.Size(182, 26);
            this.order_input.TabIndex = 0;
            // 
            // order_label
            // 
            this.order_label.AutoSize = true;
            this.order_label.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.order_label.Location = new System.Drawing.Point(153, 333);
            this.order_label.Name = "order_label";
            this.order_label.Size = new System.Drawing.Size(170, 27);
            this.order_label.TabIndex = 1;
            this.order_label.Text = "choose order ID";
            // 
            // move_to_storage
            // 
            this.move_to_storage.BackColor = System.Drawing.Color.DarkTurquoise;
            this.move_to_storage.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.move_to_storage.Location = new System.Drawing.Point(256, 380);
            this.move_to_storage.Name = "move_to_storage";
            this.move_to_storage.Size = new System.Drawing.Size(218, 48);
            this.move_to_storage.TabIndex = 2;
            this.move_to_storage.Text = "move to storage";
            this.move_to_storage.UseVisualStyleBackColor = false;
            this.move_to_storage.Click += new System.EventHandler(this.move_to_storage_Click);
            // 
            // in_production_text
            // 
            this.in_production_text.BackColor = System.Drawing.Color.PaleTurquoise;
            this.in_production_text.Location = new System.Drawing.Point(37, 80);
            this.in_production_text.Name = "in_production_text";
            this.in_production_text.Size = new System.Drawing.Size(701, 220);
            this.in_production_text.TabIndex = 3;
            this.in_production_text.Text = "";
            this.in_production_text.TextChanged += new System.EventHandler(this.in_production_text_TextChanged);
            // 
            // in_production_label
            // 
            this.in_production_label.AutoSize = true;
            this.in_production_label.Font = new System.Drawing.Font("Levenim MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_production_label.Location = new System.Drawing.Point(191, 9);
            this.in_production_label.Name = "in_production_label";
            this.in_production_label.Size = new System.Drawing.Size(384, 49);
            this.in_production_label.TabIndex = 4;
            this.in_production_label.Text = "Orders In Production";
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back_button.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.back_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_button.Location = new System.Drawing.Point(12, 9);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(78, 35);
            this.back_button.TabIndex = 5;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // document_orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(772, 462);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.in_production_label);
            this.Controls.Add(this.in_production_text);
            this.Controls.Add(this.move_to_storage);
            this.Controls.Add(this.order_label);
            this.Controls.Add(this.order_input);
            this.Name = "document_orders";
            this.Text = "document_orders";
            this.Load += new System.EventHandler(this.document_orders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox order_input;
        private System.Windows.Forms.Label order_label;
        private System.Windows.Forms.Button move_to_storage;
        private System.Windows.Forms.RichTextBox in_production_text;
        private System.Windows.Forms.Label in_production_label;
        private System.Windows.Forms.Button back_button;
    }
}