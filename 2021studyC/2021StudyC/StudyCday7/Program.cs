using System;

namespace StudyCday7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region //判断一个年是否为闰年
            //Console.WriteLine("请输入一个年份");
            //string year = Console.ReadLine();
            //if (IsRun(Convert.ToInt32(year)))
            //{ 
            //    Console.WriteLine("是闰年");
            //}
            //else
            //{
            //    Console.WriteLine("不是闰年");
            //}
            #endregion

            #region //用户只能输入yes  or  no
            //Console.WriteLine("请输入yes  or  no");
            //string input = Console.ReadLine();
            //IsYesNo(input);
            //Console.WriteLine(input);



            #endregion
            //int a = 10;
            //int b = 20;
            //Exchange(ref a, ref b);
            //Console.WriteLine(a+"+"+b);

            //求张三的总成绩
            MyParams("zhangsan", 28, 65, 65, 65, 65, 65);
        }
        /// <summary>
        /// 判断一个年是否为闰年
        /// </summary>
        /// <param name="year">输入的年份</param>
        /// <returns>结果是否为闰年</returns>
        public static bool IsRun(int year)
        {
            bool res = false;
            if ((year % 4 == 0) || year % 400 == 0)
            {
                res = true;

            }
            return res;
        }


        /// <summary>
        /// 限定用户只能输入yes or no 并返回
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string IsYesNo(string input)
        {
            while (true) 
            {
                if (input == "yes" || input == "no")
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("输入有误请重新输入");
                    input = Console.ReadLine();
                }
            }
            
        }

        public static void Test(int[] nums, out int max, out int min, out int sum)
        {
            //out参数要求在方法内部必须为参数赋值
            max = nums[0];
            min = nums[1];
            sum = 0;
        }

        /// <summary>
        /// 交换两个int类型的变量 使用 ref
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void Exchange(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }


        public static void MyParams(string name, params int[] score)
        {
            int sum=0;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            Console.WriteLine(name + "总成绩是" + sum);
        }

        public static int MyParams(string name, int age,params int[] score)
        {
            int sum = 0;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            Console.WriteLine(name + "总成绩是" + sum);
            return age;
        }

        public static string MyParams(string name)
        {
            Console.WriteLine(name);
            return name;
        }
    }
}
