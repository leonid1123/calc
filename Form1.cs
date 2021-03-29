using System;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Form1 : Form
    {
        Single x1, x2;
        bool start = false;
        string zn;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//все кнопки цифр
            if (start)
            {
                textBox1.Clear();
                label1.Text = "";
                textBox1.Text += (sender as Button).Text;
                start = false;
            } else
            {
                textBox1.Text += (sender as Button).Text;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {//кнопка смена знака
            textBox1.Text = (Single.Parse(textBox1.Text) * (-1)).ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {//кнопка плюс,минус,умножить,поделить
            x1 = Single.Parse(textBox1.Text);
            zn = (sender as Button).Text;
            switch (zn)
            {
                case "+":
                    label1.Text = textBox1.Text + " + ";   
                    break;
                case "-":
                    label1.Text = textBox1.Text + " - ";
                    break;
                case "/":
                    label1.Text = textBox1.Text + " / ";
                    break;
                case "*":
                    label1.Text = textBox1.Text + " * ";
                    break;
            }
            textBox1.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {//стереть всё
            textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {//стереть последний символ
            if (textBox1.Text.Length != 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {//кнопка равно
            x2 = Single.Parse(textBox1.Text);
            label1.Text += textBox1.Text + " = ";
            textBox1.Clear();
            textBox1.Text = (x1 + x2).ToString();
            start = true;
        }
    }
}
