namespace obiz_load_data
{
    partial class Form3_xml
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Add_Text = new System.Windows.Forms.Button();
            this.Tb_Text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(18, 105);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(501, 441);
            this.textBox2.TabIndex = 8;
            // 
            // Add_Text
            // 
            this.Add_Text.Location = new System.Drawing.Point(384, 45);
            this.Add_Text.Name = "Add_Text";
            this.Add_Text.Size = new System.Drawing.Size(75, 23);
            this.Add_Text.TabIndex = 7;
            this.Add_Text.Text = "新增";
            this.Add_Text.UseVisualStyleBackColor = true;
            // 
            // Tb_Text
            // 
            this.Tb_Text.Location = new System.Drawing.Point(98, 45);
            this.Tb_Text.Name = "Tb_Text";
            this.Tb_Text.Size = new System.Drawing.Size(259, 22);
            this.Tb_Text.TabIndex = 6;
            // 
            // Form3_xml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 568);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Add_Text);
            this.Controls.Add(this.Tb_Text);
            this.Name = "Form3_xml";
            this.Text = "Form3_xml";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Add_Text;
        private System.Windows.Forms.TextBox Tb_Text;
    }
}