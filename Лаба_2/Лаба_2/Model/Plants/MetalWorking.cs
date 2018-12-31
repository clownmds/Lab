using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyIndustry.Interfaces;

namespace MyIndustry.Model
{
    public class MetalWorking : Plant
    {
        public MetalWorking()
        { }

        public MetalWorking (int number,int power): base( power)
        {
            Title = "Металлообрабатывающий цех №"+number.ToString();
            Power = power;
        }
        
        public override void Add(Product product)
        {
        Products.Add(product);
        }

        public override void Delete(Product product)
        {
        Products.Remove(product);
        }
        
        public override void ViewProducts()
        { }

        public override void ChangeProduct()
        { }
    }
}
