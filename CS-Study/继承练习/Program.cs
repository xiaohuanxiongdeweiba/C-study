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
/*里式转换
 * 1.子类可以赋值给父类
 * 如果有一个地方需要一个父类作为参数，我们可以给一个子类作为代替
 * Student s=new Student();
 * Person p=s;
 * 2.如果父类中装的是子类对象，那么可以将这个父类强转为子类对象
 * Student ss=(Student)p;
 * 
 * 
 * 3.类型判断
 * if(p is Teacher)
 * {
 * Teacher ss=(Teacher)p;
 * ss.TeacherSayHello();
 * }
 * else{
 * 转换失败
 * }
 * is:表类型转换，是则是true，不是是false
 * as：表示类型转换，如果能转换，返回这个对象，不能则返回null
 *   Student s=p as Student();;

 * 
 * */