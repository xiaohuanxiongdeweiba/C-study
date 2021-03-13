using System;

namespace study03_分支结构
{
    class Program
    {
        static void Main(string[] args)
        {
        //    int i = 1;
        //    int sum = 0;
        //    while (i <= 100)
        //    {
        //        sum += i;
        //        i++;
        //    }
        //    Console.WriteLine(sum);
        //    Console.ReadKey();

        int i = 0;
            while (i < 10)
            {
                Console.WriteLine("Hello,World");

            }
            //    Console.ReadKey();



            ////if语句
            //if (判断条件)
            //{
            //    要执行的代码1；
            //}
            //else
            //{ 
            //要执行的代码1；
            //}


            ////先判断再执行，可能不执行任何代码。
            //符合if则直接执行代码1
            //    不符合则直接执行代码2





            //if else-if

            //if (判断条件)
            //    {
            //        要执行的代码1；

            //    }
            //    else if (判断条件)
            //    {
            //        要执行的代码2；
            //    }
            //    else if (判断条件3)
            //    {
            //        要执行的代码3；
            //    }

            //    else { }



            //switch case

            //swithc(变量或者表达式的值)
            //{ 
            //    case 值1：要执行的代码；
            //    break；
            //    case 值2：要执行的代码；
            //    break；
            //        ....
            //    default：要执行的代码；
            //    break；

            //}

            //都不匹配，则default


            /* while循环
             * while(循环条件)
             * {
             * 循环体；
             * }
             * 
             break 跳出当前循环。
              */


            //do while 循环
            //do
            //{
            // 执行语句；
            //}
            //while (循环条件)；


            /*
             * continue: 结束本次循环，继续下一次
             * 
             */

            /*
             * for 循环
             * for(int i=1;i<length;i++)
             * {
             * 执行的循环体；
             * }
             * 
             *先执行i=1,之后进行判断，之后执行循环体，之后i++，之后判断。
             **/

            /*
             * int.Parse(string),表示讲一个字符串转换成int类型
             * 效率比convert.toint32（）
             * double.parse()
             * char.parse()
             * */

            /*
             * int.TryParse()
             * 尝试将一个字符串转换成int类型。
             * bool b=int.TryParse("123",out number)
             * 
             * 方法 或者 函数？
             * 参数，返回值*/

        }
    }
}
