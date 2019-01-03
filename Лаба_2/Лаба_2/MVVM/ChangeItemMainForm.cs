using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyIndustry.MVVM
{
    public partial class ChangeItemMainForm : Form
    {
        private MainFormViewModel _model;

        private MainFormViewModel Model
        {
            get => _model;
            set
            {
                if (_model != null)
                {
                    _model.PropertyChanged -= _model_PropertyChanged;
                }
                _model = value;
                _model.PropertyChanged += _model_PropertyChanged;
            }
        }

        private string title;
        private int power;

        private void _model_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(MainFormViewModel.Plants))
                IndustryMainForm.IMF.RefreshList();
        }

        public ChangeItemMainForm(MainFormViewModel model, string title)
        {
            InitializeComponent();
            Model = model;
            this.title = title;
        }

        private void ChangeTextBox_TextChanged(object sender, EventArgs e)
        {
            power = int.Parse(changeItemTextBoxPower.Text);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (power != 0)
                Model.Change(title, (int)power);
            Close();
        }

        private void ChangeItemMainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
