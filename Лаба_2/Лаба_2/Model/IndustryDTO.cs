using System;
using System.Collections.Generic;
using MyIndustry;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace MyIndustry.Model
{
    [XmlInclude(typeof(MetalWorking))]
    [XmlInclude(typeof(WoodWorking))]
    [Serializable]
    public class IndustryDTO
    {
        public IndustryDTO()
        {
        }

        public IndustryDTO(string title, List<Plant> plants)
        {
            Title = title;
            Plants =plants;
        }

        public string Title { get; set; }

        public List<Plant> Plants { get; set; } = new List<Plant>();       
    }
}
