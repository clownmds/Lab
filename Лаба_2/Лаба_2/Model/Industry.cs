using MyIndustry.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyIndustry.Model
{
    public sealed class Industry : IIndustry
    {
        public Industry(string title)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
        }

        public string Title { get; }
        int countMetall = 1;
        int countWood = 1;

        public ICollection<IPlant> Plants { get; private set; } = new List<IPlant>();

        public void AddItemMetalWorking( int power)
        {
                var plant = new MetalWorking(countMetall, power);
                Plants.Add(plant);
            countMetall++;
        }

        public void AddItemWoodWorking(int power)
        {
            var plant = new WoodWorking(countWood, power);
            Plants.Add(plant);
            countWood++;
        }

        public void RemoveItem(string title)
        {

            var plant = SearchItem(title);
            Plants.Remove(plant);
        }

        public List<IPlant> ViewItems()
        {
            return (List<IPlant>)Plants;
        }

        public void ChangeItem(string title, int power)
        {
            var plant = SearchItem(title);
            plant.Power = power;
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
