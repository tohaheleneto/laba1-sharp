using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            double d;
            Boolean r=true;
            if (!((Int32.TryParse(textBox1.Text,out a)))){
                MessageBox.Show("вы неправильно ввели коэффициент a");
                r = false;
            }
            if (!((Int32.TryParse(textBox2.Text, out b))))
            {
                MessageBox.Show("вы неправильно ввели коэффициент b");
                r = false;
            }
            if (!((Int32.TryParse(textBox3.Text, out c))))
            {
                MessageBox.Show("вы неправильно ввели коэффициент c");
                r = false;
            }
            if (a == 0) MessageBox.Show("Это не квадратное уравнение");
            else if (r) {
                d = b*b-4*a*c;
                textBox6.Text = " "+d;
                if (d<0)
                { MessageBox.Show("Дискриминант отрицательный"); }
                else if (d == 0)
                { MessageBox.Show("Дискриминант равен нулю,корни совпадают");
                    textBox4.Text = " " + (-b / (2.0 * a));//без добавление .0 результат 
                    textBox5.Text = " " + (-b / (2.0 * a));//будет округлён до целого
                }
                else
                {
                    textBox4.Text = " " + ((-b -Math.Sqrt(d)) / (2.0 * a));//без добавление .0 результат 
                    textBox5.Text = " " + ((-b + Math.Sqrt(d) )/ (2.0 * a));//будет округлён до целого
                }
            }
        }
    }
}
