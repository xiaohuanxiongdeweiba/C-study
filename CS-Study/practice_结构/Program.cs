using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practice_结构
{
    public enum Gender
    {
        男,
        女
    }
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

    class Program
    {
        static void Main(string[] args)
        {
            MyColor myColor;
            myColor._red = 255;
            myColor._green = 0;
            myColor._blue = 0;


            Person xiaolan;
            xiaolan._gender = Gender.女;
            xiaolan._age = 10;
            xiaolan._name = "xiaolan";

        }
    }
}
