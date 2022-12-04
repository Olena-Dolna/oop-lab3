using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1DConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            NumberFormatInfo nfi = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            Console.WriteLine("Лабораторна робота N3");
            Console.WriteLine("Виконала: Дольна О.І., група СН-21");
            Console.WriteLine("Варіант N9 \n");
            Console.WriteLine("Завдання 1.");


            int n;

            while (true)
            {
                try
                {
                    Console.Write("Введіть кількість елементів масиву n = ");
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
            double[] arr = new double[n];
            int i, sum = 0, counter = 0, firstIndex = 0, lastIndex = 0, nomatch = 0;
            Random random = new Random();
            Console.WriteLine("Початковий масив:");
            for (i = 0; i < n; i++)
            {
                arr[i] = random.Next(-123, 163) / 10.0;
                Console.WriteLine($"елемент[{i}] = " + arr[i].ToString(nfi));
            }

            for (i = 0; i < n; i++)
            {
                if (arr[i] < 0 && i % 2 == 0)
                {
                    sum += i;
                }
                else if (arr[i] >= 0 || i % 2 != 0)
                {
                    nomatch++;
                }
            }
            if (nomatch == n)
            {
                Console.WriteLine("Масив не містить від'ємних елементів, індекси яких діляться на 2!");
            }
            else
            {
                Console.WriteLine($"\nСума індексів від'ємних елементів, індекси яких діляться на 2: {sum}");
            }
            for (i = 0; counter <= 2 && i < n; i++)
            {
                if (arr[i] > 0)
                {
                    counter++;
                    if (counter == 1)
                    {
                        firstIndex = i;
                    }
                    if (counter == 2)
                    {
                        lastIndex = i;
                    }

                }
            }
            try
            {   
                if (counter < 2)
                {
                    throw new Exception();
                }
                Array.Sort(arr, firstIndex, (lastIndex - firstIndex + 1));
               
                Console.WriteLine($"\nВідсортований масив:");
                for (i = 0; i < n; i++)
                {
                    Console.WriteLine($"елемент[{i}] = " + arr[i].ToString(nfi));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\nМасив не містить 2 додатних елементи!");
            }
            Console.ReadKey();
            
        }
    }
}
