using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciDelegate
{
    class BarRepresentation
    {
        public delegate int DelegateHandler(int Hello);
        class Program
        {
            static void Main(string[] args)
            {
                DelegateHandler Delegate = new DelegateHandler(Fibonacci);
                int number;
                Console.WriteLine("Give the length of the sequence");
                number = int.Parse(Console.ReadLine());
                for (int i = 1; i <= number; i++)
                {
                    Console.Write(" " + Delegate(i));
                    Console.WriteLine(" " + (i * 100) / (number) + "%\n");
                    //Console.Write(" " + Fibonacci.Fib(i));
                    // Console.Write(" " + (i * 100) / (number) + "%\n");
                }
                Console.ReadKey();
            }
            public static int Fibonacci(int number)
            {
                if (number == 0 || number == 1)
                    return number;
                else
                    return (Fibonacci(number - 1) + Fibonacci(number - 2));
            }
        }

    }
}
