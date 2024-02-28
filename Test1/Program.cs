 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите числа: ");
            do
            {
                string num = Console.ReadLine();
                if (num == "") break;
                Console.Write("1 задание: ");
                int el = Convert.ToInt32(num);
                if (el % 5 == 0 && el % 3 == 0)
                {
                    Console.WriteLine("fizz-buzz");
                }
                else if (el % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (el % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(el);
                }
                Console.Write("2 задание: ");
                if (el % 4 == 0 && el % 7 == 0 && el % 5 == 0 && el % 3 == 0)
                {
                    Console.WriteLine("fizz-buzz-muzz-guzz");
                }
                else if (el % 4 == 0 && el % 7 == 0 && el % 5 == 0)
                {
                    Console.WriteLine("buzz-muzz-guzz");
                }
                else if (el % 4 == 0 && el % 7 == 0 && el % 3 == 0)
                {
                    Console.WriteLine("fizz-muzz-guzz");
                }
                else if (el % 3 == 0 && el % 7 == 0 && el % 5 == 0)
                {
                    Console.WriteLine("fizz-buzz-guzz");
                }
                else if (el % 3 == 0 && el % 4 == 0 && el % 5 == 0)
                {
                    Console.WriteLine("fizz-buzz-muzz");
                }
                else if (el % 3 == 0 && el % 4 == 0)
                {
                    Console.WriteLine("fizz-muzz");
                }
                else if (el % 5 == 0 && el % 3 == 0)
                {
                    Console.WriteLine("fizz-buzz");
                }
                else if (el % 3 == 0 && el % 7 == 0)
                {
                    Console.WriteLine("fizz-guzz");
                }
                else if (el % 4 == 0 && el % 5 == 0)
                {
                    Console.WriteLine("buzz-muzz");
                }
                else if (el % 4 == 0 && el % 7 == 0)
                {
                    Console.WriteLine("muzz-guzz");
                }
                else if (el % 5 == 0 && el % 7 == 0)
                {
                    Console.WriteLine("buzz-guzz");
                }
                else if (el % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (el % 4 == 0)
                {
                    Console.WriteLine("muzz");
                }
                else if (el % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else if (el % 7 == 0)
                {
                    Console.WriteLine("guzz");
                }
                else
                {
                    Console.WriteLine(el);
                }
                Console.Write("3 задание: ");
                if (el % 4 == 0 && el % 7 == 0 && el % 5 == 0 && el % 3 == 0)
                {
                    Console.WriteLine("good-boy-muzz-guzz");
                }
                else if (el % 4 == 0 && el % 7 == 0 && el % 5 == 0)
                {
                    Console.WriteLine("buzz-muzz-guzz");
                }
                else if (el % 4 == 0 && el % 7 == 0 && el % 3 == 0)
                {
                    Console.WriteLine("fizz-muzz-guzz");
                }
                else if (el % 3 == 0 && el % 7 == 0 && el % 5 == 0)
                {
                    Console.WriteLine("good-boy-guzz");
                }
                else if (el % 3 == 0 && el % 4 == 0 && el % 5 == 0)
                {
                    Console.WriteLine("good-boy-muzz");
                }
                else if (el % 3 == 0 && el % 4 == 0)
                {
                    Console.WriteLine("fizz-muzz");
                }
                else if (el % 5 == 0 && el % 3 == 0)
                {
                    Console.WriteLine("good-boy");
                }
                else if (el % 3 == 0 && el % 7 == 0)
                {
                    Console.WriteLine("fizz-guzz");
                }
                else if (el % 4 == 0 && el % 5 == 0)
                {
                    Console.WriteLine("buzz-muzz");
                }
                else if (el % 4 == 0 && el % 7 == 0)
                {
                    Console.WriteLine("muzz-guzz");
                }
                else if (el % 5 == 0 && el % 7 == 0)
                {
                    Console.WriteLine("buzz-guzz");
                }
                else if (el % 3 == 0)
                {
                    Console.WriteLine("dog");
                }
                else if (el % 4 == 0)
                {
                    Console.WriteLine("muzz");
                }
                else if (el % 5 == 0)
                {
                    Console.WriteLine("cat");
                }
                else if (el % 7 == 0)
                {
                    Console.WriteLine("guzz");
                }
                else
                {
                    Console.WriteLine(el);
                }
            }
            while (true);
            Console.ReadKey();
        }
    }
}
