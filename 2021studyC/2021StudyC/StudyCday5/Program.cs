using System;

namespace StudyCday5
{
    class Program
    {
        static void Main(string[] args)
        {
            //水仙花数
            int a = 0;
            int b = 0;
            int c = 0;

            for (int i = 100; i <= 999; i++)
            {
                a = i / 100;
                b = (i - a * 100) / 10;
                c = (i - a * 100 - b * 10);
                int sum = a * a * a + b * b * b + c * c * c;
                if (sum == i)
                {
                    Console.WriteLine(i);

                }


            }
        }
    }
}
