using System;
namespace DOTG_4_12
{

    // [ static ]
    // static 을 사용하여 함수를 선언하면
    // 함수 선언을 하지 않고 함수를 사용할 수 있다.

    // [ float, double 형 상수 상용시 유의사항 ]
    // 3.12, 3.15와 같이 실수형 상수를 사용할 경우 아래와 같이 
    // 3.12f , 3.15f, 3.12d, 3.15d
    // 상수 뒤에 접미어 f(float)나 d(double)를 붙여 주어야 한다.

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            int a = 3, b = 4;
            Console.WriteLine(sum(a, b));
            Console.WriteLine(mul(3.1f, 3.2f));
            string ns;
            int n;
            Console.Write("몇개의 별을 출력하시겠습니까? >> ");
            ns = Console.ReadLine();
            n = Int32.Parse(ns);
            Print_star(n);

            int A = 2, B = 1;
            Console.WriteLine("swap() 전 A와 B");
            Console.Write(A);
            Console.Write(' ');
            Console.WriteLine(B);

            swap(ref A, ref B);

            Console.WriteLine("swap() 후 A와 B");
            Console.Write(A);
            Console.Write(' ');
            Console.WriteLine(B);


        }
        static int sum(int a, int b)
        {
            return a + b;
        }
        static float mul(float a, float b)
        {
            return a * b;
        }
        static void Print_star(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine(' ');
        }
        static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}