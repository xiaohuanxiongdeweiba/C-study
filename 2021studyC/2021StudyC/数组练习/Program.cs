using System;

namespace 数组练习
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "老杨", "老牛", "老虎", "老王", "老赵", "老刘", "老马" };
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i]+"|");

            }
            Console.Write("\b");

        }
    }
}
