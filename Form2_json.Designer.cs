namespace obiz_load_data
{
    partial class Form2_json
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
            this.textBox2.Location = new System.Drawing.Point(35, 111);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(501, 441);
            this.textBox2.TabIndex = 5;
            // 
            // Add_Text
            // 
            this.Add_Text.Location = new System.Drawing.Point(401, 51);
            this.Add_Text.Name = "Add_Text";
            this.Add_Text.Size = new System.Drawing.Size(75, 23);
            this.Add_Text.TabIndex = 4;
            this.Add_Text.Text = "新增";
            this.Add_Text.UseVisualStyleBackColor = true;
            this.Add_Text.Click += new System.EventHandler(this.Add_Text_Click);
            // 
            // Tb_Text
            // 
            this.Tb_Text.Location = new System.Drawing.Point(115, 51);
            this.Tb_Text.Name = "Tb_Text";
            this.Tb_Text.Size = new System.Drawing.Size(259, 22);
            this.Tb_Text.TabIndex = 3;
            // 
            // Form2_json
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 564);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Add_Text);
            this.Controls.Add(this.Tb_Text);
            this.Name = "Form2_json";
            this.Text = "Form2_json";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Add_Text;
        private System.Windows.Forms.TextBox Tb_Text;
    }
}