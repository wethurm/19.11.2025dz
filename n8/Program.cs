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
            Console.WriteLine($"Отсортированный");
            Array.Sort(mas);
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            double med = 0;
            if (mas.Length % 2 == 0)
            {
                med = (mas[(mas.Length / 2) - 1] + mas[mas.Length / 2]) / 2.0;
            }
            else
                med = mas[mas.Length / 2];
            Console.WriteLine($"Медиана: {med}");
            double sum = 0.0;
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
            }
            double sred = sum / mas.Length;
            double summ = 0.0;
            foreach (int i in mas)
            {
                double vch = i - sred;
                double kv = Math.Pow(vch, 2);
                summ += kv;
            }
            double sred2 = summ / mas.Length;
            double kor = Math.Sqrt(sred2);
            Console.WriteLine($"Среднее отк:{kor:F2}");
            Console.WriteLine($"Топ-10%");
            var top10 = mas.OrderByDescending(m => m).Take(Convert.ToInt32(Math.Ceiling(mas.Length * 0.1)));
            foreach (int i in top10)
            {
                Console.WriteLine($" -- {i} --");
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
