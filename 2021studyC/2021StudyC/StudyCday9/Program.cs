using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudyCday9
{
    class Program
    {
        static void Main(string[] args)
        {
            Person zhangSan = new Person();
            zhangSan.Name = "zhangsan";
            zhangSan.Age = 18;
            zhangSan.Gender = 'n';
            zhangSan.JieShao();
            Console.ReadKey();
            /*
             * 类
             * public class 类名
             * {
             * 字段;
             * 属性;
             * 方法;
             * }
             * 
             * 写好类后，需要创建对象，这个过程叫做类的实例化， 使用关键字new
             * 
             * this表示当前这个类的对象
             */

        }
    }
}
