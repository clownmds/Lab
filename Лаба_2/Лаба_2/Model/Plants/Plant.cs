using MyIndustry.Interfaces;
using System.Collections.Generic;

namespace MyIndustry.Model
{
    public class Plant : IPlant
    {
        public Plant(string title,int power)
        {
            Title = title;
            Power = power;
        }

        public string Title { get; set; }
        public int Power { get; set; }

        public ICollection<IProduct> Products { get; set; }

     /*   public abstract void Delete();
        public abstract void ViewProducts();
        public abstract void ChangeProduct();
        public abstract void Add();*/
    }
}
