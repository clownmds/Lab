using MyIndustry.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using MyIndustry;

namespace MyIndustry.Model
{
    public sealed class Industry : IIndustry
    {
        public string Title { get; private set; }

        int countMetall = 1;
        int countWood = 1;

        public Industry(string title)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
        }

        public ICollection<IPlant> Plants { get; private set; } = new List<IPlant>();

        public void Deserialize(IndustryDTO industryDTO)
        {
            Title = industryDTO.Title;
            Plants.Clear();
            foreach (IPlant p in industryDTO.Plants)
                Plants.Add(p);
            ViewItems();
        }

        public void AddItemMetalWorking(int power)
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

        public void Serialize()
        {
            var industryDTO = new IndustryDTO();
            industryDTO.Title = Title;
            foreach (Plant p in Plants)                    
                industryDTO.Plants.Add(p);
            XmlSerializer formatter = new XmlSerializer(typeof(IndustryDTO));
            using (FileStream fs = new FileStream("industryDTO.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, industryDTO);
            }
        }

        public void Deserialize()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(IndustryDTO));
            using (FileStream fs = new FileStream("industryDTO.xml", FileMode.OpenOrCreate))
            {
                var industryDTO = (IndustryDTO)formatter.Deserialize(fs);
                Title = industryDTO.Title;
                Plants.Clear();
                foreach (IPlant p in industryDTO.Plants)
                    Plants.Add(p);
            }
        }
    }
}
