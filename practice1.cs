using System;

namespace practice1
{
    class TestNumSort
    {
        static void Main(String[] args)
        {
            int a, b, c, d;
            a = 1;
            b = 1;
            c = 1;
            while (a <= 4)
            {
                while (b <= 4)
                {
                    while (c <= 4)
                    {
                        if (a != b && a != c && b != c)
                        {
                            d = 10 - a - b - c;
                            if ((c == 1 ^ b == 2) && (c == 2 ^ d == 3) && (a == 2 ^ d == 4))
                            {
                                Console.WriteLine("红球放在{0}号，黄球放在{1}号，黑球放在{2}号，白球放在{3}号，", a, b, c, d);
                            }
                        }
                        c++;
                    }
                    b++;
                }
                a++;
            }
            Console.Read();
        }
    }
}





/*
namespace practice1
{
    class TestNumSort
    {
        static void Main(String[] args)
        {
            int a, b, c, d;
            for(a = 1; a <= 4;a++)
                for(b = 1;b <= 4;b++)
                    for(c = 1;c <=4;c++)
                        if(a != b && a != c && b != c)
                        {
                            d = 10 - a - b - c;
                            if((c == 1^b == 2) && (c == 2^d == 3) &&(a == 2^d == 4))
                            {
                                Console.Write("红球放在{0}号，黄球放在{1}号，", a, b);
                                Console.Write("黑球放在{0}号，白球放在{1}号，", c, d);
                            }
                        }
            Console.Read();
        }
    }
}




namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
*/
