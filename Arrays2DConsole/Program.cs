using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2DConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;


            Console.WriteLine("Лабораторна робота N3");
            Console.WriteLine("Виконала: Дольна О.І., група СН-21");
            Console.WriteLine("Варіант N9 \n");
            Console.WriteLine("Завдання 2.");

            int n, m;

            while (true)
            {
                try
                {
                    Console.Write("Введіть кількість рядків матриці n = ");
                    n = int.Parse(Console.ReadLine());
                    if (n <= 0)
                    {
                        throw new Exception();
                    }
                    Console.WriteLine();
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Помилка введення значення n. Будь ласка, повторіть введення значення ще раз!");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Введіть кількість стовпців матриці m = ");
                    m = int.Parse(Console.ReadLine());
                    if (m <= 0)
                    {
                        throw new Exception();
                    }
                    Console.WriteLine();
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Помилка введення значення m. Будь ласка, повторіть введення значення ще раз!");
                }
            }

            double[][] arr = new double[n][];
            for (int i = 0; i < n; i++)
            {
                arr[i] = new double[m];
            }
            Random random = new Random();
            Console.WriteLine("\tПочаткова матриця:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i][j] = random.Next(-142, 183) / 10.0;
                    Console.Write($"\t{arr[i][j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            double sum, maxsum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum = 0.0;
                for (int j = 0; j < m; j++)
                {
                    sum += arr[i][j];
                }
                Console.WriteLine($"Сума елементів {i + 1} рядка = " + sum.ToString("F1"));
                if (maxsum < sum)
                {
                    maxsum = sum;
                }
            }
            Console.WriteLine("\nНайбільша сума = " + maxsum.ToString("F1"));
            Console.WriteLine($"\n\tЗмінена матриця: ");
            for (int i = 0; i < n; i++)
            {
                Array.Reverse(arr[i]);
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"\t{arr[i][j]}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
