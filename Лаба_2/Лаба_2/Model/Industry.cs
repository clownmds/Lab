using MyIndustry.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyIndustry.Model
{
    public sealed class Industry : iIndustry
    {
        public Industry(string title)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
        }

        public string Title { get; }

        public ICollection<IPlant> Plants { get; private set; } = new List<IPlant>();

        public void AddItem(string title, int power)

        {
                var plant = new Plant(title, power);
                Plants.Add(plant);
                
        }

        public void RemoveItem(IPlant plant)
        { 
            Plants.Remove(plant);
        }

        public List<IPlant> ViewItems()
        {
            return (List<IPlant>)Plants;
        }

        public void ChangeItem(IPlant plant,string title, int power)
        {
            Plants.Remove(plant);
            AddItem(title, power);
        }

        public IPlant SearchItem(string title)
        {
            var plant = from p in Plants
                        where p.Title == title
                        select p;
            return plant.First();
        }
    }
}
