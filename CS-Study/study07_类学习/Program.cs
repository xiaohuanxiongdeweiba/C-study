using System;

namespace study07_类学习
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();//实例化一个对象
            person.Age = 12;//对象的初始化
            person.Name = "张三";
            Console.WriteLine("Hello World!");
            Console.WriteLine("{0},{1}",person.Name,person.Age);
            Console.ReadLine();

        }

        /*
         * 静态和非静态区别
         * 在非静态类中，可以有静态方法，也可以有非静态方法（实例成员）
         * 在调用静态方法时，需要类名。静态方法名
         * 调用非静态方法时，需要实例名（对象名）。非静态方法。
         * 静态函数中，只能访问静态成员，不能访问实例成员。
         * 实例函数中，两个都能访问。
         * 静态类职能有静态成员
         * 静态类不能被实例化
         * 
         * 
         * */

        
    }
}
