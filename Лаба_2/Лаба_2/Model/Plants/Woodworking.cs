using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyIndustry.Interfaces;

namespace MyIndustry.Model
{
    public class WoodWorking :Plant
    {
        public WoodWorking()
        { }

        public WoodWorking(int number, int power) : base( power)
        {
            Title = "Деревообрабатывающий цех №"+number.ToString();
            Power = power;
            Products = new List<IProduct>();
        }

        public override void Add(IProduct product)
        {
            Products.Add(product);
        }

        public override void Delete(IProduct product)
        {
            Products.Remove(product);
        }

        public override void ViewProducts()
        { }

        public override void ChangeProduct()
        { }
    }
}
