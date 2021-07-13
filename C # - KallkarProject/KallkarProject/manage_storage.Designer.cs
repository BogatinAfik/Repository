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
            this.SuspendLayout();
            // 
            // arrange_shipment_button
            // 
            this.arrange_shipment_button.Location = new System.Drawing.Point(572, 149);
            this.arrange_shipment_button.Name = "arrange_shipment_button";
            this.arrange_shipment_button.Size = new System.Drawing.Size(155, 98);
            this.arrange_shipment_button.TabIndex = 0;
            this.arrange_shipment_button.Text = "arrange shipment";
            this.arrange_shipment_button.UseVisualStyleBackColor = true;
            this.arrange_shipment_button.Click += new System.EventHandler(this.arrange_shipment_button_Click);
            // 
            // document_orders_button
            // 
            this.document_orders_button.Location = new System.Drawing.Point(323, 149);
            this.document_orders_button.Name = "document_orders_button";
            this.document_orders_button.Size = new System.Drawing.Size(166, 98);
            this.document_orders_button.TabIndex = 1;
            this.document_orders_button.Text = "document orders";
            this.document_orders_button.UseVisualStyleBackColor = true;
            this.document_orders_button.Click += new System.EventHandler(this.document_orders_button_Click);
            // 
            // show_storage_button
            // 
            this.show_storage_button.Location = new System.Drawing.Point(62, 147);
            this.show_storage_button.Name = "show_storage_button";
            this.show_storage_button.Size = new System.Drawing.Size(160, 102);
            this.show_storage_button.TabIndex = 2;
            this.show_storage_button.Text = "show storage status";
            this.show_storage_button.UseVisualStyleBackColor = true;
            this.show_storage_button.Click += new System.EventHandler(this.show_storage_button_Click);
            // 
            // choose_storage
            // 
            this.choose_storage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choose_storage.FormattingEnabled = true;
            this.choose_storage.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.choose_storage.Location = new System.Drawing.Point(292, 320);
            this.choose_storage.Name = "choose_storage";
            this.choose_storage.Size = new System.Drawing.Size(149, 28);
            this.choose_storage.TabIndex = 3;
            this.choose_storage.SelectedIndexChanged += new System.EventHandler(this.choose_storage_SelectedIndexChanged);
            // 
            // need_pick_storage
            // 
            this.need_pick_storage.Location = new System.Drawing.Point(155, 55);
            this.need_pick_storage.Name = "need_pick_storage";
            this.need_pick_storage.Size = new System.Drawing.Size(441, 247);
            this.need_pick_storage.TabIndex = 4;
            this.need_pick_storage.Text = "please pick storage";
            this.need_pick_storage.UseVisualStyleBackColor = true;
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(482, 321);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(83, 41);
            this.submit_button.TabIndex = 5;
            this.submit_button.Text = "submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // manage_storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

        }

        #endregion

        private System.Windows.Forms.Button arrange_shipment_button;
        private System.Windows.Forms.Button document_orders_button;
        private System.Windows.Forms.Button show_storage_button;
        private System.Windows.Forms.ComboBox choose_storage;
        private System.Windows.Forms.Button need_pick_storage;
        private System.Windows.Forms.Button submit_button;
    }
}