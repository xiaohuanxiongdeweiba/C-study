using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace study07_out
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputName = "";
            string inputPsw = "";
            string result;
            string reason;
            Console.WriteLine("请输入用户名");
            inputName = Console.ReadLine();

            Console.WriteLine("请输入密码");
            inputPsw = Console.ReadLine();
            Test(inputName, inputPsw, out result, out reason);
            Console.WriteLine(result);
            Console.WriteLine(reason);
            Console.ReadKey();


        }

        public static void Test(string name, string psw, out string result, out string reason)
        {
            result = "";
            reason = "";
            if (name == "yumengyang")
            {
                if (psw == "8888")
                {
                    result = "登录成功";
                    

                }
                else
                {
                    result = "登录失败";
                    reason = "密码错误";
                }
            }
            else
            {
                reason = "用户名错误";
                result = "登录失败";
            }
            return;
        }

        /*
         * 要返回四个值，放在数组里返回
         * 返回多个不同类型的值，用out
         * out参数要求在方法内部必须为其赋值。
         * public static void Test(int[] nums,out int max, out int min,out int sum)
         * {
         * 
         * }
         * */

/*ref
 * Test(ref number)
 * public static void Test(string name, string psw, out string result, out string reason)
 * 
 * public static void Test(ref int number)
 * {
 * 直接改变外面的number ，不需要return
 * }
 * 必须在方法外部赋值
 * */

/*可变参数 params
 * 将实参列表中跟可变数组类型相同的元素都当做数组的元素。
 * Test("zhangsan", 99,56,23,66)
 * 或者
 * Test("zhangsan", 数组)
 * 
 * public static void Test(string name ,params int[] score)
 * {
 * }*/


        /*方法的重载
         * 方法名相同，参数类型不同
         * 参数个数相同，类型就不能相同
         * 参数类型相同，个数就不能相同
         * 跟返回值没有关系
         * 
         * 
         * 
         * */

        /*
         * 方法的递归
         * 方法自己调用自己
         * 
         * */

}
}
