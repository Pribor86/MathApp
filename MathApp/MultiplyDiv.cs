using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    class MultiplyDiv
    {
        Random rnd = new Random();
        int a, b, c;
        int multi_div;

        public MultiplyDiv()
        {

            int answer;
            multi_div = rnd.Next(2, 3);
            switch (multi_div)
            {
                case 1:
                    {
                        a = rnd.Next(1, 11);
                        b = rnd.Next(1, 11);
                        answer = a * b;
                    }
                    break;
                case 2:
                    {
                        a = rnd.Next(1, 101);
                        b = rnd.Next(1, 11);
                        bool flag = false;
                        while (!flag)
                        {
                            
                            if(a % b != 0)
                            {
                                a = rnd.Next(1, 101);
                                b = rnd.Next(1, 11);
                            }
                            else
                            {
                                flag = true;
                            }
                        }

                        
                    }
                    break;
            }

            
        }

        public override string ToString()
        {
            return string.Format("MultiPlyDiv\na = {0}, b = {1}, multi_div = {2}", a, b, multi_div);
        }
    }
}






       