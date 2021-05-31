using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathApp
{
    public partial class Form1 : Form
    {
        public int summRaznica, a , b, countAnswers, countMistakes;
        
        public Form1()
        {
            

            this.BackColor = Color.AntiqueWhite;
            this.Opacity = 0.95;
            Random rnd = new Random();
            summRaznica = rnd.Next(1, 3);
            InitializeComponent();
            TaskNumbers();
            textBox_Answer.Focus();
            menuStrip1.BackColor = Color.AntiqueWhite;
            MultiplyDiv multiplyDiv = new MultiplyDiv();
            this.CheckMultiDiv.Text = multiplyDiv.ToString();

            try
            {
                this.Icon = new Icon(this.GetType(), "AppIcon.ico");
            }
            catch { }


        }

        //Генерирует рандомно цифры и знаки +/-
        private void TaskNumbers()
        {

            int answer;
            bool answerChecker = int.TryParse(textBox_Answer.Text, out answer);
            Random rnd = new Random();
            a = rnd.Next(1, 10);
            b = rnd.Next(1, 10);
            summRaznica = rnd.Next(1, 3);

            switch (summRaznica)
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
                        if (a > b)
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

        //Проверка ответа
        private bool CheckAnswer(int answer)
        {
            bool result = false;
            switch (summRaznica)
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

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        //Используем "Enter" для проверки из чекбокса
        private void textBox_Answer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CheckButtonPress();
            }
            if (e.KeyChar == 27)
            {
                ((TextBox)sender).Text = "";
            }
        }

        private void toolStripMenuItem_1_10_Click(object sender, EventArgs e)
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
