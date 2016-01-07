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
            this.tabControl_Driver = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button_aes_gen = new System.Windows.Forms.Button();
            this.textBox_aes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Content = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_de_aes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_de_Content = new System.Windows.Forms.TextBox();
            this.textBox_odp_final = new System.Windows.Forms.TextBox();
            this.label_tip = new System.Windows.Forms.Label();
            this.tabControl_Driver.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Driver
            // 
            this.tabControl_Driver.Controls.Add(this.tabPage1);
            this.tabControl_Driver.Controls.Add(this.tabPage2);
            this.tabControl_Driver.Location = new System.Drawing.Point(12, 12);
            this.tabControl_Driver.Name = "tabControl_Driver";
            this.tabControl_Driver.SelectedIndex = 0;
            this.tabControl_Driver.Size = new System.Drawing.Size(449, 273);
            this.tabControl_Driver.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.radioButton2);
            this.tabPage1.Controls.Add(this.radioButton1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button_aes_gen);
            this.tabPage1.Controls.Add(this.textBox_aes);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox_Content);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(441, 247);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "老司机模式";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(145, 219);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(155, 16);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "Classic-ODP (暂不支持)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(68, 219);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 16);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Fast-ODP";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "类型";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_aes_gen
            // 
            this.button_aes_gen.Location = new System.Drawing.Point(356, 192);
            this.button_aes_gen.Name = "button_aes_gen";
            this.button_aes_gen.Size = new System.Drawing.Size(79, 21);
            this.button_aes_gen.TabIndex = 4;
            this.button_aes_gen.Text = "随机生成";
            this.button_aes_gen.UseVisualStyleBackColor = true;
            this.button_aes_gen.Click += new System.EventHandler(this.button_aes_gen_Click);
            // 
            // textBox_aes
            // 
            this.textBox_aes.Location = new System.Drawing.Point(67, 192);
            this.textBox_aes.Name = "textBox_aes";
            this.textBox_aes.Size = new System.Drawing.Size(283, 21);
            this.textBox_aes.TabIndex = 3;
            this.textBox_aes.TextChanged += new System.EventHandler(this.textBox_aes_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "消息密码\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "消息\r\n\r\n明文";
            // 
            // textBox_Content
            // 
            this.textBox_Content.Location = new System.Drawing.Point(67, 6);
            this.textBox_Content.Multiline = true;
            this.textBox_Content.Name = "textBox_Content";
            this.textBox_Content.Size = new System.Drawing.Size(368, 180);
            this.textBox_Content.TabIndex = 0;
            this.textBox_Content.Text = "[将发车内容填写在这里，没有格式要求。]";
            this.textBox_Content.TextChanged += new System.EventHandler(this.textBox_Content_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox_de_aes);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox_de_Content);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(441, 247);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "乘客模式";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox_de_aes
            // 
            this.textBox_de_aes.Location = new System.Drawing.Point(67, 220);
            this.textBox_de_aes.Name = "textBox_de_aes";
            this.textBox_de_aes.Size = new System.Drawing.Size(368, 21);
            this.textBox_de_aes.TabIndex = 7;
            this.textBox_de_aes.TextChanged += new System.EventHandler(this.textBox_de_aes_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "消息密码\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 36);
            this.label6.TabIndex = 5;
            this.label6.Text = "消息\r\n\r\n密文";
            // 
            // textBox_de_Content
            // 
            this.textBox_de_Content.Location = new System.Drawing.Point(67, 6);
            this.textBox_de_Content.Multiline = true;
            this.textBox_de_Content.Name = "textBox_de_Content";
            this.textBox_de_Content.Size = new System.Drawing.Size(368, 208);
            this.textBox_de_Content.TabIndex = 4;
            this.textBox_de_Content.Text = "[请输入 ODP 标准消息，以 odp:// 开头，以 / 结尾。]";
            this.textBox_de_Content.TextChanged += new System.EventHandler(this.textBox_de_Content_TextChanged);
            // 
            // textBox_odp_final
            // 
            this.textBox_odp_final.Location = new System.Drawing.Point(12, 325);
            this.textBox_odp_final.Multiline = true;
            this.textBox_odp_final.Name = "textBox_odp_final";
            this.textBox_odp_final.Size = new System.Drawing.Size(445, 155);
            this.textBox_odp_final.TabIndex = 1;
            // 
            // label_tip
            // 
            this.label_tip.AutoSize = true;
            this.label_tip.Location = new System.Drawing.Point(175, 299);
            this.label_tip.Name = "label_tip";
            this.label_tip.Size = new System.Drawing.Size(125, 12);
            this.label_tip.TabIndex = 2;
            this.label_tip.Text = "结果将自动显示在下方";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 491);
            this.Controls.Add(this.label_tip);
            this.Controls.Add(this.textBox_odp_final);
            this.Controls.Add(this.tabControl_Driver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soap 0.1.1 | ODP 消息助手";
            this.tabControl_Driver.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Driver;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_odp_final;
        private System.Windows.Forms.Label label_tip;
        private System.Windows.Forms.Button button_aes_gen;
        private System.Windows.Forms.TextBox textBox_aes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Content;
        private System.Windows.Forms.TextBox textBox_de_aes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_de_Content;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
    }
}

