using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение.");
            string str = Console.ReadLine();
            int n = 0;
            int startIndex = 0;
            int endIndex = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '{')
                {
                    if (n==0)
                    {
                        startIndex = i;
                    }
                    n++;
                }
                else if (str[i] == '}')
                {
                    endIndex = i;
                    n--;
                    if (n == 0)
                    {
                        str = (str[startIndex - 1] == ' ' && str[endIndex + 1] == ' ') ? str.Remove(startIndex, endIndex - startIndex + 2): str.Remove(startIndex, endIndex - startIndex + 1);
                        i = -1;
                    }
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
