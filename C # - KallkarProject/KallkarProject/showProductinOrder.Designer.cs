namespace KallkarProject
{
    partial class showProductinOrder
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
            this.productNumber = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.coments = new System.Windows.Forms.Label();
            this.textBoxPNUM = new System.Windows.Forms.TextBox();
            this.textBoxPNAME = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxComents = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productNumber
            // 
            this.productNumber.AutoSize = true;
            this.productNumber.Location = new System.Drawing.Point(126, 60);
            this.productNumber.Name = "productNumber";
            this.productNumber.Size = new System.Drawing.Size(125, 20);
            this.productNumber.TabIndex = 0;
            this.productNumber.Text = "product number:";
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Location = new System.Drawing.Point(126, 128);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(111, 20);
            this.productName.TabIndex = 1;
            this.productName.Text = "product name:";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(126, 210);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(69, 20);
            this.quantity.TabIndex = 2;
            this.quantity.Text = "quantity:";
            // 
            // coments
            // 
            this.coments.AutoSize = true;
            this.coments.Location = new System.Drawing.Point(126, 300);
            this.coments.Name = "coments";
            this.coments.Size = new System.Drawing.Size(74, 20);
            this.coments.TabIndex = 3;
            this.coments.Text = "coments:";
            // 
            // textBoxPNUM
            // 
            this.textBoxPNUM.Location = new System.Drawing.Point(291, 68);
            this.textBoxPNUM.Name = "textBoxPNUM";
            this.textBoxPNUM.Size = new System.Drawing.Size(157, 26);
            this.textBoxPNUM.TabIndex = 4;
            this.textBoxPNUM.TextChanged += new System.EventHandler(this.textBoxPNUM_TextChanged);
            // 
            // textBoxPNAME
            // 
            this.textBoxPNAME.Location = new System.Drawing.Point(290, 138);
            this.textBoxPNAME.Name = "textBoxPNAME";
            this.textBoxPNAME.Size = new System.Drawing.Size(182, 26);
            this.textBoxPNAME.TabIndex = 5;
            this.textBoxPNAME.TextChanged += new System.EventHandler(this.textBoxPNAME_TextChanged);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(281, 213);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(190, 26);
            this.textBoxQuantity.TabIndex = 6;
            this.textBoxQuantity.TextChanged += new System.EventHandler(this.textBoxQuantity_TextChanged);
            // 
            // textBoxComents
            // 
            this.textBoxComents.Location = new System.Drawing.Point(271, 307);
            this.textBoxComents.Name = "textBoxComents";
            this.textBoxComents.Size = new System.Drawing.Size(272, 26);
            this.textBoxComents.TabIndex = 7;
            this.textBoxComents.TextChanged += new System.EventHandler(this.textBoxComents_TextChanged);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(247, 389);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(148, 49);
            this.submit.TabIndex = 8;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(416, 389);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(127, 49);
            this.Next.TabIndex = 9;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(719, 409);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(69, 29);
            this.Back.TabIndex = 10;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // showProductinOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.textBoxComents);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxPNAME);
            this.Controls.Add(this.textBoxPNUM);
            this.Controls.Add(this.coments);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.productNumber);
            this.Name = "showProductinOrder";
            this.Text = "showProductinOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productNumber;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label coments;
        private System.Windows.Forms.TextBox textBoxPNUM;
        private System.Windows.Forms.TextBox textBoxPNAME;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxComents;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Back;
    }
}

