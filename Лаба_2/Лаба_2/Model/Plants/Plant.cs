﻿using MyIndustry.Interfaces;
using System.Collections.Generic;

namespace MyIndustry.Model
{
    public abstract class Plant : IPlant
    {
        public Plant(int power)
        {
            Title = "";
            Power = power;
        }

        public string Title { get; set; }
        public int Power { get; set; }

        public ICollection<IProduct> Products { get; set; }

        public abstract void Delete(IProduct product);
        public abstract void ViewProducts();
        public abstract void ChangeProduct();
        public abstract void Add(IProduct product);
    }
}
