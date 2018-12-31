using MyIndustry.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace MyIndustry.Model
{
    [XmlInclude(typeof(MetalWorking))]
    [XmlInclude(typeof(WoodWorking))]
    [Serializable]
    public sealed class Industry : IIndustry 
    {
        public string Title { get; set; }

        int countMetall = 1;
        int countWood = 1;

        public Industry()
        { }

        public Industry(string title)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
        }
        
        public List<Plant> Plants { get; private set; } = new List<Plant>();

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

        public List<Plant> ViewItems()
        {
            return (List<Plant>)Plants;
        }

        public void ChangeItem(string title, int power)
        {
            var plant = SearchItem(title);
            plant.Power = power;
        }

        public Plant SearchItem(string title)
        {
            var plant = from p in Plants
                        where p.Title == title
                        select p;
            return plant.First();
        }
    }
}
