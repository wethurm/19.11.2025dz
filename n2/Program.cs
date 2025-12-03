using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string maxStr = "";
            string[] arr = new string[] { "sdfsf", "s123dfsf", "sddfsfsf", "s145dfsf", "sdf1efaadsfsf", "sqerqefaddfsf" };
            for (int i = 0; i < arr.Length; i++)
            {
                maxStr = arr[i].Length > maxStr.Length ? arr[i] : maxStr;
            }
            Console.WriteLine("Самая длиная строка");
            Console.WriteLine(maxStr);
            char a = Convert.ToChar(Console.ReadLine());
            string b = "";


            for (int i = 0; i < arr.Length; i++)
            {
                string str = arr[i];

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] == a)
                    {
                        Console.WriteLine(str);
                        if (b == "") { b = str; }
                        ;
                    }
                }
            }
            Console.WriteLine(b);
        }
    }
}