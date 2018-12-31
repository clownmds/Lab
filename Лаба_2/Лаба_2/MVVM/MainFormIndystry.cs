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

        private string tempTitle;
        private int tempPower;
        
        public static MainFormIndystry MFI { get; set; }

        private void _model_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(MainFormViewModelIndustry.Title))
                titleIndustry.Text = Model.Title.ToString();
            else if (e.PropertyName == nameof(MainFormViewModelIndustry.Plants))
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

        public MainFormIndystry(MainFormViewModelIndustry model)
        {
            InitializeComponent();
            Model = model;
            titleIndustry.Text = Model.Title.ToString();
            MFI = this;
        }

        
        private ListBox plantListBox;
        private ListBox powerListBox;
        private Button SerialazeButton;
        private Button DeserialazeButton;
        private Button changeButton;
        private Button deleteButton;
        private Button exitButton;
        private Button viewButton;
        private Button addMetalWorkingButton;
        private Button addWoodWorkingButton;
        private TextBox titleIndustry;
        private TextBox addPowerTextBox;
        private Label name;
        private Label titlePlant;
        private Label power;        
        private Label label2;

        private void addPowerTextBox_TextChanged(object sender, EventArgs e)
        {
                tempPower = int.Parse(addPowerTextBox.Text);
        }

        private void plantListBox_Click(object sender, EventArgs e)
        {
           tempTitle = plantListBox.Text;
            Console.WriteLine(tempTitle);
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
            ChangeItemMainForm form = new ChangeItemMainForm(Model,tempTitle);
            form.Show();            
        }

        private void addMetalWorkingButton_Click(object sender, EventArgs e)
        {
            if ( tempPower!=0)
                Model.AddMetalWorking( (int)tempPower);  
        }

        private void addWoodWorkingButton_Click(object sender, EventArgs e)
        {
            if ( tempPower!=0)
                Model.AddWoodWorking((int)tempPower);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Model.Remove(tempTitle);
        }

        private void SerialazeButton_Click(object sender, EventArgs e)
        {
            Model.Serialaze();
        }

        private void DeserialazeButton_Click(object sender, EventArgs e)
        {
            Model.Deserialaze();
        }

        private void InitializeComponent()
        {
            this.SerialazeButton = new System.Windows.Forms.Button();
            this.DeserialazeButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.addMetalWorkingButton = new System.Windows.Forms.Button();
            this.plantListBox = new System.Windows.Forms.ListBox();
            this.powerListBox = new System.Windows.Forms.ListBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.titleIndustry = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.titlePlant = new System.Windows.Forms.Label();
            this.power = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.addPowerTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addWoodWorkingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SerialazeButton
            // 
            this.SerialazeButton.Location = new System.Drawing.Point(167, 13);
            this.SerialazeButton.Name = "SerialazeButton";
            this.SerialazeButton.Size = new System.Drawing.Size(95, 23);
            this.SerialazeButton.TabIndex = 0;
            this.SerialazeButton.Text = "Сериализовать";
            this.SerialazeButton.UseVisualStyleBackColor = true;
            this.SerialazeButton.Click += new System.EventHandler(this.SerialazeButton_Click);
            // 
            // DeserialazeButton
            // 
            this.DeserialazeButton.Location = new System.Drawing.Point(287, 13);
            this.DeserialazeButton.Name = "DeserialazeButton";
            this.DeserialazeButton.Size = new System.Drawing.Size(106, 23);
            this.DeserialazeButton.TabIndex = 1;
            this.DeserialazeButton.Text = "Десериализация";
            this.DeserialazeButton.UseVisualStyleBackColor = true;
            this.DeserialazeButton.Click += new System.EventHandler(this.DeserialazeButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(361, 72);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(75, 23);
            this.viewButton.TabIndex = 0;
            this.viewButton.Text = "Показать";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // addMetalWorkingButton
            // 
            this.addMetalWorkingButton.Location = new System.Drawing.Point(118, 210);
            this.addMetalWorkingButton.Name = "addMetalWorkingButton";
            this.addMetalWorkingButton.Size = new System.Drawing.Size(154, 55);
            this.addMetalWorkingButton.TabIndex = 1;
            this.addMetalWorkingButton.Text = "Добавить металлообрабатывающий цех";
            this.addMetalWorkingButton.UseVisualStyleBackColor = true;
            this.addMetalWorkingButton.Click += new System.EventHandler(this.addMetalWorkingButton_Click);
            // 
            // plantListBox
            // 
            this.plantListBox.FormattingEnabled = true;
            this.plantListBox.Location = new System.Drawing.Point(12, 70);
            this.plantListBox.Name = "plantListBox";
            this.plantListBox.Size = new System.Drawing.Size(187, 108);
            this.plantListBox.TabIndex = 2;
            this.plantListBox.Click += new System.EventHandler(this.plantListBox_Click);
            // 
            // powerListBox
            // 
            this.powerListBox.FormattingEnabled = true;
            this.powerListBox.Location = new System.Drawing.Point(205, 70);
            this.powerListBox.Name = "powerListBox";
            this.powerListBox.Size = new System.Drawing.Size(71, 108);
            this.powerListBox.TabIndex = 3;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(360, 112);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 4;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(361, 155);
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
            this.titlePlant.Location = new System.Drawing.Point(13, 47);
            this.titlePlant.Name = "titlePlant";
            this.titlePlant.Size = new System.Drawing.Size(26, 13);
            this.titlePlant.TabIndex = 8;
            this.titlePlant.Text = "Цех";
            // 
            // power
            // 
            this.power.AutoSize = true;
            this.power.Location = new System.Drawing.Point(212, 47);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(60, 13);
            this.power.TabIndex = 9;
            this.power.Text = "Мощность";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(187, 283);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addPowerTextBox
            // 
            this.addPowerTextBox.Location = new System.Drawing.Point(12, 213);
            this.addPowerTextBox.Name = "addPowerTextBox";
            this.addPowerTextBox.Size = new System.Drawing.Size(100, 20);
            this.addPowerTextBox.TabIndex = 12;
            this.addPowerTextBox.TextChanged += new System.EventHandler(this.addPowerTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Мощность";
            // 
            // addWoodWorkingButton
            // 
            this.addWoodWorkingButton.Location = new System.Drawing.Point(287, 211);
            this.addWoodWorkingButton.Name = "addWoodWorkingButton";
            this.addWoodWorkingButton.Size = new System.Drawing.Size(148, 54);
            this.addWoodWorkingButton.TabIndex = 15;
            this.addWoodWorkingButton.Text = "Добавить деревообрабатывающий цех";
            this.addWoodWorkingButton.UseVisualStyleBackColor = true;
            this.addWoodWorkingButton.Click += new System.EventHandler(this.addWoodWorkingButton_Click);
            // 
            // MainFormIndystry
            // 
            this.ClientSize = new System.Drawing.Size(448, 318);
            this.Controls.Add(this.DeserialazeButton);
            this.Controls.Add(this.SerialazeButton);
            this.Controls.Add(this.addWoodWorkingButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addPowerTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.power);
            this.Controls.Add(this.titlePlant);
            this.Controls.Add(this.name);
            this.Controls.Add(this.titleIndustry);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.powerListBox);
            this.Controls.Add(this.plantListBox);
            this.Controls.Add(this.addMetalWorkingButton);
            this.Controls.Add(this.viewButton);
            this.Name = "MainFormIndystry";
            this.Load += new System.EventHandler(this.MainFormIndystry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void MainFormIndystry_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
