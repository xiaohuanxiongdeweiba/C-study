using System;

namespace study08
{
    class Program
    {
        static void Main(string[] args)
        {
            char chs = '-';
            string date = "2008-08-08";
            string[] dataChange= date.Split(chs, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("{0}年{1}月{2}日", dataChange[0], dataChange[1], dataChange[2]);
            Console.ReadLine();

            Console.WriteLine("Hello World!");
        }
    }
}
/*
 * 值类型和引用类型
 * 存储的地方不一样
 * 引用的传递方式不一样
 * 
 * 堆、栈、静态存储区域
 * 
 * 值类型;
 * int double bool char struct enum decimal
 * 存储在内存的栈中
 * 
 * 引用类型
 * string、自定义类
 * 存储在堆中
 * */


/*
 * 字符串的方法
 * string. length  获得字符串的字符个数
 * string.ToUpper() 转换成大写
 * string.ToLower() 转换成小写
 * string.Equals(string value，StringComparison.OrdinalIgnoreCase) 比较两个字符串是否相同，可选择是否比较大小写，返回bool
 * 
 * 
 * 
 * 字符串的分割
 * string/Split(不想要的字符的数组 chs,stringsSplitOptions.RemoveEmptyEntries(移除空字符))
 * char[] chs={"","_"}
 * 
 * 
 * 判断字符串中师傅包含某字符
 * string.contains()
 * 替换
 * stirng.Replace("被替换的"。"替换后的") 返回字符串
 * 
 * substring 截取字符串，返回字符串
 * string2=string1.substring(int，x),从指定索引截取到x
 * 
 * str.startswith("string")判断是否以string开头
 * str.endsswith("string")判断是否以string结尾
 * 
 * str.Indexof('char'，x)  查找char的最开始的位置, 从x开始找，包括x，找不到返回-1
 * str.LastIndexof('char')找最后一次出现的位置
 * 
 * string.trim()去所有前面的和后面的空格
 * str.trimstart()去前面
 * str.trimend(）去后面
 * 
 * isnullorEmpty()判断是否为空
 * 
 * string.join(用作分隔符的字符'|',要分割的字符串数组)
 * */
