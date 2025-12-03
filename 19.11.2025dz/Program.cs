using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            int chetNum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (sum % 2 == 0) { chetNum++; }
            }
            Console.WriteLine($"Cумма чисел {sum}");
            Console.WriteLine($"Среднее арифметическое {(double)sum / arr.Length}");
            Console.WriteLine($"Количество четных чисел {chetNum}");
        }
    }
}