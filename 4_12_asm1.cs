using System;
namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string temp;
            float num1, num2;
            string symbol;
            Console.Write("첫번째 수 입력: ");
            temp = Console.ReadLine();
            num1 = float.Parse(temp);
            Console.Write("두번째 수 입력: ");
            temp = Console.ReadLine();
            num2 = float.Parse(temp);
            Console.Write("사용할 연산자 기호 입력: ");
            symbol = Console.ReadLine();

            switch (symbol)
            {
                case "+":
                    Console.WriteLine("더하기 연산을 수행합니다.");
                    Console.WriteLine(add(num1, num2));
                    break;
                case "-":
                    Console.WriteLine("빼기 연산을 수행합니다.");
                    Console.WriteLine(sub(num1, num2));
                    break;
                case "*":
                    Console.WriteLine("곱하기 연산을 수행합니다.");
                    Console.WriteLine(mul(num1, num2));
                    break;
                case "/":
                    Console.WriteLine("나누기 연산을 수행합니다.");
                    Console.WriteLine(div(num1, num2));
                    break;
                default:
                    Console.WriteLine("해당 문자는 사칙 연산 기호가 아닙니다.");
                    break;
            }
        }

        static float add(float a, float b)
        {
            return a + b;
        }
        static float sub(float a, float b)
        {
            return a - b;
        }
        static float mul(float a, float b)
        {
            return a * b;
        }
        static float div(float a, float b)
        {
            return a / b;
        }
    }

}