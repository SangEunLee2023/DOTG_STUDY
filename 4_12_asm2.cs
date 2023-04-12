using System;
using System.Runtime.InteropServices;
using System.Xml.Schema;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] avgs)
        {
            Console.Write("수를 입력하세요: ");
            long n;
            string temp;
            temp = Console.ReadLine();
            n = Int32.Parse(temp);
            Console.Write(n);
            Console.Write("! = ");
            facto(ref n);
            Console.WriteLine(n);
        }
        static void facto(ref long n)
        {
            long total = 1;
            for (long i = 2; i <= n ; i++)
            {
                total *= i;
            }
            n = total;
        }
    }
}
