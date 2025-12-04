using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mas =
{
            "Фазуллин-4-5-5-4-5",
            "Фазулллин-5-4-4-5-5",
            "Фазуллллин-3-4-4-3-4",
            "Фазулллллин-5-5-4-4-4",
            "Фазулин-4-3-5-4-3",
            "Фазуллинн-5-4-3-5-4",
            "Фазуллиннн-3-5-3-4-3",
            "Фазуллинннн-4-4-4-3-5",
            "Фазуллиннннн-3-3-4-3-4",
            "ФазуллинАА-5-3-5-4-5",
            };
            foreach (string tab in mas)
            {
                var part = tab.Split('-');
                Console.Write($"{part[0]}: ");
                for (int i = 1; i < part.Length; i++)
                {
                    Console.Write($"{part[i]}, ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"средний балл");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Ученики со средним баллом выше {a}:");
            foreach (string tab in mas)
            {
                var part = tab.Split('-');
                string name = part[0];
                double sum = 0;
                for (int i = 1; i < part.Length; i++)
                {
                    sum += Convert.ToDouble(part[i]);
                }
                double sred = sum / (part.Length - 1);
                if (sred > a)
                {
                    Console.WriteLine($"{name}: {sred:f1}");
                }
            }
            Console.WriteLine($"Успеваимость по предметам:");
            string[] sub = { "Рус", "Инф", "Мат", "Прог", "Физра" };
            double[] best = new double[sub.Length];
            for (int i = 0; i < sub.Length; i++)
            {
                double summ = 0;
                foreach (string tab in mas)
                {
                    var part = tab.Split('-');
                    summ += Convert.ToDouble(part[i + 1]);
                }
                best[i] = summ / mas.Length;
                Console.WriteLine($"{sub[i]}: {best[i]}");
            }
            Console.WriteLine($"Предмет с наивысшей успеваимостью(not fazullin):");
            double max = 0;
            string bsub = "";
            for (int i = 0; i < best.Length; i++)
            {
                if (best[i] > max)
                {
                    max = best[i];
                    bsub = sub[i];
                }
            }
            Console.WriteLine($"{bsub}: {max}");
            string[] reit = new string[mas.Length];
            for (int i = 0; i < reit.Length; i++)
            {
                var part = mas[i].Split('-');
                string name = part[0];
                double sum = 0;
                for (int j = 1; j < part.Length; j++)
                {
                    sum += Convert.ToDouble(part[j]);
                }
                double sred = sum / (part.Length - 1);
                reit[i] = $"{name}-{sred}";
            }
            var rit = reit.OrderByDescending(r => Convert.ToDouble(r.Split('-')[1]));
            int kol = 1;
            foreach (string r in rit)
            {
                Console.WriteLine($"{kol}.  {r.Split('-')[0]} -- {r.Split('-')[1]}");
                kol++;
            }
            Console.WriteLine($"Отличники (Точно не Фазуллин):");
            foreach (string tab in mas)
            {
                var part = tab.Split('-');
                var name = part[0];
                int five = 0;
                for (int j = 1; j < part.Length; j++)
                {
                    if (part[j] == "5")
                    {
                        five++;
                    }
                }
                if (five == part.Length - 1)
                {
                    Console.WriteLine(name);
                }
            }
            Console.WriteLine("Хорошисты (Не Фазуллин):");
            foreach (string tab in mas)
            {
                var part = tab.Split('-');
                var name = part[0];
                int four = 0;
                int three = 0;
                int two = 0;
                for (int i = 1; i < part.Length; i++)
                {
                    if (part[i] == "4")
                    {
                        four++;
                    }
                    if (part[i] == "3")
                    {
                        three++;
                    }
                    if (part[i] == "2")
                    {
                        two++;
                    }
                }
                if (four > 0 && three == 0 && two == 0)
                {
                    Console.WriteLine(name);
                }
            }
            Console.WriteLine("Бездельники и Фазуллин:");
            foreach (string tab in mas)
            {
                var part = tab.Split('-');
                string name = part[0];
                int three = 0;
                int two = 0;
                for (int i = 1; i < part.Length; i++)
                {
                    if (part[i] == "3")
                    {
                        three++;
                    }
                    if (part[i] == "2")
                    {
                        two++;
                    }
                }
                if (three > 0 && two == 0)
                {
                    Console.WriteLine(name);
                }
            }
            Console.WriteLine($"Оболдуи и Суперфазуллин:");
            foreach (string tab in mas)
            {
                var part = tab.Split('-');
                var name = part[0];
                int two = 0;
                for (int j = 1; j < part.Length; j++)
                {
                    if (part[j] == "2")
                    {
                        two++;
                    }
                }
                if (two > 0)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
