using System;

namespace การบ้าน_Week3___Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            string w;
            Console.Write("Affiliate : ");
            w = Console.ReadLine();
            int a, s1, s2, s4, d3, d5, d6, a1, a3, aaa;
            Console.Write("Password : ");
            a = int.Parse(Console.ReadLine());

            if (a >= 0 && a <= 999999)
            {
                if (w == "CIA")
                {
                    s1 = a % 10;
                    if (s1 % 3 == 0)
                    {
                        s2 = a / 10;
                        if (s2 % 10 != 1 && s2 % 10 != 3 && s2 % 10 != 5)
                        {
                            s4 = a / 1000;
                            if (s4 % 10 >= 6 && s4 % 10 != 8)
                            {
                                Console.WriteLine("True");
                            }
                            else
                                Console.WriteLine("False");
                        }
                        else
                            Console.WriteLine("False");
                    }
                    else
                        Console.WriteLine("False");
                }
                if (w == "FBI")
                {
                    d6 = a / 100000;
                    if (d6 >= 4 && d6 <= 7)
                    {
                        d3 = a / 100;
                        if (d3 % 10 == 2 || d3 % 10 == 4 || d3 % 10 == 8)
                        {
                            d5 = a / 10000;
                            if (d5 % 2 == 1)
                            {
                                Console.WriteLine("True");
                            }
                            else
                                Console.WriteLine("False");
                        }
                        else
                            Console.WriteLine("False");
                    }
                    else
                        Console.WriteLine("False");
                }
                if (w == "NSA")
                {
                    a1 = a % 10;
                    if (a1 == 1 || a1 == 2 || a1 == 3 || a1 == 5 || a == 6)
                    {
                        a3 = a / 100;
                        if (a3 % 3 == 0 || a3 % 2 != 0)
                        {
                            Console.WriteLine("True");
                        }
                        else
                            Console.WriteLine("False");
                    }
                    else
                        Console.WriteLine("False");
                }
                else
                    Console.WriteLine("False");
            }
            else
                Console.WriteLine("ERROR");
        }
    }
}
