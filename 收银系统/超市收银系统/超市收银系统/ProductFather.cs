using System;
using System.Collections.Generic;
using System.Text;

namespace 超市收银系统
{
    class ProductFather
    {
        private double price;
        private string name;
        private string iD;


        
        public string ID { get => iD; set => iD = value; }
        public double Price { get => price; set => price = value; }
        public string Name { get => name; set => name = value; }

        public ProductFather(double price, string name, string id)
        {
            this.Price = price;
            this.Name = name;
            this.ID = id;
        
        }
    
    }
}
