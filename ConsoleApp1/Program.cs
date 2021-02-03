using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cAlculat");
            Console.WriteLine("Введите первое слово");
            string s1 = Console.ReadLine();
            Console.WriteLine("Введите второе слово");
            string s2 = Console.ReadLine();
            string sum = s1 + " " + s2;
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
