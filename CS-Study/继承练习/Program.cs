using System;

namespace 继承练习
{
    class Program
    {
        static void Main(string[] args)
        {

            Reporter reporter = new Reporter("张三", "拍照", 28, '男');
            Driver driver = new Driver("李四", 46, '男', 23);
            Computer computer = new Computer("王五", 23, '男', 3);

            reporter.ReporterSayHello();
            driver.DriverSayHello();
            computer.ComputerSayHello();

            Console.WriteLine("Hello World!");
            Console.ReadKey();
            //记者：我是一个记者，我的爱好是偷拍，我的年龄是34，我是男的
            //司机: 我叫舒马赫，我的年龄是43 我是男的，驾龄32 年
            //程序员 ： 我叫孙权，年龄23，男生，我的工作年限为3年
            //共有属性：年龄，性别

        }
    }

    public class Person
    {
        private string _name;
        private int _age;
        private char _gender;

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public char Gender { get => _gender; set => _gender = value; }

        //构造函数
        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
    }
    public class Reporter : Person
    {
        private string _hobby;

        public string Hobby { get => _hobby; set => _hobby = value; }

        public void ReporterSayHello()
        {
            Console.WriteLine("我叫{0},我是一名记者，我的爱好是{1},我的年龄是{2},我的性别是{3}", this.Name, this.Hobby, this.Age, this.Gender);
        }

        //构造函数
        public Reporter(string name, string hobby, int age, char gender) : base(name, age, gender)
        {
            this.Hobby = hobby;
        }
    }

    public class Driver : Person
    {
        private int _workYear;

        public int WorkYear { get => _workYear; set => _workYear = value; }


        public void DriverSayHello()
        {
            Console.WriteLine("我叫{0},我是一名司机,我的年龄是{1},我的性别是{2}，我工作年龄是{3}", this.Name, this.Age, this.Gender,this.WorkYear);

        }

        //构造函数

        public Driver(string name, int age, char gender, int workYear) : base(name, age, gender)
        {
            this.WorkYear = workYear;
        }
    }
    //程序员 ： 我叫孙权，年龄23，男生，我的工作年限为3年
    public class Computer : Person
    {
        private int _workYear;
        public int WorkYear { get => _workYear; set => _workYear = value; }

        public Computer(string name, int age, char gender, int workYear) : base(name, age, gender)
        {
            this.WorkYear = workYear;
        }

        public void ComputerSayHello()
        {
            Console.WriteLine("我叫{0},我是一个程序员，我是{1}的，我的年龄是{2},我工作{3}年了", this.Name, this.Gender, this.Age, this.WorkYear);
        }

    }

}
