namespace hex_decimal_converter
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_hex2dec = new System.Windows.Forms.Button();
            this.btn_dec2hex = new System.Windows.Forms.Button();
            this.textBox_hex_src = new System.Windows.Forms.TextBox();
            this.textBox_dec_dst = new System.Windows.Forms.TextBox();
            this.textBox_dec_src = new System.Windows.Forms.TextBox();
            this.textBox_hex_dst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lable_tip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_hex2dec
            // 
            this.btn_hex2dec.Location = new System.Drawing.Point(196, 53);
            this.btn_hex2dec.Name = "btn_hex2dec";
            this.btn_hex2dec.Size = new System.Drawing.Size(75, 23);
            this.btn_hex2dec.TabIndex = 0;
            this.btn_hex2dec.Text = "hex2dec";
            this.btn_hex2dec.UseVisualStyleBackColor = true;
            this.btn_hex2dec.Click += new System.EventHandler(this.btn_hex2dec_Click);
            // 
            // btn_dec2hex
            // 
            this.btn_dec2hex.Location = new System.Drawing.Point(195, 103);
            this.btn_dec2hex.Name = "btn_dec2hex";
            this.btn_dec2hex.Size = new System.Drawing.Size(75, 23);
            this.btn_dec2hex.TabIndex = 1;
            this.btn_dec2hex.Text = "dec2hex";
            this.btn_dec2hex.UseVisualStyleBackColor = true;
            this.btn_dec2hex.Click += new System.EventHandler(this.btn_dec2hex_Click);
            // 
            // textBox_hex_src
            // 
            this.textBox_hex_src.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_hex_src.Location = new System.Drawing.Point(87, 52);
            this.textBox_hex_src.Name = "textBox_hex_src";
            this.textBox_hex_src.Size = new System.Drawing.Size(100, 26);
            this.textBox_hex_src.TabIndex = 2;
            this.textBox_hex_src.TextChanged += new System.EventHandler(this.textBox_hex_src_TextChanged);
            this.textBox_hex_src.DoubleClick += new System.EventHandler(this.textBox_hex_src_DoubleClick);
            // 
            // textBox_dec_dst
            // 
            this.textBox_dec_dst.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_dec_dst.Location = new System.Drawing.Point(282, 52);
            this.textBox_dec_dst.Name = "textBox_dec_dst";
            this.textBox_dec_dst.Size = new System.Drawing.Size(100, 26);
            this.textBox_dec_dst.TabIndex = 2;
            // 
            // textBox_dec_src
            // 
            this.textBox_dec_src.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_dec_src.Location = new System.Drawing.Point(87, 103);
            this.textBox_dec_src.Name = "textBox_dec_src";
            this.textBox_dec_src.Size = new System.Drawing.Size(100, 26);
            this.textBox_dec_src.TabIndex = 2;
            this.textBox_dec_src.TextChanged += new System.EventHandler(this.textBox_dec_src_TextChanged);
            this.textBox_dec_src.DoubleClick += new System.EventHandler(this.textBox_dec_src_DoubleClick);
            // 
            // textBox_hex_dst
            // 
            this.textBox_hex_dst.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_hex_dst.Location = new System.Drawing.Point(282, 103);
            this.textBox_hex_dst.Name = "textBox_hex_dst";
            this.textBox_hex_dst.Size = new System.Drawing.Size(100, 26);
            this.textBox_hex_dst.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(27, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "HEX: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(391, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "HEX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(391, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Decimal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(4, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Decimal: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(34, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "提示：";
            // 
            // lable_tip
            // 
            this.lable_tip.AutoSize = true;
            this.lable_tip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lable_tip.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lable_tip.ForeColor = System.Drawing.Color.Gold;
            this.lable_tip.Location = new System.Drawing.Point(84, 176);
            this.lable_tip.Name = "lable_tip";
            this.lable_tip.Size = new System.Drawing.Size(161, 16);
            this.lable_tip.TabIndex = 5;
            this.lable_tip.Text = "Have a happy day!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(473, 251);
            this.Controls.Add(this.lable_tip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_hex_dst);
            this.Controls.Add(this.textBox_dec_src);
            this.Controls.Add(this.textBox_dec_dst);
            this.Controls.Add(this.textBox_hex_src);
            this.Controls.Add(this.btn_dec2hex);
            this.Controls.Add(this.btn_hex2dec);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "进制转换器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hex2dec;
        private System.Windows.Forms.Button btn_dec2hex;
        private System.Windows.Forms.TextBox textBox_hex_src;
        private System.Windows.Forms.TextBox textBox_dec_dst;
        private System.Windows.Forms.TextBox textBox_dec_src;
        private System.Windows.Forms.TextBox textBox_hex_dst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lable_tip;
    }
}

