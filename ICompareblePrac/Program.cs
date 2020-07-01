using System;
using System.Collections.Generic;

namespace ICompareblePrac
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int CompareTo(object obj)
        {
            //return this.Price - ((Product)obj).Price;
            // return this.Name[0] - ((Product)obj).Name[0];
            return this.Price.CompareTo(((Product)obj).Price);
        }
        public override string ToString()
        {
            return Name + " : " + Price + "원";
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>()
            {
                new Product(){Name="고구마", Price=1000}
                , new Product(){Name="사과", Price=1500}
                , new Product(){Name="바나나", Price=2000}
                , new Product(){Name="감자", Price=3000}
            };
            //list.Sort();
            
            foreach(var item in list)
            {
                Console.WriteLine(list);
            }
        }
    }
}
