using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capacitaciones
{
    public class BasicDelegate
    {
        public delegate int MathOperation(int a, int b);

        public void Main()
        {
            //Part 1: Basic Delegate Usage
            MathOperation op = new MathOperation(Add);
            int addResult = op(4, 5);
            Console.WriteLine("Addition: " + addResult);

            op = new MathOperation(Subtract);
            int subtraction = op(6, 4);
            Console.WriteLine("Subtraction: " + subtraction);

            //Part 2: Multicast Delegate
            MathOperation op2 = Subtract;
            op2 += Add;

            int finalresult = op2(10, 5);
            Console.WriteLine("Final Result: " + finalresult);
        }

        public int Add(int a, int b)
        { 
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

    }
}
