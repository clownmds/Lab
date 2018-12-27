using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyIndustry.Interfaces;

namespace MyIndustry.Model
{
    public class MetalWorking //: Plant
    {
        
        public MetalWorking(string title , int power)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Power = power;
        }

        public string Title { get; set; }
        public int Power { get; set; }

        public ICollection<IProduct> Products { get; set; } = new List<IProduct>();

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
