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

        public void AddMetalWorking( int power)
        {
            _industry.AddItemMetalWorking( power);
        }

        public void AddWoodWorking(int power)
        {
            _industry.AddItemWoodWorking(power);
        }

        public void Remove(string title)
        {
            _industry.RemoveItem(title);
        }

        public void Change(string title, int power)
        {           
            _industry.ChangeItem(title, power);
        }

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged( string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        //[CallerMemberName]
    }
}
