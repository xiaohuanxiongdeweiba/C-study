using System;

namespace StudyCday4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            Console.WriteLine("请输入年份");
            string year = Console.ReadLine();
            Console.WriteLine("请输入月份");
            string month = Console.ReadLine();
            
            switch (Convert.ToDouble(month))
            {
                case 1:
                    Console.WriteLine("该月的天数是 31 天");
                    break;
                case 2:
                    if (Convert.ToDouble(year) % 4 == 0 || Convert.ToDouble(year) % 400 == 0)
                    {
                        Console.WriteLine("该月的天数是 29 天");
                    }
                    else
                    {
                        Console.WriteLine("该月的天数是 28 天");
                    }
                    
                    break;
                case 3:
                    Console.WriteLine("该月的天数是 31 天");
                    break;
                case 4:
                    Console.WriteLine("该月的天数是 30 天");
                    break;
                case 5:
                    Console.WriteLine("该月的天数是 31 天");
                    break;
                case 6:
                    Console.WriteLine("该月的天数是 30 天");
                    break;
                case 7:
                    Console.WriteLine("该月的天数是 31 天");
                    break;
                case 8:
                    Console.WriteLine("该月的天数是 31 天");
                    break;
                case 9:
                    Console.WriteLine("该月的天数是 30 天");
                    break;
                case 10:
                    Console.WriteLine("该月的天数是 31 天");
                    break;
                case 11:
                    Console.WriteLine("该月的天数是 30 天");
                    break;
                case 12:
                    Console.WriteLine("该月的天数是 31 天");
                    break;

            }*/
            #endregion

            int i = 100;
            int sum = 0;
            while (i > 0)
            {
                sum += i;
                i--;
            }
            Console.WriteLine(sum);

        }
    }
}
