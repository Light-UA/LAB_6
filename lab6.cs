using System;

namespace StepenovyiRyad
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задаємо значення x
            double x = 1.3;

            // Ініціалізуємо суму S
            double s = 0;

            // Обчислюємо суму 20-ти членів степеневого ряду
            for (int n = 1; n <= 20; n++)
            {
                double power = 2 * n + 1;
                double term = Math.Pow(-1, power) * Math.Pow(x, power) / Math.Pow(Math.PI, power);
                s += term;
            }

            // Обчислюємо значення функції y1
            double y1 = Math.Atan(x);

            // Виводимо результат
            Console.WriteLine("Сума 20-ти членів степеневого ряду: {0}", s);
            Console.WriteLine("Значення функції y1: {0}", y1);

            Console.ReadKey();
        }
    }
}
