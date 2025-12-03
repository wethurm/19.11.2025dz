using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 0, 7, 0, 9, 10 };

            int j = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    j++;
                }
            }
            int[] arrNoZero = new int[j];
            j = 0;


            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arrNoZero[j] = arr[i];
                    j++;
                }
            }

            for (int i = 0; i < arrNoZero.Length; i++)
            {
                Console.WriteLine(arrNoZero[i]);
            }
        }
    }
}