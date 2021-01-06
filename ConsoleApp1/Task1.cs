using System;
using System.Text;
delegate void DelegateTask1();
namespace ConsoleApp1
{
    class Task1
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            DelegateTask1 deleg;
            Console.WriteLine("Введіть номер функції, яку хочете використати(1-5):");
            int a = int.Parse(Console.ReadLine());
            switch (a)//табулювання функції, вибраної користувачем
            {
                case 1: deleg = DopClass.Func1; break;
                case 2: deleg = DopClass.Func2; break;
                case 3: deleg = DopClass.Func3; break;
                case 4: deleg = DopClass.Func4; break;
                case 5: deleg = DopClass.Func5; break;
                default: deleg = DopClass.Func6; break;
            }
            deleg();
        }
    }
    public class DopClass
    {
        public static void Func1()
        {
            for (double i = -100000; i <= 10000; i += 0.015)
            {
                Console.WriteLine($"Число: {i} Результат: {4 * i * i * i - 7 * i * i + 1}");
            }
        }
        public static void Func2()
        {
            for (double i = -10000; i <= 10000; i += 0.01)
            {
                Console.WriteLine($"Число: {i} Результат: {Math.Sqrt(6 * i * i - 1)}");
            }
        }
        public static void Func3()
        {
            for (double i = -250; i <= 400; i += 0.001)
            {
                Console.WriteLine($"Число: {i} Результат: {4 * i * i * i - 7 * i * i + 1}");
            }
        }
        public static void Func4()
        {
            for (double i = -100000; i <= 10000; i += 0.1)
            {
                Console.WriteLine($"Число: {i} Результат: {0.5 * Math.Pow(i, 3 + i) + 0.1 * i}");
            }
        }
        public static void Func5()
        {
            for (double i = -20000; i <= 20000; i += 0.01)
            {
                Console.WriteLine($"Число: {i} Результат: {Math.Abs(i * i - 5) / (i - 5)}");
            }
        }
        public static void Func6()
        {
            Console.WriteLine("Ви ввели некоректне значення");
        }
    }
}
