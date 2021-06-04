using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    class RandomNumbers
    {
        
        //int a, b, c, d;
        int firstNumb, secondNumb, actionOperator;

        public int FirstNumb { get => firstNumb; }
        public int SecondNumb { get => secondNumb; }
        public int ActionOperator { get => actionOperator; }

        

        //generates two random numbers
        
        public RandomNumbers(int a, int b, int c)
        {
            Random rnd = new Random();
            this.firstNumb = rnd.Next(1, a);
            this.secondNumb = rnd.Next(1, b);
            this.actionOperator = c;
        }

        public void NewNumbers(int a, int b, int c)
        {
            new RandomNumbers(10, 10, 1);
        }
        

        public override string ToString()
        {
            return string.Format("firstNumb = {0}, secondNumb = {1}, actionOperator = {2}",
                firstNumb, secondNumb, actionOperator);
        }
    }
}
