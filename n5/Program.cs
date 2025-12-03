using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Массив сотрудников: ФИО и должность
            string[] employees = {
            "Иванов Иван Иванович-Программист",
            "Петров Петр Сергеевич-Менеджер",
            "Ильин Алексей-Программист",
            "Иванова Мария-Программист",
            "Сидоров Иван-Тестировщик"
        };


            Console.Write("Введите должность: ");
            string position = Console.ReadLine();

            var programmers = employees.Where(b => Convert.ToString(b.Split('-')[1]) == position);
            foreach (var pr in programmers)
            {
                Console.WriteLine($"  - {pr.Split('-')[0]}");
            }

        }
    }
}