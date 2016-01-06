namespace Soap
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_fast_aes_gen = new System.Windows.Forms.Button();
            this.textBox_fast_aes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_fast_Content = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_odp_final = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(449, 291);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_fast_aes_gen);
            this.tabPage1.Controls.Add(this.textBox_fast_aes);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox_fast_Content);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(441, 265);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fast-ODP";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_fast_aes_gen
            // 
            this.button_fast_aes_gen.Location = new System.Drawing.Point(356, 231);
            this.button_fast_aes_gen.Name = "button_fast_aes_gen";
            this.button_fast_aes_gen.Size = new System.Drawing.Size(79, 21);
            this.button_fast_aes_gen.TabIndex = 4;
            this.button_fast_aes_gen.Text = "随机生成";
            this.button_fast_aes_gen.UseVisualStyleBackColor = true;
            this.button_fast_aes_gen.Click += new System.EventHandler(this.button_fast_aes_gen_Click);
            // 
            // textBox_fast_aes
            // 
            this.textBox_fast_aes.Location = new System.Drawing.Point(68, 231);
            this.textBox_fast_aes.Name = "textBox_fast_aes";
            this.textBox_fast_aes.Size = new System.Drawing.Size(282, 21);
            this.textBox_fast_aes.TabIndex = 3;
            this.textBox_fast_aes.TextChanged += new System.EventHandler(this.textBox_fast_aes_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "消息密码\r\n(AES)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "消息\r\n\r\n内容";
            // 
            // textBox_fast_Content
            // 
            this.textBox_fast_Content.Location = new System.Drawing.Point(67, 6);
            this.textBox_fast_Content.Multiline = true;
            this.textBox_fast_Content.Name = "textBox_fast_Content";
            this.textBox_fast_Content.Size = new System.Drawing.Size(368, 219);
            this.textBox_fast_Content.TabIndex = 0;
            this.textBox_fast_Content.TextChanged += new System.EventHandler(this.textBox_fast_Content_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(441, 265);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Classic-ODP";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "协议标准仍在拟定过程中...";
            // 
            // textBox_odp_final
            // 
            this.textBox_odp_final.Location = new System.Drawing.Point(12, 347);
            this.textBox_odp_final.Multiline = true;
            this.textBox_odp_final.Name = "textBox_odp_final";
            this.textBox_odp_final.Size = new System.Drawing.Size(445, 133);
            this.textBox_odp_final.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "ODP 消息将自动生成在下方";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_odp_final);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Soap 0.1 | ODP 消息生成工具";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_odp_final;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_fast_aes_gen;
        private System.Windows.Forms.TextBox textBox_fast_aes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_fast_Content;
        private System.Windows.Forms.Label label2;
    }
}

