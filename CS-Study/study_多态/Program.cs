using System;

namespace study_多态
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
/*
 * 多态概念
 * 让一个对象能够表现出多种的类型
 * 
 * 实现多态的手段
 * 1.虚方法： 
 *将父类方法前面标记为虚方法 ，使用关键字 virtual ，这个函数可以被子类重新写
 *子类方法前面加关键字 override
 * 
 * */


/*
 * 当父类中的方法不知道如何去实现的时候，可以考虑将父类方法写成抽象方法，父类写成抽象类
 * 抽象类不让创建对象
 * 
 * 关键字
 * abstract
 * 抽象方法不写方法体
 * 
 * public abstract class Animal
 * {
 * public abstract void Bark();
 * 里面的属性，方法，字段不需要都写成abstract
 * 并且子类要实现父类中所有的抽象成员。要重写父类中的所有抽象成员，除非子类自己也是抽象类
 * }
 * Animal a=new Dog(); 将子类赋值给父类。
 * a.Bark();(调用的父类方法，输出的是子类的方法、)
 * 
 * */
