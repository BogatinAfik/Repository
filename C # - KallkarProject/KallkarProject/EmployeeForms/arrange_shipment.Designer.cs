namespace KallkarProject
{
    partial class arrange_shipment
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
            this.shipment_id_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shipment_button = new System.Windows.Forms.Button();
            this.orderText = new System.Windows.Forms.RichTextBox();
            this.order_id = new System.Windows.Forms.Label();
            this.order_id_input = new System.Windows.Forms.TextBox();
            this.take_order = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shipment_id_input
            // 
            this.shipment_id_input.Location = new System.Drawing.Point(281, 76);
            this.shipment_id_input.Name = "shipment_id_input";
            this.shipment_id_input.Size = new System.Drawing.Size(243, 26);
            this.shipment_id_input.TabIndex = 0;
            this.shipment_id_input.TextChanged += new System.EventHandler(this.shipment_id_input_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Levenim MT", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(312, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Shipment Id";
            // 
            // shipment_button
            // 
            this.shipment_button.BackColor = System.Drawing.Color.Turquoise;
            this.shipment_button.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.shipment_button.Location = new System.Drawing.Point(553, 71);
            this.shipment_button.Name = "shipment_button";
            this.shipment_button.Size = new System.Drawing.Size(129, 36);
            this.shipment_button.TabIndex = 3;
            this.shipment_button.Text = "submit";
            this.shipment_button.UseVisualStyleBackColor = false;
            this.shipment_button.Click += new System.EventHandler(this.shipment_button_Click);
            // 
            // orderText
            // 
            this.orderText.BackColor = System.Drawing.Color.PaleTurquoise;
            this.orderText.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.orderText.Location = new System.Drawing.Point(75, 133);
            this.orderText.Name = "orderText";
            this.orderText.Size = new System.Drawing.Size(655, 211);
            this.orderText.TabIndex = 4;
            this.orderText.Text = "";
            this.orderText.TextChanged += new System.EventHandler(this.orderText_TextChanged);
            // 
            // order_id
            // 
            this.order_id.AutoSize = true;
            this.order_id.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.order_id.Location = new System.Drawing.Point(181, 379);
            this.order_id.Name = "order_id";
            this.order_id.Size = new System.Drawing.Size(94, 27);
            this.order_id.TabIndex = 2;
            this.order_id.Text = "order id:";
            // 
            // order_id_input
            // 
            this.order_id_input.Location = new System.Drawing.Point(291, 380);
            this.order_id_input.Name = "order_id_input";
            this.order_id_input.Size = new System.Drawing.Size(185, 26);
            this.order_id_input.TabIndex = 5;
            // 
            // take_order
            // 
            this.take_order.BackColor = System.Drawing.SystemColors.ControlDark;
            this.take_order.Font = new System.Drawing.Font("Levenim MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.take_order.Location = new System.Drawing.Point(517, 367);
            this.take_order.Name = "take_order";
            this.take_order.Size = new System.Drawing.Size(213, 71);
            this.take_order.TabIndex = 6;
            this.take_order.Text = "take order from storage";
            this.take_order.UseVisualStyleBackColor = false;
            this.take_order.Click += new System.EventHandler(this.take_order_Click);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back_button.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_button.Location = new System.Drawing.Point(12, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(89, 35);
            this.back_button.TabIndex = 7;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // arrange_shipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.take_order);
            this.Controls.Add(this.order_id_input);
            this.Controls.Add(this.orderText);
            this.Controls.Add(this.shipment_button);
            this.Controls.Add(this.order_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shipment_id_input);
            this.Name = "arrange_shipment";
            this.Text = "arrange_shipment";
            this.Load += new System.EventHandler(this.arrange_shipment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox shipment_id_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button shipment_button;
        private System.Windows.Forms.RichTextBox orderText;
        private System.Windows.Forms.Label order_id;
        private System.Windows.Forms.TextBox order_id_input;
        private System.Windows.Forms.Button take_order;
        private System.Windows.Forms.Button back_button;
    }
}

