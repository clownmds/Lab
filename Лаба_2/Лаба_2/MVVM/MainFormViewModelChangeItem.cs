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
    public partial class MainFormViewModelChangeItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly Industry _industry;

        public ICollection<IPlant> Plants => _industry.Plants;

        public MainFormViewModelChangeItem(Industry industry)
        {
            _industry = industry;
        }

        public void Change(string title)
        {
        }

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
