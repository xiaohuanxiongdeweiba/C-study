using System;

namespace 结构体练习
{

    public struct MyColor
    {
        public int _red;
        public int _green;
        public int _blue;
    }

    public struct Person
    {
        public string _name;
        public int _age;
        public Gender _gender;
    }

    public enum Gender
    {
        男,
        女,
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyColor newColor;
            newColor._red = 256;
            newColor._green = 0;
            newColor._blue = 0;

            Person zSan;
            zSan._name = "zhangsan";
            zSan._age = 18;
            zSan._gender = Gender.女;

            Console.WriteLine("Hello World!");
        }
    }
}
