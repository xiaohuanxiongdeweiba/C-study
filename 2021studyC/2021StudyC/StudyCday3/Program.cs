using System;

namespace StudyCday3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请输入您的成绩");
                double score = Convert.ToInt32(Console.ReadLine());
                if (score >= 90)
                {
                    Console.WriteLine("您的成绩是：A");
                }
                else if (score >= 80)
                {
                    Console.WriteLine("您的成绩是：B");
                }
                else if (score >= 70)
                {
                    Console.WriteLine("您的成绩是：C");
                }
                else if (score >= 60)
                {
                    Console.WriteLine("您的成绩是：D");
                }
                else
                {
                    Console.WriteLine("您的成绩是：F");
                }
            }




        }
    }
}
