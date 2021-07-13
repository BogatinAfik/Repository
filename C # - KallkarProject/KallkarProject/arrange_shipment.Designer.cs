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
            this.SuspendLayout();
            // 
            // shipment_id_input
            // 
            this.shipment_id_input.Location = new System.Drawing.Point(279, 71);
            this.shipment_id_input.Name = "shipment_id_input";
            this.shipment_id_input.Size = new System.Drawing.Size(243, 26);
            this.shipment_id_input.TabIndex = 0;
            this.shipment_id_input.TextChanged += new System.EventHandler(this.shipment_id_input_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Shipment Id";
            // 
            // shipment_button
            // 
            this.shipment_button.Location = new System.Drawing.Point(563, 61);
            this.shipment_button.Name = "shipment_button";
            this.shipment_button.Size = new System.Drawing.Size(70, 47);
            this.shipment_button.TabIndex = 3;
            this.shipment_button.Text = "submit";
            this.shipment_button.UseVisualStyleBackColor = true;
            this.shipment_button.Click += new System.EventHandler(this.shipment_button_Click);
            // 
            // orderText
            // 
            this.orderText.Location = new System.Drawing.Point(109, 133);
            this.orderText.Name = "orderText";
            this.orderText.Size = new System.Drawing.Size(552, 246);
            this.orderText.TabIndex = 4;
            this.orderText.Text = "";
            this.orderText.TextChanged += new System.EventHandler(this.orderText_TextChanged);
            // 
            // order_id
            // 
            this.order_id.AutoSize = true;
            this.order_id.Location = new System.Drawing.Point(226, 407);
            this.order_id.Name = "order_id";
            this.order_id.Size = new System.Drawing.Size(66, 20);
            this.order_id.TabIndex = 2;
            this.order_id.Text = "order id:";
            // 
            // order_id_input
            // 
            this.order_id_input.Location = new System.Drawing.Point(298, 407);
            this.order_id_input.Name = "order_id_input";
            this.order_id_input.Size = new System.Drawing.Size(185, 26);
            this.order_id_input.TabIndex = 5;
            // 
            // take_order
            // 
            this.take_order.Location = new System.Drawing.Point(528, 385);
            this.take_order.Name = "take_order";
            this.take_order.Size = new System.Drawing.Size(251, 54);
            this.take_order.TabIndex = 6;
            this.take_order.Text = "take order from storage";
            this.take_order.UseVisualStyleBackColor = true;
            this.take_order.Click += new System.EventHandler(this.take_order_Click);
            // 
            // arrange_shipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

