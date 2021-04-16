using System;
using System.Collections.Generic;
using System.Text;

namespace 超市收银系统
{
    class CangKu
    {
        List<List<ProductFather>> list = new List<List<ProductFather>>();
        //List<ProductFather> list2 = new List<ProductFather>();

        //存储仓库
        //在创建仓库的时候就创建货架,构造函数
        public CangKu()
        {
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());

           
        }
        /// <summary>
        /// 进货
        /// </summary>
        /// <param name="strType">货物类型</param>
        /// <param name="count">数量</param>
        public void AddPro(string strType, int count)

        {
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer":
                        list[0].Add(new Acer(10000,"鸿基电脑笔记本",Guid.NewGuid().ToString()));
                        break;
                    case "Banana":
                        list[1].Add(new Banana(10, "香蕉", Guid.NewGuid().ToString()));
                        break;
                    case "SamSung":
                        list[2].Add(new SamSung(3000, "三星", Guid.NewGuid().ToString()));
                        break;
                    case "JiangYou":
                        list[3].Add(new JiangYou(5, "酱油", Guid.NewGuid().ToString()));
                        break;





                        
                }
            }
        }
        /// <summary>
        /// 取货
        /// </summary>
        /// <param name="strType">货物类型</param>
        /// <param name="count">数量</param>
        /// <returns></returns>
        public ProductFather[] GetPro(string strType, int count)
        {
            ProductFather[] proGet = new ProductFather[count];
            for (int i = 0; i < proGet.Length; i++)
            {
                switch (strType)
                {
                    case "Acer":
                        proGet[i] = list[0][0];
                        list[0].RemoveAt(0);
                        break;
                    case "Banana":
                        proGet[i] = list[1][0];
                        list[1].RemoveAt(0);
                        break;
                    case "SamSung":
                        proGet[i] = list[2][0];
                        list[2].RemoveAt(0);
                        break;
                    case "Jiang":
                        proGet[i] = list[3][0];
                        list[3].RemoveAt(0);
                        break;

                }
            }
                return proGet;
        }

        /// <summary>
        /// 展示货架货物
        /// </summary>
        public void ShowPro()
        {
            foreach (var item in list)
            {
                Console.WriteLine("我们超市有：" + item[0].Name + "," + item.Count + "个，单价为：" + item[0].Price);
            
            }
        }
    }
}
