using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppHello
{
    public partial class array : Form
    {
        public array()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Text.Split(',');
            int[] number = new int[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                if (int.TryParse(data[i], out int result))
                {
                    number[i] = result;
                }
                else
                {
                    number[i] = 0;

                }
            }
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }

            int max = number.Max();
            int min = number.Min();
            double average = (double)sum / number.Length;
            lblSum.Text = "จำนวนสมาชิกข้อมูล:" + number.Length;
            lblCount.Text = "ผลรวม:" + sum;
            lblAverage.Text = "ค่าเฉลี่ย:" + average;

            lblmax.Text = "ค่าสูงสุด:" + max;
            lblmin.Text = "ค่าต่ำสุด:" + min;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[,] data = new string[5, 3]
            {
                { "เอกสิทธิ์", "บอล", "อุดรธานี"},
                { "ณัฐภูมิ", "น๊อต", "หนองคาย"},
                { "วชิระ", "สเน็ค", "อุดรธานี"},
                { "ธันวา", "ท๊อป","หนองคาย" },
                { "ศุภวิช", "ไม้","บึงกาฬ" },

            };
            int row = data.GetLength(0);
            string result = "";

            for (int i = 0; i < row; i++)
            {

                result += $"ข้อมูลที่: {i + 1}";
                result += $"ชื่อ: {data[i, 0]}";
                result += $"ชื่อเล่น: {data[i, 1]}";
                result += $"จังหวัด: {data[i, 2]}";

                result += "\r\n";

            }

            textBox2.Text = result;
        }
    }
}
