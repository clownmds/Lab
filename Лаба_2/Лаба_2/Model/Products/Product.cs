using MyIndustry.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyIndustry.Model
{
    public abstract class Product : IProduct
    {
        public string Title { get; }
        public int TimeCosts { get; }
        public int CostPrice { get; }
        
        public Product(string title,int timeCosts, int price)
        {
            Title = title;
            TimeCosts = timeCosts;
            CostPrice = price;
        }


    }
}
