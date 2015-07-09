using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            double number;
            while (!Double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Введено некорректное число. Повторите ввод");
            }

            Console.WriteLine("Введите степень корня");
            int degreeRoot;
            while (!int.TryParse(Console.ReadLine(), out degreeRoot) || degreeRoot < 1)
            {
                Console.WriteLine("Введено некорректный показатель степени корня. Повторите ввод");
            }

            Console.WriteLine("Введите требуемую точность");
            double precision;
            while (!Double.TryParse(Console.ReadLine(), out precision))
            {
                Console.WriteLine("Введено некорректное число. Повторите ввод");
            }

            Console.WriteLine("Корень {0}-й стеени из числа {1}, вычисленный с точностью до {2}", degreeRoot, number, precision);
            Console.WriteLine(Task1.Math.NthRoot(number, degreeRoot, precision));
            Console.WriteLine("Корень {0}-й стеени из числа {1}, вычисленный методом Math.Pow", degreeRoot, number);
            Console.WriteLine(System.Math.Pow(number, 1.0 / degreeRoot));
        }
    }
}
