using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form2 : Form
    {
        public Form2() // создание окна
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(600, 480); // устанавливает минимальный размер формы
            panel2_Resize(sender, e);
            panel3_Resize(sender, e);
        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            textBox1.Height = panel2.Height;
            textBox1.Width = panel2.Width;
            textBox1.Top = 0;
            textBox1.Left = 0;
        }

        private void panel3_Resize(object sender, EventArgs e)
        {
            button40.Height = panel3.Height / 6; // высота всех кнопок подстраивается под изменение окна
            button41.Height = panel3.Height / 6;
            button42.Height = panel3.Height / 6;
            button3.Height = panel3.Height / 6;
            button1.Height = panel3.Height / 6;
            button5.Height = panel3.Height / 6;
            button6.Height = panel3.Height / 6;
            button37.Height = panel3.Height / 6;
            button38.Height = panel3.Height / 6;
            button39.Height = panel3.Height / 6;
            button7.Height = panel3.Height / 6;
            button8.Height = panel3.Height / 6;
            button9.Height = panel3.Height / 6;
            button10.Height = panel3.Height / 6;
            button34.Height = panel3.Height / 6;
            button32.Height = panel3.Height / 6;
            button33.Height = panel3.Height / 6;
            button11.Height = panel3.Height / 6;
            button12.Height = panel3.Height / 6;
            button13.Height = panel3.Height / 6;
            button14.Height = panel3.Height / 6;
            button28.Height = panel3.Height / 6;
            button29.Height = panel3.Height / 6;
            button30.Height = panel3.Height / 6;
            button15.Height = panel3.Height / 6;
            button16.Height = panel3.Height / 6;
            button17.Height = panel3.Height / 6;
            button18.Height = panel3.Height / 6;
            button31.Height = panel3.Height / 6;
            button36.Height = panel3.Height / 6;
            button35.Height = panel3.Height / 6;
            button19.Height = panel3.Height / 6;
            button20.Height = panel3.Height / 6;
            button21.Height = panel3.Height / 6;
            button22.Height = panel3.Height / 6;
            button4.Height = panel3.Height / 6;
            button2.Height = panel3.Height / 6;
            button27.Height = panel3.Height / 6;
            button23.Height = panel3.Height / 6;
            button24.Height = panel3.Height / 6;
            button25.Height = panel3.Height / 6;
            button26.Height = panel3.Height / 6;

            button40.Width = panel3.Width / 7; // ширина всех кнопок подстраивается под изменение окна
            button41.Width = panel3.Width / 7;
            button42.Width = panel3.Width / 7;
            button3.Width = panel3.Width / 7;
            button1.Width = panel3.Width / 7;
            button5.Width = panel3.Width / 7;
            button6.Width = panel3.Width / 7;
            button37.Width = panel3.Width / 7;
            button38.Width = panel3.Width / 7;
            button39.Width = panel3.Width / 7;
            button7.Width = panel3.Width / 7;
            button8.Width = panel3.Width / 7;
            button9.Width = panel3.Width / 7;
            button10.Width = panel3.Width / 7;
            button34.Width = panel3.Width / 7;
            button32.Width = panel3.Width / 7;
            button33.Width = panel3.Width / 7;
            button11.Width = panel3.Width / 7;
            button12.Width = panel3.Width / 7;
            button13.Width = panel3.Width / 7;
            button14.Width = panel3.Width / 7;
            button28.Width = panel3.Width / 7;
            button29.Width = panel3.Width / 7;
            button30.Width = panel3.Width / 7;
            button15.Width = panel3.Width / 7;
            button16.Width = panel3.Width / 7;
            button17.Width = panel3.Width / 7;
            button18.Width = panel3.Width / 7;
            button31.Width = panel3.Width / 7;
            button36.Width = panel3.Width / 7;
            button35.Width = panel3.Width / 7;
            button19.Width = panel3.Width / 7;
            button20.Width = panel3.Width / 7;
            button21.Width = panel3.Width / 7;
            button22.Width = panel3.Width / 7;
            button4.Width = panel3.Width / 7;
            button2.Width = panel3.Width / 7;
            button27.Width = panel3.Width / 7;
            button23.Width = panel3.Width / 7;
            button24.Width = panel3.Width / 7;
            button25.Width = panel3.Width / 7;
            button26.Width = panel3.Width / 7;

            button40.Top = 0; // отступ сверху всех кнопок подстраивается под изменение окна
            button41.Top = 0;
            button42.Top = 0;
            button3.Top = 0;
            button1.Top = 0;
            button5.Top = 0;
            button6.Top = 0;

            button37.Top = panel3.Height / 6;
            button38.Top = panel3.Height / 6;
            button39.Top = panel3.Height / 6;
            button7.Top = panel3.Height / 6;
            button8.Top = panel3.Height / 6;
            button9.Top = panel3.Height / 6;
            button10.Top = panel3.Height / 6;

            button34.Top = panel3.Height * 2 / 6;
            button32.Top = panel3.Height * 2 / 6;
            button33.Top = panel3.Height * 2 / 6;
            button11.Top = panel3.Height * 2 / 6;
            button12.Top = panel3.Height * 2 / 6;
            button13.Top = panel3.Height * 2 / 6;
            button14.Top = panel3.Height * 2 / 6;

            button28.Top = panel3.Height * 3 / 6;
            button29.Top = panel3.Height * 3 / 6;
            button30.Top = panel3.Height * 3 / 6;
            button15.Top = panel3.Height * 3 / 6;
            button16.Top = panel3.Height * 3 / 6;
            button17.Top = panel3.Height * 3 / 6;
            button18.Top = panel3.Height * 3 / 6;

            button31.Top = panel3.Height * 4 / 6;
            button36.Top = panel3.Height * 4 / 6;
            button35.Top = panel3.Height * 4 / 6;
            button19.Top = panel3.Height * 4 / 6;
            button20.Top = panel3.Height * 4 / 6;
            button21.Top = panel3.Height * 4 / 6;
            button22.Top = panel3.Height * 4 / 6;

            button4.Top = panel3.Height * 5 / 6;
            button2.Top = panel3.Height * 5 / 6;
            button27.Top = panel3.Height * 5 / 6;
            button23.Top = panel3.Height * 5 / 6;
            button24.Top = panel3.Height * 5 / 6;
            button25.Top = panel3.Height * 5 / 6;
            button26.Top = panel3.Height * 5 / 6;

            button40.Left = 0; // отступ слева всех кнопок подстраивается под изменение окна
            button37.Left = 0;
            button34.Left = 0;
            button28.Left = 0;
            button31.Left = 0;
            button4.Left = 0;

            button41.Left = panel3.Width / 7;
            button38.Left = panel3.Width / 7;
            button32.Left = panel3.Width / 7;
            button29.Left = panel3.Width / 7;
            button36.Left = panel3.Width / 7;
            button2.Left = panel3.Width / 7;

            button42.Left = panel3.Width * 2 / 7;
            button39.Left = panel3.Width * 2 / 7;
            button33.Left = panel3.Width * 2 / 7;
            button30.Left = panel3.Width * 2 / 7;
            button35.Left = panel3.Width * 2 / 7;
            button27.Left = panel3.Width * 2 / 7;

            button3.Left = panel3.Width * 3 / 7;
            button7.Left = panel3.Width * 3 / 7;
            button11.Left = panel3.Width * 3 / 7;
            button15.Left = panel3.Width * 3 / 7;
            button19.Left = panel3.Width * 3 / 7;
            button23.Left = panel3.Width * 3 / 7;

            button1.Left = panel3.Width * 4 / 7;
            button8.Left = panel3.Width * 4 / 7;
            button12.Left = panel3.Width * 4 / 7;
            button16.Left = panel3.Width * 4 / 7;
            button20.Left = panel3.Width * 4 / 7;
            button24.Left = panel3.Width * 4 / 7;

            button5.Left = panel3.Width * 5 / 7;
            button9.Left = panel3.Width * 5 / 7;
            button13.Left = panel3.Width * 5 / 7;
            button17.Left = panel3.Width * 5 / 7;
            button21.Left = panel3.Width * 5 / 7;
            button25.Left = panel3.Width * 5 / 7;

            button6.Left = panel3.Width * 6 / 7;
            button10.Left = panel3.Width * 6 / 7;
            button14.Left = panel3.Width * 6 / 7;
            button18.Left = panel3.Width * 6 / 7;
            button22.Left = panel3.Width * 6 / 7;
            button26.Left = panel3.Width * 6 / 7;
        }

        private void panel3_Click(object sender, EventArgs e) // набор цифр, точки и скобок
        {
            label2.Text = ""; // обнуление кнопки предыдущего значения
            Button b = (Button)sender; // получение кнопки для нажимания
            if (textBox1.Text == "0" || textBox1.Text == "∞") // убирание значение нуля
            {
                textBox1.Text = "";
            }

            if (textBox1.Text.IndexOf(".") > 0 && b.Text == ".")// если уже нажата точка, то не нажимает снова
            {
                return; // ничего не набирает
            }
            textBox1.Text = textBox1.Text + b.Text; // отправление информации на кнопку
        }
        // textBox1.Text - то, что видно на калькуляторе
        // b.Text - набор с клавиатуры

        string action; // переменная действия
        string number1; //первое число, с которым работаем
        private void button22_Click(object sender, EventArgs e) // кнопки + - * / % Mod Exp xⁿ
        {
            label2.Text = textBox1.Text; // кнопка показа предыдущего значения
            if (textBox1.Text == "0" || textBox1.Text == "") //набор отрицательных чисел с клавиатуры
            {
                textBox1.Text = "-";
            }
            else
            {
                Button b = (Button)sender; // получение кнопки для нажимания
                action = b.Text;
                number1 = textBox1.Text; //запоминает, что было набрано
                textBox1.Text = ""; //обнуляет поле ввода
            }
        }

        private void button26_Click(object sender, EventArgs e) // кнопка =
        {
            if (action == "+") //проверяет +, делает сложение
                textBox1.Text = (Convert.ToDouble(number1) + Convert.ToDouble(textBox1.Text)).ToString();
            if (action == "-") //проверяет -, делает вычитание
                textBox1.Text = (Convert.ToDouble(number1) - Convert.ToDouble(textBox1.Text)).ToString();
            if (action == "Х") //проверяет Х, делает умножение
                textBox1.Text = (Convert.ToDouble(number1) * Convert.ToDouble(textBox1.Text)).ToString();
            if (action == "÷") //проверяет ÷, делает деление
                textBox1.Text = (Convert.ToDouble(number1) / Convert.ToDouble(textBox1.Text)).ToString();
            if (action == "%") //проверяет %, делает процент
                textBox1.Text = (Convert.ToDouble(number1) * Convert.ToDouble(textBox1.Text) / 100).ToString();
            if (action == "Mod") //проверяет Mod, показывает остаток от деления
                textBox1.Text = (Convert.ToDouble(number1) % Convert.ToDouble(textBox1.Text)).ToString();
            if (action == "Exp") //проверяет Exp, считает экспоненту
                textBox1.Text = Math.Exp(Math.Log(Convert.ToDouble(number1) * 4) * Convert.ToDouble(textBox1.Text)).ToString();
            if (action == "xⁿ") //проверяет xⁿ, показывает результат возведения в степень
                textBox1.Text = Math.Pow(Convert.ToDouble(number1), Convert.ToDouble(textBox1.Text)).ToString();
            action = "";
        }

        private void button6_Click(object sender, EventArgs e) // кнопка <
        {
            label2.Text = "";
            if (textBox1.Text.Length - 1 == 0) // ставит 0 в конце
                textBox1.Text = "0";
            else
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1); //удаление последнего символа
        }

        private void button5_Click(object sender, EventArgs e) // кнопка C
        {
            label2.Text = "";
            textBox1.Text = "0";
        }

        private void button7_Click(object sender, EventArgs e) // кнопка ¹/x
        {
            label2.Text = textBox1.Text; // кнопка показа предыдущего значения
            string temp = textBox1.Text; // временная переменная
            textBox1.Text = (1 / Convert.ToDouble(textBox1.Text)).ToString();
            label2.Text = "1/" + temp; // показ уравнения в верхнем окошке
        }

        private void button8_Click(object sender, EventArgs e) // кнопка x²
        {
            label2.Text = textBox1.Text;
            string temp = textBox1.Text;
            textBox1.Text = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text)).ToString();
            label2.Text = temp + "²";
        }

        private void button9_Click(object sender, EventArgs e) // кнопка √x
        {
            label2.Text = textBox1.Text;
            string temp = textBox1.Text;
            textBox1.Text = (Math.Sqrt(Convert.ToDouble(textBox1.Text))).ToString();
            label2.Text = "√" + temp;
        }

        private void button23_Click(object sender, EventArgs e) // кнопка +/-
        {
            label2.Text = textBox1.Text;
            textBox1.Text = (-Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void обычныйToolStripMenuItem_Click(object sender, EventArgs e) // переход из инженерного в обычный
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            Hide();
        }

        private void button42_Click(object sender, EventArgs e) // кнопка Mod
        {
            label2.Text = textBox1.Text; // кнопка показа предыдущего значения
            action = "Mod";
            number1 = textBox1.Text;
            textBox1.Text = "";
        }

        private void button39_Click(object sender, EventArgs e) // кнопка Exp
        {
            label2.Text = textBox1.Text; 
            action = "Exp";
            number1 = textBox1.Text;
            textBox1.Text = "";
        }

        private void button34_Click(object sender, EventArgs e) // кнопка π
        {
            textBox1.Text = "3.1415926535897932";
        }

        private void button2_Click(object sender, EventArgs e) // кнопка Log
        {
            label2.Text = textBox1.Text;
            double qlog10 = Math.Log10(Convert.ToDouble(textBox1.Text));
            textBox1.Text = System.Convert.ToString(qlog10);
        }

        private void button32_Click(object sender, EventArgs e) // кнопка Sin
        {
            label2.Text = textBox1.Text;
            double qsin = Math.Sin(Convert.ToDouble(textBox1.Text));
            textBox1.Text = System.Convert.ToString(qsin);
        }

        private void button33_Click(object sender, EventArgs e) // кнопка Cos
        {
            label2.Text = textBox1.Text;
            double qcos = Math.Cos(Convert.ToDouble(textBox1.Text));
            textBox1.Text = System.Convert.ToString(qcos);
        }

        private void button29_Click(object sender, EventArgs e) // кнопка Tan
        {
            label2.Text = textBox1.Text;
            double qtan = Math.Tan(Convert.ToDouble(textBox1.Text));
            textBox1.Text = System.Convert.ToString(qtan);
        }

        private void button30_Click(object sender, EventArgs e) // кнопка Ctg
        {
            label2.Text = textBox1.Text;
            double qctg = Math.Cos(Convert.ToDouble(textBox1.Text)) / Math.Sin(Convert.ToDouble(textBox1.Text));
            textBox1.Text = System.Convert.ToString(qctg);
        }

        private void button28_Click(object sender, EventArgs e) // кнопка Bin 2ичная с.с.
        {
            label2.Text = textBox1.Text;
            textBox1.Text = System.Convert.ToString(int.Parse(textBox1.Text), 2); 
        }

        private void button36_Click(object sender, EventArgs e) // кнопка Oct 8ричная
        {
            label2.Text = textBox1.Text;
            textBox1.Text = System.Convert.ToString(int.Parse(textBox1.Text), 8);
        }

        private void button35_Click(object sender, EventArgs e) // кнопка Hex 16ричная
        {
            label2.Text = textBox1.Text;
            textBox1.Text = System.Convert.ToString(int.Parse(textBox1.Text), 16);
        }

        private void button31_Click(object sender, EventArgs e) // кнопка Dec 10тичная
        {
            label2.Text = textBox1.Text;
            textBox1.Text = System.Convert.ToString(int.Parse(textBox1.Text));
        }

        private void button38_Click(object sender, EventArgs e) // кнопка x³
        {
            label2.Text = textBox1.Text;
            string temp = textBox1.Text;
            textBox1.Text = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text)).ToString();
            label2.Text = temp + "³";
        }

        private void button27_Click(object sender, EventArgs e) // кнопка Ln X
        {
            label2.Text = textBox1.Text;
            double qlog = Math.Log(Convert.ToDouble(textBox1.Text));
            textBox1.Text = System.Convert.ToString(qlog);
        }

        private void button37_Click(object sender, EventArgs e) // кнопка e
        {
            textBox1.Text = "2.7182818284590452";
        }

        private void button1_Click(object sender, EventArgs e) // кнопка xⁿ
        {
            label2.Text = textBox1.Text;
            action = "xⁿ";
            number1 = textBox1.Text;
            textBox1.Text = "";
        }

        private void button40_Click(object sender, EventArgs e) // кнопка 2ⁿ
        {
            label2.Text = textBox1.Text;
            string temp = textBox1.Text;
            textBox1.Text = Math.Pow(2, Convert.ToDouble(textBox1.Text)).ToString();
            label2.Text = "2^" + temp;
        }

        private void button4_Click(object sender, EventArgs e) // кнопка |x|
        {
            label2.Text = textBox1.Text;
            string temp = textBox1.Text;
            textBox1.Text = Math.Abs(Convert.ToDouble(textBox1.Text)).ToString();
            label2.Text = "|" + temp + "|";
        }

        private void button41_Click(object sender, EventArgs e) // кнопка n!
        {
            label2.Text = textBox1.Text;
            string temp = textBox1.Text;
            if (Convert.ToDouble(textBox1.Text) > 31)
            {
                textBox1.Text = "long int";
            }
            else 
            {
                double n = Convert.ToDouble(textBox1.Text);  // количество циклов в факториале
                int factorial = 1;   // значение факториала
                for (int i = 2; i <= n; i++) // цикл начинает с 2, т.к. нет смысла начинать с 1
                {
                    factorial = factorial * i;
                }
                textBox1.Text = factorial.ToString();
            }
            label2.Text = temp + "!";
        }
    }
}
