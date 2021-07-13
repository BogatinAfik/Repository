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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productNumber
            // 
            this.productNumber.AutoSize = true;
            this.productNumber.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold);
            this.productNumber.Location = new System.Drawing.Point(103, 106);
            this.productNumber.Name = "productNumber";
            this.productNumber.Size = new System.Drawing.Size(143, 22);
            this.productNumber.TabIndex = 0;
            this.productNumber.Text = "product number:";
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold);
            this.productName.Location = new System.Drawing.Point(103, 163);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(128, 22);
            this.productName.TabIndex = 1;
            this.productName.Text = "product name:";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold);
            this.quantity.Location = new System.Drawing.Point(106, 211);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(80, 22);
            this.quantity.TabIndex = 2;
            this.quantity.Text = "quantity:";
            // 
            // coments
            // 
            this.coments.AutoSize = true;
            this.coments.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold);
            this.coments.Location = new System.Drawing.Point(106, 253);
            this.coments.Name = "coments";
            this.coments.Size = new System.Drawing.Size(98, 22);
            this.coments.TabIndex = 3;
            this.coments.Text = "comments:";
            // 
            // textBoxPNUM
            // 
            this.textBoxPNUM.Location = new System.Drawing.Point(258, 106);
            this.textBoxPNUM.Name = "textBoxPNUM";
            this.textBoxPNUM.Size = new System.Drawing.Size(182, 26);
            this.textBoxPNUM.TabIndex = 4;
            this.textBoxPNUM.TextChanged += new System.EventHandler(this.textBoxPNUM_TextChanged);
            // 
            // textBoxPNAME
            // 
            this.textBoxPNAME.Location = new System.Drawing.Point(258, 159);
            this.textBoxPNAME.Name = "textBoxPNAME";
            this.textBoxPNAME.Size = new System.Drawing.Size(182, 26);
            this.textBoxPNAME.TabIndex = 5;
            this.textBoxPNAME.TextChanged += new System.EventHandler(this.textBoxPNAME_TextChanged);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(258, 207);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(182, 26);
            this.textBoxQuantity.TabIndex = 6;
            this.textBoxQuantity.TextChanged += new System.EventHandler(this.textBoxQuantity_TextChanged);
            // 
            // textBoxComents
            // 
            this.textBoxComents.Location = new System.Drawing.Point(258, 253);
            this.textBoxComents.Name = "textBoxComents";
            this.textBoxComents.Size = new System.Drawing.Size(386, 26);
            this.textBoxComents.TabIndex = 7;
            this.textBoxComents.TextChanged += new System.EventHandler(this.textBoxComents_TextChanged);
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.submit.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold);
            this.submit.Location = new System.Drawing.Point(258, 313);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(186, 38);
            this.submit.TabIndex = 8;
            this.submit.Text = "submit this product";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Next.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold);
            this.Next.Location = new System.Drawing.Point(602, 406);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(186, 32);
            this.Next.TabIndex = 9;
            this.Next.Text = "next product";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Black;
            this.Back.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(69, 29);
            this.Back.TabIndex = 10;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Levenim MT", 16F);
            this.label1.Location = new System.Drawing.Point(161, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "choose product details ";
            // 
            // showProductinOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
    }
}

