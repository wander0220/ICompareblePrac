using System;
using System.Collections.Generic;

namespace ICompareblePrac
{

    interface ITest
    {

    }
    class TesetClass : IBasic
    {
        int IBasic.TestProperty { 
            get => 0; 
            set => value=0; 
        }

        int IBasic.TestInstanceMethod()
        {
            throw new NotImplementedException();
        }
    }
    class Product : IComparable
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int CompareTo(object obj)
        {
            //return this.Price - ((Product)obj).Price;
            //return this.Name[0] - ((Product)obj).Name[0];
            return this.Name.CompareTo(((Product)obj).Name);
            //return this.Price.CompareTo(((Product)obj).Price);
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
                Console.WriteLine(item);
            }
        }
    }
}
