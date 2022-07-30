using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение без знаков препинания");
            string str = Console.ReadLine();
            string[] strArray = str.Split();
            string strMax = strArray[0];
            foreach (string s in strArray)
            {
                if (s.Length > strMax.Length)
                {
                    strMax = s;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Самое длинное слово в предложении:");
            Console.WriteLine(strMax);
            Console.ReadKey();
        }
    }
}
