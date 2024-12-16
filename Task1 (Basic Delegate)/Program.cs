using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1__Basic_Delegate_
{
    delegate int MathOperation(int a, int b);

    internal class Program
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            MathOperation Add = new MathOperation(Addition);
            Console.Write("Addition:");
            Console.WriteLine(Add(8,45));
            Console.Write("Subtraction:");
            MathOperation Sub = new MathOperation(Subtract);
            Console.WriteLine(Sub(50,9));
            Console.Write("Multiply:");
            MathOperation Multi = new MathOperation(Multiply);
            Console.WriteLine(Multi(6,3));
            MathOperation Div = new MathOperation(Divide);
            Console.Write("Divide:");
            Console.WriteLine(Div(9,2));
            
            
            
            Console.ReadLine();
           
        }
    }
}
