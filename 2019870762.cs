using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculator cal = new Calculator();

            Console.WriteLine("첫 번째 수를입력하시오");
            int a = int.Parse(Console.ReadLine());

           

            Console.WriteLine("두 번째 수를입력하시오");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("더하기는~{0}", cal.Add(a, b));
            Console.WriteLine("빼기는~{0}", cal.Sub(a, b));
            Console.WriteLine("나누기는~{0}", cal.Div(a, b));
            Console.WriteLine("곱하기는~{0}", cal.Mul(a, b));
        }
    }
}


namespace test
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Div(int a, int b)
        {
            return a / b;
        }
        public int Mul(int a, int b)
        {
            return a * b;
        }
    }
}

