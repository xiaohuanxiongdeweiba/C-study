using System;
using System.IO;

namespace study10_file
{
    class Program
    {
        static void Main(string[] args)

        {
            string pathString = @"D:\xiaohuanxiong\C-study\知识点";
            Path.GetFileName(pathString);
            Path.GetFileNameWithoutExtension(pathString);//不包括扩展名
            Path.GetExtension(pathString);//直接获得扩展名
            Path.GetDirectoryName(pathString);//获得所在文件夹的名称
            Path.GetFullPath(pathString);//获得全路径
            Path.Combine(pathString);//两个路径合并，获得一个路径


            //File.Create(@"D:\xiaohuanxiong\C-study\知识点\new.txt");//创建一个文件
            //File.Delete(@"D:\xiaohuanxiong\C-study\知识点\new.txt");//删除一个文件
            File.Copy(@"D:\xiaohuanxiong\C-study\知识点\new.txt", @"D:\xiaohuanxiong\C-study\知识点\new1.txt");
            //复制一个文件
            File.ReadAllBytes();//读取
            Console.WriteLine("创建成功");
            Console.ReadLine();


            
        }
    }
}
/*
 * Path.getfilename();
 * */
