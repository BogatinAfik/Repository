namespace KallkarProject
{
    partial class manage_storage
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
            this.arrange_shipment_button = new System.Windows.Forms.Button();
            this.document_orders_button = new System.Windows.Forms.Button();
            this.show_storage_button = new System.Windows.Forms.Button();
            this.choose_storage = new System.Windows.Forms.ComboBox();
            this.need_pick_storage = new System.Windows.Forms.Button();
            this.submit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // arrange_shipment_button
            // 
            this.arrange_shipment_button.BackColor = System.Drawing.Color.DarkTurquoise;
            this.arrange_shipment_button.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.arrange_shipment_button.Location = new System.Drawing.Point(525, 149);
            this.arrange_shipment_button.Name = "arrange_shipment_button";
            this.arrange_shipment_button.Size = new System.Drawing.Size(263, 43);
            this.arrange_shipment_button.TabIndex = 0;
            this.arrange_shipment_button.Text = "arrange shipment";
            this.arrange_shipment_button.UseVisualStyleBackColor = false;
            this.arrange_shipment_button.Click += new System.EventHandler(this.arrange_shipment_button_Click);
            // 
            // document_orders_button
            // 
            this.document_orders_button.BackColor = System.Drawing.Color.Turquoise;
            this.document_orders_button.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.document_orders_button.Location = new System.Drawing.Point(277, 149);
            this.document_orders_button.Name = "document_orders_button";
            this.document_orders_button.Size = new System.Drawing.Size(242, 43);
            this.document_orders_button.TabIndex = 1;
            this.document_orders_button.Text = "document orders";
            this.document_orders_button.UseVisualStyleBackColor = false;
            this.document_orders_button.Click += new System.EventHandler(this.document_orders_button_Click);
            // 
            // show_storage_button
            // 
            this.show_storage_button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.show_storage_button.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.show_storage_button.Location = new System.Drawing.Point(12, 147);
            this.show_storage_button.Name = "show_storage_button";
            this.show_storage_button.Size = new System.Drawing.Size(259, 45);
            this.show_storage_button.TabIndex = 2;
            this.show_storage_button.Text = "show storage status";
            this.show_storage_button.UseVisualStyleBackColor = false;
            this.show_storage_button.Click += new System.EventHandler(this.show_storage_button_Click);
            // 
            // choose_storage
            // 
            this.choose_storage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choose_storage.FormattingEnabled = true;
            this.choose_storage.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.choose_storage.Location = new System.Drawing.Point(292, 320);
            this.choose_storage.Name = "choose_storage";
            this.choose_storage.Size = new System.Drawing.Size(149, 28);
            this.choose_storage.TabIndex = 3;
            this.choose_storage.SelectedIndexChanged += new System.EventHandler(this.choose_storage_SelectedIndexChanged);
            // 
            // need_pick_storage
            // 
            this.need_pick_storage.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.need_pick_storage.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.need_pick_storage.Location = new System.Drawing.Point(141, 253);
            this.need_pick_storage.Name = "need_pick_storage";
            this.need_pick_storage.Size = new System.Drawing.Size(465, 42);
            this.need_pick_storage.TabIndex = 4;
            this.need_pick_storage.Text = "please pick storage";
            this.need_pick_storage.UseVisualStyleBackColor = false;
            // 
            // submit_button
            // 
            this.submit_button.BackColor = System.Drawing.Color.White;
            this.submit_button.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.submit_button.Location = new System.Drawing.Point(460, 314);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(83, 41);
            this.submit_button.TabIndex = 5;
            this.submit_button.Text = "submit";
            this.submit_button.UseVisualStyleBackColor = false;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Levenim MT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "Manage Storage";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlText;
            this.button1.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // manage_storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.need_pick_storage);
            this.Controls.Add(this.choose_storage);
            this.Controls.Add(this.show_storage_button);
            this.Controls.Add(this.document_orders_button);
            this.Controls.Add(this.arrange_shipment_button);
            this.Name = "manage_storage";
            this.Text = "manage_storage";
            this.Load += new System.EventHandler(this.manage_storage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button arrange_shipment_button;
        private System.Windows.Forms.Button document_orders_button;
        private System.Windows.Forms.Button show_storage_button;
        private System.Windows.Forms.ComboBox choose_storage;
        private System.Windows.Forms.Button need_pick_storage;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}