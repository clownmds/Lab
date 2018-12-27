using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyIndustry.Interfaces;

namespace MyIndustry.Model
{
    public class WoodWorking //:Plant
    {
        public WoodWorking(string title, int power)
        {
            Title = title;
            Power = power;
            Products = new List<IProduct>();
        }

        public string Title { get; set; }
        public int Power { get; set; }

        public ICollection<IProduct> Products { get; set; }

         public void Add(IProduct product)
        {
        Products.Add(product);
        }

        public void Delete(IProduct product)
        {
        Products.Remove(product);
        }
    }
}
