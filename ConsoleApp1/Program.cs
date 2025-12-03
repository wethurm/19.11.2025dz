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
            string[] books =
            {
            "Война и мир-Толстой-1869-4,8",
            "Преступление и Наказание-Достоевский-1866-4,7",
            "1984-Оруэлл-1949-4,6",
            "Мастер и Маргарита-Булгаков-1967-4,9",
            "Властелин Колец-Толкин-1954-4,8",
            "Гарри Поттер-Роулинг-1997-4,5",
            "Вишневый Сад-Чехов-1904-4,3",
            "Новая Книга-Автор-2020-4,2"
            };
            Console.WriteLine("====книги с рейтингом больше 4.5");

            var hightRated = books.Where(b => Convert.ToDouble(b.Split('-')[3]) > 4.5);
            foreach(var hR in hightRated)
            {
                Console.WriteLine($"  - {hR.Split('-')[0]}");
            }
            Console.WriteLine();
            Console.WriteLine("Книги поле 2015");
            var year = books.Where(b => Convert.ToInt32(b.Split('-')[2]) > 2015);
            foreach(var y in year)
            {
                Console.WriteLine($"  - {y.Split('-')[0]} {y.Split('-')[2]}");
            }
            var top3 = books.OrderByDescending(b => Convert.ToDouble(b.Split('-')[3])).Take(3);
            Console.WriteLine();
            foreach(var y in top3)
            {
                Console.WriteLine($" - {y.Split('-')[0]} {y.Split('-')[3]}");
            }

            Console.WriteLine();
            Console.WriteLine("Книги на В");

            var startV = books.Where(b => b.StartsWith("В"));
            foreach(var v in startV)
            {
                Console.WriteLine(v);
            }
            //var max1;
            //var max2;
            //var max3;
            //var rate = books.Where(b => Convert.ToDouble(b.Split('-')[3]) > 0);
            //Console.WriteLine(rate);
            //foreach (var z in rate)
            //{
            //    if(Convert.ToDouble(z.Split('-')[3]) > max1)
            //    {
            //        max1 = Convert.ToDouble(z.Split('-')[3]);
            //        max2 = max1;
            //        max3 = max2;
            //    }
            //}
        }
    }
}
