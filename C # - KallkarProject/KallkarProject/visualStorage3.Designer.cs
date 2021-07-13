namespace KallkarProject
{
    partial class visualStorage3
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
            this.c14 = new System.Windows.Forms.Button();
            this.c15 = new System.Windows.Forms.Button();
            this.finish_button = new System.Windows.Forms.Button();
            this.take_label = new System.Windows.Forms.Label();
            this.no_take_button = new System.Windows.Forms.Button();
            this.document_label = new System.Windows.Forms.Label();
            this.free_space_text = new System.Windows.Forms.RichTextBox();
            this.exit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // c14
            // 
            this.c14.Font = new System.Drawing.Font("Segoe Print", 24F);
            this.c14.Location = new System.Drawing.Point(872, 0);
            this.c14.Name = "c14";
            this.c14.Size = new System.Drawing.Size(308, 447);
            this.c14.TabIndex = 0;
            this.c14.Text = "C14";
            this.c14.UseVisualStyleBackColor = true;
            
            // 
            // c15
            // 
            this.c15.Font = new System.Drawing.Font("Segoe Print", 24F);
            this.c15.Location = new System.Drawing.Point(-4, 0);
            this.c15.Name = "c15";
            this.c15.Size = new System.Drawing.Size(309, 447);
            this.c15.TabIndex = 0;
            this.c15.Text = "C15";
            this.c15.UseVisualStyleBackColor = true;
            
            // 
            // finish_button
            // 
            this.finish_button.Font = new System.Drawing.Font("Segoe Print", 8F);
            this.finish_button.Location = new System.Drawing.Point(508, 381);
            this.finish_button.Name = "finish_button";
            this.finish_button.Size = new System.Drawing.Size(91, 38);
            this.finish_button.TabIndex = 2;
            this.finish_button.Text = "yes";
            this.finish_button.UseVisualStyleBackColor = true;
            this.finish_button.Click += new System.EventHandler(this.finish_button_Click);
            // 
            // take_label
            // 
            this.take_label.AutoSize = true;
            this.take_label.Location = new System.Drawing.Point(561, 326);
            this.take_label.Name = "take_label";
            this.take_label.Size = new System.Drawing.Size(115, 20);
            this.take_label.TabIndex = 3;
            this.take_label.Text = "did you take it?";
            this.take_label.Click += new System.EventHandler(this.take_label_Click);
            // 
            // no_take_button
            // 
            this.no_take_button.Font = new System.Drawing.Font("Segoe Print", 8F);
            this.no_take_button.Location = new System.Drawing.Point(619, 381);
            this.no_take_button.Name = "no_take_button";
            this.no_take_button.Size = new System.Drawing.Size(94, 38);
            this.no_take_button.TabIndex = 4;
            this.no_take_button.Text = "no";
            this.no_take_button.UseVisualStyleBackColor = true;
            this.no_take_button.Click += new System.EventHandler(this.no_take_button_Click);
            // 
            // document_label
            // 
            this.document_label.AutoSize = true;
            this.document_label.Location = new System.Drawing.Point(569, 326);
            this.document_label.Name = "document_label";
            this.document_label.Size = new System.Drawing.Size(107, 20);
            this.document_label.TabIndex = 3;
            this.document_label.Text = "did you put it?";
            this.document_label.Click += new System.EventHandler(this.take_label_Click);
            // 
            // free_space_text
            // 
            this.free_space_text.BackColor = System.Drawing.Color.PowderBlue;
            this.free_space_text.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold);
            this.free_space_text.Location = new System.Drawing.Point(398, 161);
            this.free_space_text.Name = "free_space_text";
            this.free_space_text.Size = new System.Drawing.Size(427, 134);
            this.free_space_text.TabIndex = 5;
            this.free_space_text.Text = "";
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Red;
            this.exit_button.Font = new System.Drawing.Font("Segoe Print", 8F);
            this.exit_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit_button.Location = new System.Drawing.Point(552, 405);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(107, 42);
            this.exit_button.TabIndex = 6;
            this.exit_button.Text = "exit";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 30F);
            this.label1.Location = new System.Drawing.Point(430, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 105);
            this.label1.TabIndex = 7;
            this.label1.Text = "storage C";
            // 
            // visualStorage3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1183, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.free_space_text);
            this.Controls.Add(this.no_take_button);
            this.Controls.Add(this.document_label);
            this.Controls.Add(this.take_label);
            this.Controls.Add(this.finish_button);
            this.Controls.Add(this.c15);
            this.Controls.Add(this.c14);
            this.Name = "visualStorage3";
            this.Text = "visualStorage";
            this.Load += new System.EventHandler(this.visualStorage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button c14;
        private System.Windows.Forms.Button c15;
        private System.Windows.Forms.Button finish_button;
        private System.Windows.Forms.Label take_label;
        private System.Windows.Forms.Button no_take_button;
        private System.Windows.Forms.Label document_label;
        private System.Windows.Forms.RichTextBox free_space_text;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label label1;
    }
}