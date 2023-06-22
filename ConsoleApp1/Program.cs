using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degree = 2;
            Console.WriteLine("Квадрат до 10 ");
            for (int number = 1; number <= 10; number++)
            {
                double new_number = Math.Pow(number, degree);
                int _number = Convert.ToInt32(new_number);
                Console.WriteLine($"Квадрат равен = {_number}");
            }

        }
    }
}
