using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kiri11
{
    public partial class MainForm : Form
    {
        int ScaleValue = 30;                                                             // масштаб
        public delegate double function(double x);                                       // делегат на функцию
        static double f(double x) { return Math.Exp(Math.Sin(x)) + Math.Sin(x) - 2; }    // функция
        static double f1(double x) { return (Math.Exp(Math.Sin(x)) + 1) * Math.Cos(x); } // производная

        public MainForm()
        {
            InitializeComponent();
            RootTextBox.Text = FindTheX(0.000000000000001, 0, Math.PI/2);
            FuncCheckBox.Checked = true;
 //         DerivativeCheckBox.Checked = true;
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics ln = e.Graphics;
            
            // рисуем сетку и оси
            DrawGrid(ln);

            // рисуем графики, если включены соответсвующие чекбоксы
            if (FuncCheckBox.Checked)
                DrawGraph(ln, f, Color.Blue);
            if (DerivativeCheckBox.Checked)
                DrawGraph(ln, f1, Color.Red);
        }

        private void DrawGrid(Graphics ln)
        {
            int height = pictureBox.Height; // Высота
            int width = pictureBox.Width;   // Ширина

            // Рисуем оси
            Pen pen = new Pen(Color.Black, 2);
            ln.DrawLine(pen, 0, height / 2, width, height / 2);
            ln.DrawLine(pen, width / 2, 0, width / 2, height);
            ln.DrawLine(pen, width - 4, height / 2, width - 10, height / 2 - 10);
            ln.DrawLine(pen, width - 4, height / 2, width - 10, height / 2 + 10);
            ln.DrawLine(pen, width / 2, 0, width / 2 - 10, 10);
            ln.DrawLine(pen, width / 2, 0, width / 2 + 10, 10);
            Font font = new Font("Verdana", 15);
            ln.DrawString("X", font, Brushes.Red, width - 30, height / 2);
            ln.DrawString("Y", font, Brushes.Red, width / 2 + 10, 0);

            // Рисуем сетку
            pen = new Pen(Color.Black, 1);
            for (int i = -50; i < 50; i++)
            {
                ln.DrawLine(pen, 0, i * ScaleValue + height / 2, width, i * ScaleValue + height / 2);
                ln.DrawLine(pen, i * ScaleValue + width / 2, 0, i * ScaleValue + width / 2, height);
            }
        }

        // функция рисует график заданной функции function
        private void DrawGraph(Graphics ln, function f, Color color)
        {
            Point p1, p2;
            int Xpoint = 0, Ypoint = 0;
            int height = pictureBox.Height; // Высота
            int width = pictureBox.Width;   // Ширина
            string str;
            bool flag = true;

            for (double x = -10; x < 10; x += 0.06)
            {
                x = Math.Round(x, 1);
                str = f(x).ToString();
                if (str != "бесконечность" && str != "NaN" && str != "-бесконечность")
                {
                    if (flag)
                    {
                        double h = Math.Round(f(x));
                        int g = (int)(h);
                        Ypoint = (height / 2 - g * ScaleValue);
                        h = Math.Round(x);
                        g = (int)(h);
                        Xpoint = (width / 2 + g * ScaleValue);
                        flag = false;
                    }
                    p1 = new Point(Xpoint, Ypoint);
                    double y = -f(x);
                    Xpoint = (int)(x * ScaleValue + width / 2);
                    Ypoint = (int)(y * ScaleValue + height / 2);
                    p2 = new Point(Xpoint, Ypoint);
                    Pen pen = new Pen(color, 1);
                    ln.DrawLine(pen, p1, p2);
                }
                else flag = true;
            }
        }

        // функция нахождения x методом деления пополам
        private string FindTheX(double eps, double a, double b)
        {
            double x = (a + b)/2;
            while (Math.Abs(a - b) > eps)
            {
                if (f(a) * f(x) < 0)
                    b = x;
                else
                    a = x;
                x = (a + b) / 2;
            }
            return x.ToString();
        }

        private void GraphCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox.Refresh();
        }

        private void DerivativeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox.Refresh();
        }

        private void pictureBox_SizeChanged(object sender, EventArgs e)
        {
            pictureBox.Refresh();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ScaleIncreaseButton_Click(object sender, EventArgs e)
        {
            if (ScaleValue < 100)
                ScaleValue += 3;
            pictureBox.Refresh();
        }

        private void ScaleDecreaseButton_Click(object sender, EventArgs e)
        {
            if (ScaleValue > 10)
                ScaleValue -= 3;
            pictureBox.Refresh();
        }
    }
}
