using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace study05
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //int i = 1;
            //int sum = 0;
            //while (i <= 100)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();


            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine("Hello,World");
            //    break;
            //}
            //Console.ReadKey();

            //int num = 0;
            //int sum = 0;
            //int timer = 0;
            //Console.WriteLine("请输入班级人数");
            //num = Convert.ToInt32(Console.ReadLine());
            //timer = num;

            //while (num>0)
            //{
            //    Console.WriteLine("请输入学员成绩");
            //    int chengji = Convert.ToInt32(Console.ReadLine());

            //    sum += chengji;

            //    num--;
            //}
            //Console.WriteLine("所有学员成绩为{0},平均成绩为{1}", sum, sum / timer);
            //Console.ReadKey();
            #endregion

            int i = 3;
            int sum = 0;
            while (i <= 100)
            {
                //sum += i;

                int j = 2;
                while (j <= i)
                {
                    if (i % j == 0&&j<i)
                    {
                        break;

                    }
                    if (j == i)
                    {
                        Console.WriteLine(i);
                        sum += i;

                    }
                    j++;
                    
                }

                i++;
            }
            Console.WriteLine(sum);
            Console.ReadKey();

            /*
             * 程序调试
             * 断点调试，程序在断点处暂停，按F11继续执行
             * */
        }
    }
}
