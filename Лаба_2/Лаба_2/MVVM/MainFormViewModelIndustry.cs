using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using MyIndustry.Model;
using MyIndustry.Interfaces;
using TestWindowsFormsApp.Annotations;

namespace MyIndustry
{
    public sealed class MainFormViewModelIndustry : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly Industry _industry;

        private string _title;

        public ICollection<IPlant> Plants => _industry.Plants;

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

        public void Add(string title, int power)
        {
            _industry.AddItem(title, power);
        }

        public void Remove(string title)
        {
            var plant = _industry.SearchItem(title);
            _industry.RemoveItem(plant);
        }

        public void Change(string title, string newTitle, int power)
        {
            var plant = _industry.SearchItem(title);
            _industry.ChangeItem(plant, newTitle, power);
        }

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged( string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        //[CallerMemberName]
    }
}
