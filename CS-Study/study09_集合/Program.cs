using System;
using System.Collections;

namespace study09_集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add("张三");
            //list.Add(true);
            ////添加单个元素，list.add
            ////添加数组或者集合，list.AddRange
            //list.AddRange(new int[] { 1, 2, 3, 4 });
            //list.AddRange(list);

            //for(int i = 0; i < list.Count; i++) 
            //{
            //Console.WriteLine(list[i]);
            //}
            //Console.WriteLine(list.Count);







            Hashtable ht = new Hashtable();
            ht.Add(1, "zhangsan");
            ht.Add("name", "lisi");
            ht[6] = "新的赋值方式";
            int count=ht.Count;
            //根据键去找值
            //键必须是唯一的，值可以重复
            Console.WriteLine(ht["name"]);

            foreach (var item in ht.Keys)
            {
                Console.WriteLine(ht[item]);

            }

            foreach (var item in ht.Values)
            {
                Console.WriteLine(item);

            }


            Console.ReadKey();
        }
    }
}
//list.clear();
//移除所有元素
//list.remove();   移除某个元素, 写谁就删除谁
//list.removeAt(); 根据索引数删除，填入下标
//list.removeRange() 根据索引删除一定范围的元素 x,x
//list.reverse() 反转
//list.sort() 升序排列，需要元素类型可比较
//list.insert(1，“张三”) 在指定位置插入
//list,insertRange(0,string[]) 在指定位置插入数组
//list.contans(1) 判断是否包含某个元素，返回bool 类型
//list.capacity() 表示集合中可以包含的元素的个数

/*Hashtable
 * 
 * */

