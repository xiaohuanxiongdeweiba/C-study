using System;

namespace study02
{
    class Program
    {
        /// <summary>
        /// 主函数入口
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 20;
            int n3 = 30;
            string name;
            Console.WriteLine("第一个数字是{0}，第二个数字是{1}，第三个数字是{2}", n1, n2, n3);
            Console.WriteLine("Hello World!");
            Console.WriteLine("你喜欢吃什么水果？");
            name=Console.ReadLine();
            Console.WriteLine("哈哈这么巧，我也喜欢吃{0},哈哈",name);
            Console.WriteLine(name);

            Console.ReadKey();

        }
        #region
//常用快捷键
// * 快速对齐代码 ctrl+k+d
// * 快速弹出智能提示 ctrl+j
// * 注释所选代码 ctrl+k+c
// * 取消注释ctrl+k+u
// * 选中行，shift+home/end
//折叠冗余代码 #region/#endregion
#endregion

//存储变量的方法：
//变量类型 变量名；   声明或者定义一个变量，开辟存储空间
//    变量名=值      赋值   
//int number = 100;
//int ; double 小数+整数; float; string "中文"; char '' 只能存一个，不能为空; decimal money=50m 必须加m 用来存钱；
////使用变量前需要定义并且赋值，再使用，没使用会警告
//变量不可以被重复的声明或者定义

//    camel命名规范：首单词的首字母小写，其余首字母大写   highSchoolStudent 给变量明明
//pascal命名规范：每个单词首字母都要大写，其余小写，给类或者方法命名。

//占位符: {0},{1}......;   之后填上坑  ,n1,n2

//异常：语法上没有错误，程序运行期间出现问题，程序无法正常运行。


/*
 * 三元表达式
 * 表达式1？表达式2：表达式3
 * 表达式2,3类型一致，且和整个表达式的类型一致
 * 
 * */

 /*
  * 产生随机数
  * 1.创建能够产生随机数的对象
  * Random r=new Random();
  * 2.让产生随机数的这个对象调用方法来产生随机数
  * int rNumber=r.Next(1,10);
  * 范围在1-10，左闭右开
  *   





}
}
