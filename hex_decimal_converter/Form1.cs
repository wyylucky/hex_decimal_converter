using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hex_decimal_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //判断是否为10~15之间的数，如果是则进行转换   
        public string chang(int d)
        {
            string x = "";
            switch (d)
            {
                case 10:
                    x = "A";
                    break;
                case 11:
                    x = "B";
                    break;
                case 12:
                    x = "C";
                    break;
                case 13:
                    x = "D";
                    break;
                case 14:
                    x = "E";
                    break;
                case 15:
                    x = "F";
                    break;
                default:
                    x = d.ToString();
                    break;
            }
            return x;
        }

        public string XtoD(int d)
        {
            string x = "";
            
            return x;
        }

        //十进制转十六进制   
        public string DtoX(int d)
        {
            string x = "";
            if (d < 16)
            {
                x = chang(d);
            }
            else
            {
                int c;
                int s = 0;
                int n = d;
                int temp = d;
                while (n >= 16)
                {
                    s++;
                    n = n / 16;
                }
                string[] m = new string[s];
                int i = 0;
                do
                {
                    c = d / 16;
                    m[i++] = chang(d % 16);//判断是否大于10，如果大于10，则转换为A~F的格式   
                    d = c;
                } while (c >= 16);
                x = chang(d);
                for (int j = m.Length - 1; j >= 0; j--)
                {
                    x += m[j];
                }
            }
            return x;
        }

        //十进制转八进制---www.bianceng.cn
        public string DtoO(int d)
        {
            string o = "";
            if (d < 8)
            {
                o = d.ToString();
            }
            else
            {
                int c;

                int s = 0;
                int n = d;
                int temp = d;
                while (n >= 8)
                {
                    s++;
                    n = n / 8;
                }
                int[] m = new int[s];
                int i = 0;
                do
                {
                    c = d / 8;
                    m[i++] = d % 8;
                    d = c;
                } while (c >= 8);
                o = d.ToString();
                for (int j = m.Length - 1; j >= 0; j--)
                {
                    o += m[j];
                }
            }
            return o;
        }

        //十进制转二制   
        public string DtoB(int d)
        {
            string b = "";
            //判断该数如果小于2，则直接输出   
            if (d < 2)
            {
                b = d.ToString();
            }
            else
            {
                int c;
                int s = 0;
                int n = d;
                while (n >= 2)
                {
                    s++;
                    n = n / 2;
                }
                int[] m = new int[s];
                int i = 0;
                do
                {
                    c = d / 2;
                    m[i++] = d % 2;
                    d = c;
                } while (c >= 2);
                b = d.ToString();
                for (int j = m.Length - 1; j >= 0; j--)
                {
                    b += m[j].ToString();
                }
            }
            return b;
        }
        private void btn_hex2dec_Click(object sender, EventArgs e)
        {
            string hex_src = textBox_hex_src.Text;
                       
            try
            {
                textBox_dec_dst.Text = Convert.ToInt32(hex_src, 16).ToString(); //十六进制转十进制
            }
            catch
            {
                textBox_dec_dst.Text = "";
                textBox_hex_src.Text = "";
                lable_tip.Text = hex_src + " 不符合十六进制格式";
            }
        }

        private void btn_dec2hex_Click(object sender, EventArgs e)
        {
            //string dec_src = textBox_dec_src.Text;
            //textBox_hex_dst.Text = dec_src;

            try
            {
                textBox_hex_dst.Text = DtoX(Convert.ToInt32(textBox_dec_src.Text));//十转十六进制
            }
            catch
            {
                lable_tip.Text = textBox_dec_src.Text + " 不符合十进制格式";
                textBox_hex_dst.Text = "";
                textBox_dec_src.Text = "";
                
            }            
            
        }

        private void textBox_hex_src_DoubleClick(object sender, EventArgs e)
        {
            textBox_dec_dst.Text = "";
            textBox_hex_src.Text = "";
        }

        private void textBox_dec_src_DoubleClick(object sender, EventArgs e)
        {
            textBox_dec_src.Text = "";
            textBox_hex_dst.Text = "";
        }

        private void textBox_hex_src_TextChanged(object sender, EventArgs e)
        {
            string hex_src = textBox_hex_src.Text;
            lable_tip.Text = "Have a happy day!";
            try
            {
                textBox_dec_dst.Text = Convert.ToInt32(hex_src, 16).ToString(); //十六进制转十进制
            }
            catch
            {
                textBox_dec_dst.Text = "";
                textBox_hex_src.Text = "";
                lable_tip.Text = hex_src + " 不符合十六进制格式";
            }
        }

        private void textBox_dec_src_TextChanged(object sender, EventArgs e)
        {
            lable_tip.Text = "Have a happy day!";
            try
            {
                textBox_hex_dst.Text = DtoX(Convert.ToInt32(textBox_dec_src.Text));//十转十六进制
            }
            catch
            {
                lable_tip.Text = textBox_dec_src.Text + " 不符合十进制格式";
                textBox_hex_dst.Text = "";
                textBox_dec_src.Text = "";
            }
        }
    }
}
