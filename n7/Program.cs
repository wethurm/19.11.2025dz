using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mas = {
        "Груша,145,Продукты",
        "МышьГнилая,120,1",
        "МышьСвежая,45000,Лекарства",
        "Свага,2300,1",
        "ШаурмаСырная,380,Лекарства",
        "ТруСфэг,25,1",
        "Огурец,30,Продукты",
        "Карандаш,25,Канцелярия",
        "Маркер,90,1",
        "Манго,120,Продукты"
        };
            Console.WriteLine("Выберите категорию:");
            string category = Console.ReadLine();
            string[] mas2 = new string[mas.Length];
            int i = 0;
            for(int s = 0; s < mas.Length; s++)
            {
                if (mas[s].Split(',')[2] == category)
                {
                    mas2[i] = mas[s];
                    i++;
                }
            }
            Console.WriteLine();

            for (int s = 0; s<i; s++)
            {
                Console.WriteLine(mas2[s].Split(',')[0]);
            }

            Console.WriteLine("Введите нижнюю границу диапазона:");
            int low = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите верхнюю границу диапазона:");
            int top = Convert.ToInt32(Console.ReadLine());

            string[] sorted = new string[mas2.Length];
            int j = 0;

            for(int s = 0; s<i; s++)
            {

                string[] product = mas2[s].Split(',');
                int price = int.Parse(product[1]);

                if (price >= low && price <= top)
                {
                    sorted[j] = mas2[s].Split(',')[0]; j++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Отсортированный список:");
            for(int s = 0; s < j; s++)
            {
                Console.WriteLine(sorted[s]);
            }
        }
    }
}
