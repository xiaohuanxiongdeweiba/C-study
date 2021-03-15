
using System;
using System.Collections.Generic;
using System.Text;

namespace study07_类学习
{
    public class Person
    {
        int _age;
        string _name;

        public int Age { get => _age; set => _age = value; }
        public string Name { get => _name; set => _name = value; }

        public void Test()
        {
            Console.WriteLine();


        }

        /*构造函数
         * 用来初始化对象，给对象的每个属性赋值
         * 是一个特殊的方法。
         * 没有返回值，连void也不能写
         * 名称必须跟类名一样。
         * 创建对象的时候会执行构造函数
         * 构造函数可以重载
         * */

        /*析构函数
         * 当程序结束的时候，析构函数才执行
         * 帮助我们释放资源，想程序结束时立即释放资源，则用西沟函数。
         * ~类名（）
         * {
         * 语句；
         * }
         * 
         * */

        /*
         * 命名空间
         * 解决类的重名问题，可以看做类的文件夹
         * alt+shift+F10
         * 
         * 在一个项目中，引用另一个项目的类
         * 1.添加引用，引用-右键，添加引用-项目-选择添加。
         * 2.引用命名空间。
         * */
    }
}
