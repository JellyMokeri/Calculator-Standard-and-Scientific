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
    public partial class Form1 : Form
    {
        public Form1() // создание окна
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) // подгон размера кнопок под растягивание окна калькулятора
        {
            this.MinimumSize=new Size(280, 485); // устанавливает минимальный размер формы
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
            button3.Height = panel3.Height / 6; // высота всех кнопок подстраивается под изменение окна
            button4.Height = panel3.Height / 6;
            button5.Height = panel3.Height / 6;
            button6.Height = panel3.Height / 6;
            button7.Height = panel3.Height / 6;
            button8.Height = panel3.Height / 6;
            button9.Height = panel3.Height / 6;
            button10.Height = panel3.Height / 6;
            button11.Height = panel3.Height / 6;
            button12.Height = panel3.Height / 6;
            button13.Height = panel3.Height / 6;
            button14.Height = panel3.Height / 6;
            button15.Height = panel3.Height / 6;
            button16.Height = panel3.Height / 6;
            button17.Height = panel3.Height / 6;
            button18.Height = panel3.Height / 6;
            button19.Height = panel3.Height / 6;
            button20.Height = panel3.Height / 6;
            button21.Height = panel3.Height / 6;
            button22.Height = panel3.Height / 6;
            button23.Height = panel3.Height / 6;
            button24.Height = panel3.Height / 6;
            button25.Height = panel3.Height / 6;
            button26.Height = panel3.Height / 6;

            button3.Width = panel3.Width / 4; // ширина всех кнопок подстраивается под изменение окна
            button4.Width = panel3.Width / 4;
            button5.Width = panel3.Width / 4;
            button6.Width = panel3.Width / 4;
            button7.Width = panel3.Width / 4;
            button8.Width = panel3.Width / 4;
            button9.Width = panel3.Width / 4;
            button10.Width = panel3.Width / 4;
            button11.Width = panel3.Width / 4;
            button12.Width = panel3.Width / 4;
            button13.Width = panel3.Width / 4;
            button14.Width = panel3.Width / 4;
            button15.Width = panel3.Width / 4;
            button16.Width = panel3.Width / 4;
            button17.Width = panel3.Width / 4;
            button18.Width = panel3.Width / 4;
            button19.Width = panel3.Width / 4;
            button20.Width = panel3.Width / 4;
            button21.Width = panel3.Width / 4;
            button22.Width = panel3.Width / 4;
            button23.Width = panel3.Width / 4;
            button24.Width = panel3.Width / 4;
            button25.Width = panel3.Width / 4;
            button26.Width = panel3.Width / 4;

            button3.Top = 0; // отступ сверху всех кнопок подстраивается под изменение окна
            button4.Top = 0;
            button5.Top = 0;
            button6.Top = 0;

            button7.Top = panel3.Height / 6;
            button8.Top = panel3.Height / 6;
            button9.Top = panel3.Height / 6;
            button10.Top = panel3.Height / 6;

            button11.Top = panel3.Height * 2 / 6;
            button12.Top = panel3.Height * 2 / 6;
            button13.Top = panel3.Height * 2 / 6;
            button14.Top = panel3.Height * 2 / 6;

            button15.Top = panel3.Height * 3 / 6;
            button16.Top = panel3.Height * 3 / 6;
            button17.Top = panel3.Height * 3 / 6;
            button18.Top = panel3.Height * 3 / 6;

            button19.Top = panel3.Height * 4 / 6;
            button20.Top = panel3.Height * 4 / 6;
            button21.Top = panel3.Height * 4 / 6;
            button22.Top = panel3.Height * 4 / 6;

            button23.Top = panel3.Height * 5 / 6;
            button24.Top = panel3.Height * 5 / 6;
            button25.Top = panel3.Height * 5 / 6;
            button26.Top = panel3.Height * 5 / 6;

            button3.Left = 0; // отступ слева всех кнопок подстраивается под изменение окна
            button7.Left = 0;
            button11.Left = 0;
            button15.Left = 0;
            button19.Left = 0;
            button23.Left = 0;

            button4.Left = panel3.Width / 4; 
            button8.Left = panel3.Width / 4;
            button12.Left = panel3.Width / 4;
            button16.Left = panel3.Width / 4;
            button20.Left = panel3.Width / 4;
            button24.Left = panel3.Width / 4;

            button5.Left = panel3.Width / 2; 
            button9.Left = panel3.Width / 2;
            button13.Left = panel3.Width / 2;
            button17.Left = panel3.Width / 2;
            button21.Left = panel3.Width / 2;
            button25.Left = panel3.Width / 2;

            button6.Left = panel3.Width * 3 / 4; 
            button10.Left = panel3.Width * 3 / 4;
            button14.Left = panel3.Width * 3 / 4;
            button18.Left = panel3.Width * 3 / 4;
            button22.Left = panel3.Width * 3 / 4;
            button26.Left = panel3.Width * 3 / 4;

        }

        private void Form1_Click(object sender, EventArgs e) // набор цифр и точки
        {
            label2.Text = ""; // обнуление кнопки предыдущего значения
            Button b = (Button)sender; // получение кнопки для нажимания
            if (textBox1.Text == "0" || textBox1.Text == "∞") // убирание значение нуля
            {
                textBox1.Text = "";
            }

            if (textBox1.Text.IndexOf(".") > 0 && b.Text == ".") // если уже нажата точка, то не нажимает снова
            {
                return; // ничего не набирает
            }
            textBox1.Text = textBox1.Text + b.Text; // отправление информации на кнопку
        }
        // textBox1.Text - то, что видно на калькуляторе
        // b.Text - набор с клавиатуры

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

        private void button4_Click(object sender, EventArgs e) // кнопка xⁿ
        {
            label2.Text = textBox1.Text;
            action = "xⁿ";
            number1 = textBox1.Text;
            textBox1.Text = "";
        }

        string action; // переменная действия
        string number1; //первое число, с которым работаем
        private void button22_Click(object sender, EventArgs e) // кнопки + - * /
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
            if (action == "%") // делает процент
                textBox1.Text = (Convert.ToDouble(number1) * Convert.ToDouble(textBox1.Text) / 100).ToString();
            if (action == "xⁿ") //проверяет xⁿ, показывает результат возведения в степень
                textBox1.Text = Math.Pow(Convert.ToDouble(number1), Convert.ToDouble(textBox1.Text)).ToString();
            action = "";
        }

        private void button7_Click(object sender, EventArgs e) // кнопка ¹/x
        {
            label2.Text = textBox1.Text; // кнопка показа предыдущего значения
            textBox1.Text = (1 / Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void button8_Click(object sender, EventArgs e) // кнопка x²
        {
            label2.Text = textBox1.Text;
            textBox1.Text = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void button9_Click(object sender, EventArgs e) // кнопка √x
        {
            label2.Text = textBox1.Text;
            textBox1.Text = (Math.Sqrt(Convert.ToDouble(textBox1.Text))).ToString();
        }

        private void button23_Click(object sender, EventArgs e) // кнопка +/-
        {
            label2.Text = textBox1.Text;
            textBox1.Text = (-Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e) // кнопка %
        {
            label2.Text = textBox1.Text; // кнопка показа предыдущего значения
            action = "%";
            number1 = textBox1.Text;
            textBox1.Text = "";
        }

        private void инженерныйToolStripMenuItem_Click(object sender, EventArgs e) // переход из обычного в инженерный
        {
            Form2 fr2 = new Form2();
            fr2.Show();
            Hide();
        }
    }
}
