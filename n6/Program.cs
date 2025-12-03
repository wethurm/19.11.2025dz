using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] temps = new int[]
{
            -5, -3, -2, 0, 1, 3, 2
            -1, -4, -6, -3, 1, 4, 6,
            8, 10, 12, 9, 7, 5, 3,
            2, 1, 0, -1, 4, 6, 9
};
            int weekCount = temps.Length / 7;

            double warmestAvg = double.MinValue;
            double coldestAvg = double.MaxValue;
            int warmestWeek = 0;
            int coldestWeek = 0;

            for (int w = 0; w < weekCount; w++)
            {
                int sum = 0;

                for (int d = 0; d < 7; d++)
                {
                    sum += temps[w * 7 + d];
                }

                double avg = sum / 7;

                if (avg > warmestAvg)
                {
                    warmestAvg = avg;
                    warmestWeek = w + 1;
                }

                if (avg < coldestAvg)
                {
                    coldestAvg = avg;
                    coldestWeek = w + 1;
                }
            }

            Console.WriteLine($"Самая тёплая неделя: {warmestWeek} (ср. темп = {warmestAvg:F1})");
            Console.WriteLine($"Самая холодная неделя: {coldestWeek} (ср. темп = {coldestAvg:F1})");

            int total = 0;
            for (int i = 0; i < temps.Length; i++)
                total += temps[i];

            double monthAvg = total / (double)temps.Length;

            Console.WriteLine($"\nСредняя температура за месяц: {monthAvg:F1}");
            Console.WriteLine("Дни выше средней:");

            for (int i = 0; i < temps.Length; i++)
            {
                if (temps[i] > monthAvg)
                {
                    Console.WriteLine($" - День {i + 1}, температура: {temps[i]}");
                }
            }

            var frost = temps.Where(t => t < 0);
            Console.WriteLine("Мороз (t < 0):");
            foreach (int i in frost) Console.WriteLine(" " + i);
            Console.WriteLine();

            var cold = temps.Where(t => t >= 0 && t <= 10);
            Console.WriteLine("Холодно (0…10):");
            foreach (int i in cold) Console.WriteLine(" " + i);
            Console.WriteLine();

            var warm = temps.Where(t => t >= 11 && t <= 20);
            Console.WriteLine("Тепло (11…20):");
            foreach (int i in warm) Console.WriteLine(" " + i);
            Console.WriteLine();

            var hot = temps.Where(t => t > 20);
            Console.WriteLine("Жарко (t > 20):");
            foreach (int i in hot) Console.WriteLine(" " + i);
            Console.WriteLine();
        }
    }
}
