using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите количество результатов");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[a];
            Random r = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = r.Next(0, 101);
                Console.Write(mas[i] + " ");
            }
            Array.Sort(mas);
            int med = (int)Math.Round(mas.Average());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(med);
            Console.WriteLine();

            int std = (int)Math.Round(Math.Sqrt(mas.Sum(x => Math.Pow(x - med, 2)) / (mas.Length - 1)));
            Console.WriteLine(std);

            int[] top10 = new int[mas.Length / 10];
            int sc = mas.Length - 1;
            for (int i = 0; i < top10.Length; i++)
            {
                Console.Write(mas[sc] + " ");
                sc--;
            }

            Console.WriteLine();
            Console.WriteLine($"Сортировка результатов по группам");
            var nezch = mas.Where(m => m < 25);
            Console.WriteLine($"Не зачет");
            foreach (int i in nezch)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            var neyd = mas.Where(m => m >= 25 && m < 50);
            Console.WriteLine($"Неудовлетворительно");
            foreach (int i in neyd)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            var ydov = mas.Where(m => m >= 50 && m < 70);
            Console.WriteLine($"Удовлетворительно");
            foreach (int i in ydov)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            var hor = mas.Where(m => m >= 70 && m < 85);
            Console.WriteLine($"Хорошо");
            foreach (int i in hor)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            var otl = mas.Where(m => m >= 85);
            Console.WriteLine($"Отлично");
            foreach (int i in otl)
            {
                Console.Write(i + " ");
            }
        }
    }
}
