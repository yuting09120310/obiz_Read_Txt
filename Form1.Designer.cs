namespace obiz_load_data
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Tb_Text = new System.Windows.Forms.TextBox();
            this.Add_Text = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Tb_Text
            // 
            this.Tb_Text.Location = new System.Drawing.Point(136, 43);
            this.Tb_Text.Name = "Tb_Text";
            this.Tb_Text.Size = new System.Drawing.Size(259, 22);
            this.Tb_Text.TabIndex = 0;
            // 
            // Add_Text
            // 
            this.Add_Text.Location = new System.Drawing.Point(422, 43);
            this.Add_Text.Name = "Add_Text";
            this.Add_Text.Size = new System.Drawing.Size(75, 23);
            this.Add_Text.TabIndex = 1;
            this.Add_Text.Text = "新增";
            this.Add_Text.UseVisualStyleBackColor = true;
            this.Add_Text.Click += new System.EventHandler(this.Add_Text_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 138);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(501, 254);
            this.textBox2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 437);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Add_Text);
            this.Controls.Add(this.Tb_Text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_Text;
        private System.Windows.Forms.Button Add_Text;
        private System.Windows.Forms.TextBox textBox2;
    }
}

