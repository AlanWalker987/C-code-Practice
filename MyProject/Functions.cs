using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class Functions
    {
        public void sum()
        {
            int x = 10;
            int y = 20;
            int sum = x + y;
            Console.WriteLine($"Sum of {x} and {y} is " + sum);
        }

        public int sumoftwo()
        {
            int x = 50;
            int y = 25;
            int sum = x + y;
            return sum;
        }

        public int multiply(int x, int y)
        {
            return x * y;
        }
        public int multiply(int x, int y, int z)
        {
            return x * y * z;
        }
    }
}
