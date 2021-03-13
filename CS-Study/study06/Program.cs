using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace study06
{
    public enum Gender
    {
        男,
        女
       
    }

    public enum QQstate
    {
        online,
        offline,
        Qme
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 10;
            //Gender gender = Gender.男;
            //QQstate state = QQstate.offline;
            //Console.Write(state);
            //Console.ReadKey();

            //Console.WriteLine(Convert.ToInt32(state));
            //Console.ReadKey();

            //Console.WriteLine("请输入你的在线状态");
            //string state = ""; 
            //state  = Console.ReadLine();

        }
    }



    /*
     * 枚举
     * 是一个变量类型
     * public enum 名字
     * {
     * 值1，
     * 值2，
     * 值3
     * .........
     * }
     * 
     * 放在命名空间下面，类外面。
     * */

/*
 *枚举，string， int之间的转换
 * 
 * 枚举和int之间可以互相转换，兼容的。
 按照顺序从0开始，0,1,2,3，中间的某个可直接复制，之后递增。
 遇见转换不了得，直接输出数字。


所有类型都能转换成string类型
toString（）

int n1=10;
n1.toString();


 */

/*
 * 将字符串转换成枚举类型
 * 枚举和string不是默认兼容的
 * QQstate state=(QQstate)Enum.Parse(typeof(QQstate),string);
 * 如果要转换的string是文本，不存在的话抛出异常
 * 如果要转换的string是数字，即使不存在的话也不抛出异常。
 * */

/*
 * 结构
 * 
 * public struct 结构名
 * {
 * 成员
 * }
 * 
 * public struct Person
 * {
 * public string _name;//字段 字段可以存多个值，变量只能存一个。字段命名前面加一个下划线
 * public int _age;
 * public char _gender;
 * }
 *
 *声明：
 * Person zsPerson;
 * Person liPerson;
 * 
 * zsPerson._name="张三";
 * 
 * 
 * */

    /*
     * 数组
     * 
     * 数组类型【】 数组名称=new 数组类型【数组长度】；
     * int[] timer=new int[10];*/

    /*
     * 
     * 方法的语法
     * public static 返回值类型 方法名（{参数列表}）
     * {方法体；}
 
}
