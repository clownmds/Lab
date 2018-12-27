using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MyIndustry
{
    public partial class MainFormIndystry : Form
    {
        private MainFormViewModelIndustry _model;        

        private MainFormViewModelIndustry Model
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

        private string addTitle;
        private int? addPower;
        private int indexItem;

        private void _model_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(MainFormViewModelIndustry.Title))
                titleIndustry.Text = Model.Title.ToString();
            else if (e.PropertyName == nameof(MainFormViewModelIndustry.Plants))
                RefreshList();

        }
         
        private void RefreshList()
        {
            plantListBox.Items.Clear();
            powerListBox.Items.Clear();
            foreach (var item in Model.Plants)
            {
                plantListBox.Items.Add(item.Title);
                powerListBox.Items.Add(item.Power);
            }
        }

        public MainFormIndystry(MainFormViewModelIndustry model)
        {
            InitializeComponent();
            Model = model;
            titleIndustry.Text = Model.Title.ToString();
        }

        private Button viewButton;
        private Button addButton;
        private ListBox plantListBox;
        private ListBox powerListBox;
        private Button changeButton;
        private Button deleteButton;
        private TextBox titleIndustry;
        private Label name;
        private Label titlePlant;
        private Label power;
        private TextBox addPlantTextBox;
        private TextBox addPowerTextBox;
        private Label label1;
        private Label label2;
        private Button exitButton;

        private void addPlantTextBox_TextChanged(object sender, EventArgs e)
        {
            if (addPlantTextBox.Text != null && addPowerTextBox.Text != null)
            {
                addTitle = addPlantTextBox.Text;
                addPower = int.Parse(addPowerTextBox.Text);
            }
        }

        private void plantListBox_Click(object sender, EventArgs e)
        {
            indexItem = plantListBox.Items.IndexOf(plantListBox.Text);
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
            addTitle = plantListBox.Items[indexItem].ToString();
            ChangeItemMainForm form = new ChangeItemMainForm(Model,addTitle);
            form.Show();
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (addTitle!= null && addPower.HasValue)
                Model.Add(addTitle, (int)addPower);            
            RefreshList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            addTitle = plantListBox.Items[indexItem].ToString();
            Model.Remove(addTitle);
            RefreshList();
        }

        private void InitializeComponent()
        {
            this.viewButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.plantListBox = new System.Windows.Forms.ListBox();
            this.powerListBox = new System.Windows.Forms.ListBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.titleIndustry = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.titlePlant = new System.Windows.Forms.Label();
            this.power = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.addPlantTextBox = new System.Windows.Forms.TextBox();
            this.addPowerTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(304, 53);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(75, 23);
            this.viewButton.TabIndex = 0;
            this.viewButton.Text = "Показать";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(304, 213);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // plantListBox
            // 
            this.plantListBox.FormattingEnabled = true;
            this.plantListBox.Location = new System.Drawing.Point(12, 83);
            this.plantListBox.Name = "plantListBox";
            this.plantListBox.Size = new System.Drawing.Size(120, 95);
            this.plantListBox.TabIndex = 2;
            this.plantListBox.Click += new System.EventHandler(this.plantListBox_Click);
            // 
            // powerListBox
            // 
            this.powerListBox.FormattingEnabled = true;
            this.powerListBox.Location = new System.Drawing.Point(152, 83);
            this.powerListBox.Name = "powerListBox";
            this.powerListBox.Size = new System.Drawing.Size(120, 95);
            this.powerListBox.TabIndex = 3;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(304, 83);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 4;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(304, 112);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // titleIndustry
            // 
            this.titleIndustry.Location = new System.Drawing.Point(12, 24);
            this.titleIndustry.Name = "titleIndustry";
            this.titleIndustry.Size = new System.Drawing.Size(100, 20);
            this.titleIndustry.TabIndex = 6;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(13, 5);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(83, 13);
            this.name.TabIndex = 7;
            this.name.Text = "Наименование";
            // 
            // titlePlant
            // 
            this.titlePlant.AutoSize = true;
            this.titlePlant.Location = new System.Drawing.Point(13, 58);
            this.titlePlant.Name = "titlePlant";
            this.titlePlant.Size = new System.Drawing.Size(26, 13);
            this.titlePlant.TabIndex = 8;
            this.titlePlant.Text = "Цех";
            // 
            // power
            // 
            this.power.AutoSize = true;
            this.power.Location = new System.Drawing.Point(149, 58);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(60, 13);
            this.power.TabIndex = 9;
            this.power.Text = "Мощность";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(99, 253);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addPlantTextBox
            // 
            this.addPlantTextBox.Location = new System.Drawing.Point(12, 213);
            this.addPlantTextBox.Name = "addPlantTextBox";
            this.addPlantTextBox.Size = new System.Drawing.Size(100, 20);
            this.addPlantTextBox.TabIndex = 11;
            addPlantTextBox.TextChanged += new System.EventHandler(this.addPlantTextBox_TextChanged);
            // 
            // addPowerTextBox
            // 
            this.addPowerTextBox.Location = new System.Drawing.Point(152, 213);
            this.addPowerTextBox.Name = "addPowerTextBox";
            this.addPowerTextBox.Size = new System.Drawing.Size(100, 20);
            this.addPowerTextBox.TabIndex = 12;
            addPowerTextBox.TextChanged += new System.EventHandler(this.addPlantTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Добавить цех";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Мощность";
            // 
            // MainFormIndystry
            // 
            this.ClientSize = new System.Drawing.Size(407, 277);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addPowerTextBox);
            this.Controls.Add(this.addPlantTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.power);
            this.Controls.Add(this.titlePlant);
            this.Controls.Add(this.name);
            this.Controls.Add(this.titleIndustry);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.powerListBox);
            this.Controls.Add(this.plantListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.viewButton);
            this.Name = "MainFormIndystry";
            this.Load += new System.EventHandler(this.MainFormIndystry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void MainFormIndystry_Load(object sender, EventArgs e)
        {

        }
    }
}
