using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyClass
    {
        
        public int AddIntegers(int a, int b)
        {
            return a + b;
        }

        
        private double AddDoubles(double a, double b)
        {
            return a + b;
        }

        public static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            int sumInt = myClass.AddIntegers(5, 3); 
            Console.WriteLine("Сумма целых чисел: " + sumInt);

            double sumDouble = myClass.AddDoubles(5.5, 3.2); 
            Console.WriteLine("Сумма вещественных чисел: " + sumDouble);
        }
    }
}
