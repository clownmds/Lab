using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using MyIndustry.Model;
using MyIndustry.Interfaces;
using TestWindowsFormsApp.Annotations;
using System.Xml.Serialization;
using System.IO;

namespace MyIndustry
{
    public sealed class MainFormViewModelIndustry : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Industry _industry;

        private string _title;

        public List<Plant> Plants 
        {
            get => _industry.Plants;
            private set
            {
                Plants = value;
                OnPropertyChanged(nameof(Plants));
    }
}
        public MainFormViewModelIndustry(Industry industry)
        {
            _industry = industry;
            _title = industry.Title;
        }

        public string Title
        {
            get => _title;
            private set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        public void AddMetalWorking( int power)
        {
            _industry.AddItemMetalWorking( power);
            OnPropertyChanged(nameof(Plants));
        }

        public void AddWoodWorking(int power)
        {
            _industry.AddItemWoodWorking(power);
            OnPropertyChanged(nameof(Plants));
        }

        public void Remove(string title)
        {
            _industry.RemoveItem(title);
            OnPropertyChanged(nameof(Plants));
        }

        public void Change(string title, int power)
        {           
            _industry.ChangeItem(title, power);
            OnPropertyChanged(nameof(Plants));
        }

        public void Deserialaze()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Industry));
            using (FileStream fs = new FileStream("industry.xml", FileMode.OpenOrCreate))
            {
                 _industry = (Industry)formatter.Deserialize(fs);
            }
            
        }

        public void Serialaze()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Industry));
            using (FileStream fs = new FileStream("industry.xml", FileMode.OpenOrCreate))
            { formatter.Serialize(fs, _industry);
            }
        }

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged( string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        //[CallerMemberName]
    }
}
