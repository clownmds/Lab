using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MyIndustry.MVVM
{
    public partial class IndustryMainForm : Form
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

        private string tempTitle;
        private int? tempPower;

        public static IndustryMainForm IMF { get; set; }

        private void _model_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(MainFormViewModel.Plants))
                RefreshList();
        }

        public void RefreshList()
        {
            plantListBox.Items.Clear();
            powerListBox.Items.Clear();
            foreach (var item in Model.Plants)
            {
                plantListBox.Items.Add(item.Title);
                powerListBox.Items.Add(item.Power);
            }
        }

        private void addPowerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (addPowerTextBox.Text != "")
                tempPower = int.Parse(addPowerTextBox.Text);
        }

        private void plantListBox_Click(object sender, EventArgs e)
        {
            tempTitle = plantListBox.Text;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            tempTitle = plantListBox.Text;
            ChangeItemMainForm form = new ChangeItemMainForm(Model, tempTitle);
            form.Show();
        }

        private void addMetalWorkingButton_Click(object sender, EventArgs e)
        {
            if (tempPower != 0)
                Model.AddMetalWorking((int)tempPower);
        }

        private void addWoodWorkingButton_Click(object sender, EventArgs e)
        {
            if (tempPower != 0)
                Model.AddWoodWorking((int)tempPower);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Model.Remove(tempTitle);
        }

        private void SerializeButton_Click(object sender, EventArgs e)
        {
            Model.Serialize();
        }

        private void DeserializeButton_Click(object sender, EventArgs e)
        {
            Model.Deserialize();
        }
    
    public IndustryMainForm(MainFormViewModel model)
        {
            InitializeComponent();
            Model = model;
            titleIndustry.Text = Model.Title.ToString();
            IMF = this;
        }
    }
}
