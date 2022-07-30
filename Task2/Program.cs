using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение или слово без знаков препинания.");
            string str = Console.ReadLine().Trim();
            string replacedLower = "";
            string strType = "";
            if (str.Contains(" "))
            {
                replacedLower = str.Replace(" ", "").ToLower();
                strType = "Предложение";
            }
            else
            {
                replacedLower = str.ToLower();
                strType = "Слово";
            }
            string revers = "";
            foreach (char c in replacedLower)
            {
                revers = c + revers;
            }
            if (revers == replacedLower)
            {
                Console.WriteLine($"{strType} является палиндромом");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"{strType} не является палиндромом");
                Console.ReadKey();
            }
        }
    }
}
