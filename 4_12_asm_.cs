using System;
namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string symbol;
            Console.Write("사용할 연산자 기호 입력(종료: end): ");
            symbol = Console.ReadLine();

            while (symbol != "end")
            {
                switch (symbol)
                {
                    case "!":
                        Console.WriteLine("팩토리얼 연산을 수행합니다.");
                        Console.Write("수를 입력하세요: ");
                        long n;
                        string temp1;
                        temp1 = Console.ReadLine();
                        n = Int32.Parse(temp1);
                        Console.Write(n);
                        Console.Write("! = ");
                        facto(ref n);
                        Console.WriteLine(n);
                        break;
                    default:
                        string temp2;
                        float num1, num2;
                        Console.Write("첫번째 수 입력: ");
                        temp2 = Console.ReadLine();
                        num1 = float.Parse(temp2);
                        Console.Write("두번째 수 입력: ");
                        temp2 = Console.ReadLine();
                        num2 = float.Parse(temp2);
                        switch (symbol)
                        {
                            case "+":
                                Console.WriteLine("더하기 연산을 수행합니다.");
                                
                                Console.Write(num1);
                                Console.Write(" ");
                                Console.Write(symbol);
                                Console.Write(" ");
                                Console.Write(num2);
                                Console.Write(" = ");
                                
                                Console.WriteLine(add(num1, num2));
                                break;
                            case "-":
                                Console.WriteLine("빼기 연산을 수행합니다.");

                                Console.Write(num1);
                                Console.Write(" ");
                                Console.Write(symbol);
                                Console.Write(" ");
                                Console.Write(num2);
                                Console.Write(" = ");

                                Console.WriteLine(sub(num1, num2));
                                break;
                            case "*":
                                Console.WriteLine("곱하기 연산을 수행합니다.");

                                Console.Write(num1);
                                Console.Write(" ");
                                Console.Write(symbol);
                                Console.Write(" ");
                                Console.Write(num2);
                                Console.Write(" = ");

                                Console.WriteLine(mul(num1, num2));
                                break;
                            case "/":
                                Console.WriteLine("나누기 연산을 수행합니다.");

                                Console.Write(num1);
                                Console.Write(" ");
                                Console.Write(symbol);
                                Console.Write(" ");
                                Console.Write(num2);
                                Console.Write(" = ");

                                Console.WriteLine(div(num1, num2));
                                break;
                            default:
                                Console.WriteLine("해당 문자는 사칙 연산 기호가 아닙니다.");
                                break;
                        }
                        break;
                }
                Console.Write("사용할 연산자 기호 입력(종료: end): ");
                symbol = Console.ReadLine();
            }
            Console.WriteLine("프로그램 종료");
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
        static void facto(ref long n)
        {
            long total = 1;
            for (long i = 2; i <= n; i++)
            {
                total *= i;
            }
            n = total;
        }
    }

}