using System;

namespace ConsoleApp1
{
    class Program
    {
        static int getnum1()
        {

            Console.WriteLine("\nEnter the value1:");
            var n1 = Convert.ToInt32(Console.ReadLine());
            return n1;
        }
        static int getnum2()
        {
            Console.WriteLine("\nEnter the value2:");
            var n2 = Convert.ToInt32(Console.ReadLine());
            return n2;
        }

        static int choice()
        { 
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");

            Console.WriteLine("\nEnter the choice to perform:");
            var ch = Convert.ToInt32(Console.ReadLine());
            return ch;
        }

        static int calc(int a, int b, int c)
        {
            int ans=0;
            try
            {
                if (c == 1)
                {
                    ans = a + b;
                }
                else if (c == 2)
                {
                    ans = a - b;
                }
                if (c == 3)
                {
                    ans = a * b;
                }
                else if (c == 4)
                {
                    ans = a / b;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return ans;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Simple calculator");
            Program p = new Program();
            int a = getnum1();
            int b = getnum2();
            int c = choice();
            int answer= calc(a,b,c);
            Console.WriteLine(" Answer is :" + answer);
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);

        }
    }
}

