using System;

namespace practice2
{
    class TestPi
    {
        static void Main(String[] args)
        {
            double sum = 0.5, t, t1, t2, t3, p = 0.5 * 0.5;
            int odd = 1, even = 2;
            t = t1 = t2 = 1.0;
            t3 = 0.5;
            while(t > 1e-10)
            {
                t1 = t1 * odd / even;
                odd += 2;
                even += 2;
                t2 = 1.0 / odd;
                t3 *= p;
                t = t1 * t2 * t3;
                sum += t;
            }
            Console.WriteLine("\nPI={0,10:f8}", sum * 6);
            Console.Read();
        }
    }
}

/*
namespace practice2
{
    class TestNumSort
    {
        static void Main(String[] args)
        {
            int a, b, c, d;
            a = 1;
            while (a <= 4)
            {
                b = 1;
                while (b <= 4)
                {
                    c = 1;
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
*/
