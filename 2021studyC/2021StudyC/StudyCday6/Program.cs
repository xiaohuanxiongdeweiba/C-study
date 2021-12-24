using System;

namespace StudyCday6
{
    public enum State
    {
        online = 1,
        offline,
        leave,
        busy

    }

    public struct Person
    {
        public string name;
        public int age;
        public char gender;
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region //枚举
            ////枚举
            //Console.WriteLine("请选择您的状态：1-online，2-offline，3-leave，4-busy");
            //string input = Console.ReadLine();


            //State qqState = (State)Enum.Parse(typeof(State), input);
            //Console.WriteLine("您的状态是{0}", qqState);
            ///*
            
            //switch (input)
            //{
            //    case "1":
            //        State qqState=(State)Enum.Parse(typeof(State), input);
            //        break;

            //    case "2":
            //        break;

            //    case "3":
            //        break;

            //    case "4":
            //        break;
            //}
            //*/
            #endregion
            #region //结构
            /*一次性声明多个不同类型的变量
             * public struct 结构名
             * {
             * 成员//字段
             * }
             */
            #endregion



            //Person zSan;
            //zSan.name = "张三";
            //zSan.age = 18;
            //zSan.gender = '男';

            #region //数组

            //数组类型[] 数组名 = new 数组类型[数组长度]
            //int[] nums = new int[10];

            #endregion
            #region //方法
            //
            //public static 返回值类型 方法名（[参数列表]）
            //{
            //方法体；
            //}

            #endregion
            return;





        }
    }
}
