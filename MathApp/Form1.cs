using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathApp
{
    public partial class Form1 : Form
    {

        
        public int operationMark, a , b, countAnswers, countMistakes;
        int x, y;
        bool summDiff = false;
        bool multiDiv = false;
        char sep =
            System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator[0];

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.AntiqueWhite;
            this.Opacity = 0.95;
            Random rnd = new Random();
            
            
            
            
            menuStrip1.BackColor = Color.AntiqueWhite;
            TaskNumbers();
            label1.Visible = false;
            //timer1.Start();
            
            try
            {
                this.Icon = new Icon(this.GetType(), "AppIcon.ico");
            }
            catch { }
            
        }

        public void Debugging()
        {
            
            if (summDiff && operationMark == 1)
            {
                
                lable_A.Text = Convert.ToString(a);
                lable_B.Text = Convert.ToString(b);
                int tempAnswer = a + b;
                lable_Answer_Debbug.Text = Convert.ToString(tempAnswer);
                Debug.WriteLine("{0} + {1} = {2}", a, b, tempAnswer);
            }
            else if(summDiff && operationMark == 2)
            {
                if (a >= b)
                {
                    
                    lable_A.Text = Convert.ToString(a);
                    lable_B.Text = Convert.ToString(b);
                    int tempAnswer = a - b;
                    lable_Answer_Debbug.Text = Convert.ToString(tempAnswer);
                    Debug.WriteLine("{0} - {1} = {2}", a, b, tempAnswer);
                }
                else if(a < b)
                {
                    
                    lable_A.Text = Convert.ToString(b);
                    lable_B.Text = Convert.ToString(a);
                    int tempAnswer = b - a;
                    lable_Answer_Debbug.Text = Convert.ToString(tempAnswer);
                    Debug.WriteLine("{0} - {1} = {2}", b, a, tempAnswer);
                }
            }
            else if(multiDiv && operationMark == 1)
            {
                int tempAnswer = a * b;
                lable_A.Text = Convert.ToString(a);
                lable_B.Text = Convert.ToString(b);
                lable_Answer_Debbug.Text = Convert.ToString(tempAnswer);
                Debug.WriteLine("{0} * {1} = {2}", a, b, tempAnswer);
            }
            else if(multiDiv && operationMark == 2)
            {
                int tempA = a * b;
                lable_A.Text = Convert.ToString(tempA);
                lable_B.Text = Convert.ToString(a);
                lable_Answer_Debbug.Text = Convert.ToString(b);
                Debug.WriteLine("{0} / {1} = {2}", tempA, a, b);
            }
        }

        //Генерирует рандомно цифры и знаки +/-
        private void TaskNumbers()
        {
            if (summDiff && !multiDiv)
            {
                
                int answer;
                bool answerChecker = int.TryParse(textBox_Answer.Text, out answer);
                Random rnd = new Random();
                a = rnd.Next(1, x);
                b = rnd.Next(1, y);
                operationMark = rnd.Next(1, 3);
                Debugging();

                switch (operationMark)
                {
                    case 1:
                        {
                            this.label_Number1.Text = Convert.ToString(a);
                            this.label_Znak.Text = "+";
                            this.label_Number2.Text = Convert.ToString(b);

                        }
                        break;
                    case 2:
                        {
                            if (a >= b)
                            {
                                this.label_Number1.Text = Convert.ToString(a);
                                this.label_Znak.Text = "-";
                                this.label_Number2.Text = Convert.ToString(b);

                            }
                            else
                            {
                                this.label_Number1.Text = Convert.ToString(b);
                                this.label_Znak.Text = "-";
                                this.label_Number2.Text = Convert.ToString(a);

                            }
                        }
                        break;
                }
            }
            else if(multiDiv && !summDiff)
            {
                int answer;
                bool answerChecker = int.TryParse(textBox_Answer.Text, out answer);
                Random rnd = new Random();
                a = rnd.Next(1, x);
                b = rnd.Next(1, y);
                operationMark = rnd.Next(1, 3);
                Debugging();
                switch (operationMark)
                {
                    case 1:
                        {
                            this.label_Number1.Text = Convert.ToString(a);
                            this.label_Znak.Text = "*";
                            this.label_Number2.Text = Convert.ToString(b);

                        }
                        break;
                    case 2:
                        {
                            int tempA = a * b;
                            this.label_Number1.Text = Convert.ToString(tempA);
                            this.label_Znak.Text = "/";
                            this.label_Number2.Text = Convert.ToString(a);
                            //answer = b;

                           
                        }
                        break;
                }
            
            }

        }


        //Проверка ответа
        private bool CheckAnswer(int answer)
        {
            if (summDiff && !multiDiv)
            {
                bool result = false;
                switch (operationMark)
                {
                    case 1:
                        {

                            if (answer == (a + b))
                            {
                                this.label_Check_Answer.Text = "Ответ: " +
                                    Convert.ToString(answer);
                                countAnswers++;
                                result = true;
                            }
                            else
                            {
                                this.label_Check_Answer.Text = "Ответ: " +
                                    Convert.ToString(textBox_Answer.Text) +
                                    " неправельный!";
                                countMistakes++;
                            }
                        }
                        break;
                    case 2:
                        {
                            if (a > b)
                            {

                                if (answer == (a - b))
                                {
                                    this.label_Check_Answer.Text = "Ответ: " +
                                        Convert.ToString(answer);
                                    countAnswers++;
                                    result = true;
                                }
                                else
                                {
                                    this.label_Check_Answer.Text = "Ответ: " +
                                        Convert.ToString(textBox_Answer.Text) +
                                        " неправельный!";
                                    countMistakes++;
                                }
                            }
                            else
                            {

                                if (answer == (b - a))
                                {
                                    this.label_Check_Answer.Text = "Ответ: "
                                        + Convert.ToString(answer);
                                    countAnswers++;
                                    result = true;
                                }
                                else
                                {
                                    this.label_Check_Answer.Text = "Ответ: " +
                                        Convert.ToString(textBox_Answer.Text) +
                                        " неправельный!";
                                    countMistakes++;
                                }
                            }
                        }
                        break;
                }
                return result;
            }
            else
            {
                bool result = false;
                switch (operationMark)
                {
                    case 1:
                        {

                            if (answer == (a * b))
                            {
                                this.label_Check_Answer.Text = "Ответ: " +
                                    Convert.ToString(answer);
                                countAnswers++;
                                result = true;
                            }
                            else
                            {
                                this.label_Check_Answer.Text = "Ответ: " +
                                    Convert.ToString(textBox_Answer.Text) +
                                    " неправельный!";
                                countMistakes++;
                            }
                        }
                        break;
                    case 2:
                        {
                            int tempA = a * b;
                            
                            if (answer == (tempA / a))
                            {
                                this.label_Check_Answer.Text = "Ответ: " +
                                    Convert.ToString(answer);
                                countAnswers++;
                                result = true;
                            }
                            else
                            {
                                this.label_Check_Answer.Text = "Ответ: " +
                                    Convert.ToString(textBox_Answer.Text) +
                                    " неправельный!";
                                countMistakes++;
                            }
                        }
                        break;
                }
                return result;
            }
           
        }

        //Использование кнопки "Проверка"
        private void CheckButtonPress()
        {
            if (int.TryParse(textBox_Answer.Text, out int answer))
            {
                if (CheckAnswer(answer))
                {
                    TaskNumbers();
                    this.textBox_Answer.Text = string.Empty;
                    this.label_Answer.Text = Convert.ToString(countAnswers);
                    this.label_Mistake.Text = Convert.ToString(countMistakes);
                }
                else
                {
                    TaskNumbers();
                    this.textBox_Answer.Text = string.Empty;
                    this.label_Answer.Text = Convert.ToString(countAnswers);
                    this.label_Mistake.Text = Convert.ToString(countMistakes);
                }
                Invalidate();
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Answer_Click(object sender, EventArgs e)
        {

        }

        

        //Используем "Enter" для проверки из чекбокса
        private void textBox_Answer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == (char)Keys.Enter;
            char ch = e.KeyChar;

            if (ch == '.' || ch == ',')
                e.KeyChar = ch = sep;

            // кон троль правильности вводимых данных

            if (!Char.IsDigit(ch) && !(ch == 8) &&
                (ch != sep || ((TextBox)sender).Text.IndexOf(sep) != -1 || ((TextBox)sender).Text.Length == 0) &&
                (ch != '-' || ((TextBox)sender).Text.Length > 0)

              )
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                CheckButtonPress();
            }
            if (e.KeyChar == 27)
            {
                ((TextBox)sender).Text = "";
            }
            
        }

        

        //Закрыть программу
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void multiToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        //Сложение/вычетание от 1 до 10
        private void toolStripMenuItem_1_10_Click(object sender, EventArgs e)
        {
            toolStripMenuItem_1_10.CheckOnClick = true;
            toolStripMenuItem_1_10.Checked = true;
            toolStripMenuItem_1_100.Checked = false;
            toolStripMenuItem_1_1000.Checked = false;
            toolStripMenuItem_1_10_Multiply.Checked = false;
            toolStripMenuItem_1_100_Multiply.Checked = false;
            toolStripMenuItem_1_1000_Multiply.Checked = false;
            label1.Visible = true;
            label3.Visible = false;
            multiDiv = false;
            summDiff = true;
            textBox_Answer.Focus();
            x = 10;
            y = 10;
            TaskNumbers();
            //Debugging();
            Invalidate();


        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

            toolStripMenuItem_1_10.Checked = false;
            toolStripMenuItem_1_100.Checked = true;
            toolStripMenuItem_1_100.CheckOnClick = true;
            toolStripMenuItem_1_1000.Checked = false;
            toolStripMenuItem_1_10_Multiply.Checked = false;
            toolStripMenuItem_1_100_Multiply.Checked = false;
            toolStripMenuItem_1_1000_Multiply.Checked = false;
            label1.Visible = true;
            label3.Visible = false;
            multiDiv = false;
            summDiff = true;
            textBox_Answer.Focus();
            x = 100;
            y = 100;
            TaskNumbers();
            //Debugging();
            Invalidate();
        }
        private void toolStripMenuItem_1_1000_Click(object sender, EventArgs e)
        {

            toolStripMenuItem_1_10.Checked = false;
            toolStripMenuItem_1_100.Checked = false;
            toolStripMenuItem_1_1000.Checked = true;
            toolStripMenuItem_1_1000.CheckOnClick = true;
            toolStripMenuItem_1_10_Multiply.Checked = false;
            toolStripMenuItem_1_100_Multiply.Checked = false;
            toolStripMenuItem_1_1000_Multiply.Checked = false;
            multiDiv = false;
            summDiff = true;
            label1.Visible = true;
            label3.Visible = false;
            textBox_Answer.Focus();
            x = 1000;
            y = 1000;
            TaskNumbers();
            //Debugging();
            Invalidate();
        }
        //end
        // умножение/деление от 1 до 10
        private void toolStripMenuItem_1_10_Multiply_Click(object sender, EventArgs e)
        {
            toolStripMenuItem_1_100_Multiply.CheckOnClick = true;
            toolStripMenuItem_1_10_Multiply.Checked = true;
            toolStripMenuItem_1_100_Multiply.Checked = false;
            toolStripMenuItem_1_1000_Multiply.Checked = false;
           
            toolStripMenuItem_1_10.Checked = false;
            toolStripMenuItem_1_100.Checked = false;
            toolStripMenuItem_1_1000.Checked = false;
            label1.Visible = true;
            label3.Visible = false;
            multiDiv = true;
            summDiff = false;
            x = 10;
            y = 10;
            TaskNumbers();
            //Debugging();
            textBox_Answer.Select();
            Invalidate();
        }

        private void toolStripMenuItem_1_100_Multiply_Click(object sender, EventArgs e)
        {
            
            toolStripMenuItem_1_10.Checked = false;
            toolStripMenuItem_1_100.Checked = false;
            toolStripMenuItem_1_1000.Checked = false;
            toolStripMenuItem_1_10_Multiply.Checked = false;
            toolStripMenuItem_1_100_Multiply.Checked = true;
            toolStripMenuItem_1_100_Multiply.CheckOnClick = true;
            toolStripMenuItem_1_1000_Multiply.Checked = false;
            label1.Visible = true;
            label3.Visible = false;
            multiDiv = true;
            summDiff = false;
            textBox_Answer.Focus();
            x = 10;
            y = 100;
            TaskNumbers();
            //Debugging();
            Invalidate();
        }

        private void toolStripMenuItem_1_1000_Multiply_Click(object sender, EventArgs e)
        {
            toolStripMenuItem_1_10.Checked = false;
            toolStripMenuItem_1_100.Checked = false;
            toolStripMenuItem_1_1000.Checked = false;
            toolStripMenuItem_1_10_Multiply.Checked = false;
            toolStripMenuItem_1_100_Multiply.Checked = false;
            toolStripMenuItem_1_1000_Multiply.CheckOnClick = true;
            toolStripMenuItem_1_1000_Multiply.Checked = true;
            multiDiv = true;
            summDiff = false;
            label1.Visible = true;
            label3.Visible = false;
            textBox_Answer.Focus();
            x = 10;
            y = 1000;
            TaskNumbers();
            //Debugging();
            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        


        //end
        private void lable_Answer_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void button_Сheck_Click_1(object sender, EventArgs e)
        {
            CheckButtonPress();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show(this.Text + "\x00A9 2021 by Alex.", "About" + this.Text);
        }

    }
}
