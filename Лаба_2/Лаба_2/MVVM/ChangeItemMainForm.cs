using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MyIndustry
{
    public partial class ChangeItemMainForm : Form
    {
            private MainFormViewModelIndustry _model;

            private MainFormViewModelIndustry Model { get; set;}

        private string _title;
        private string newTitle;
        private int? power;
        private Button okButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox changeItemTextBoxTitle;
        private TextBox changeItemTextBoxPower;

        public ChangeItemMainForm(MainFormViewModelIndustry model,string title)
        {
            InitializeComponent();
            Model = model;
            _title = title;
        }

        private void ChangeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (changeItemTextBoxTitle.Text != null && changeItemTextBoxPower.Text != null)
            {
                newTitle = changeItemTextBoxTitle.Text;
                power = int.Parse(changeItemTextBoxPower.Text);
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {if (newTitle != null && power.HasValue)
            Model.Change(_title, newTitle, (int)power);
            Close();
        }

        private void InitializeComponent()
        {
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.changeItemTextBoxTitle = new System.Windows.Forms.TextBox();
            this.changeItemTextBoxPower = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(87, 87);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите изменения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Наименование";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Мощность";
            // 
            // changeItemTextBoxTitle
            // 
            this.changeItemTextBoxTitle.Location = new System.Drawing.Point(12, 49);
            this.changeItemTextBoxTitle.Name = "changeItemTextBoxTitle";
            this.changeItemTextBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.changeItemTextBoxTitle.TabIndex = 4;
            changeItemTextBoxTitle.TextChanged += new System.EventHandler(this.ChangeTextBox_TextChanged);
            // 
            // changeItemTextBoxPower
            // 
            this.changeItemTextBoxPower.Location = new System.Drawing.Point(130, 49);
            this.changeItemTextBoxPower.Name = "changeItemTextBoxPower";
            this.changeItemTextBoxPower.Size = new System.Drawing.Size(100, 20);
            this.changeItemTextBoxPower.TabIndex = 5;
            changeItemTextBoxPower.TextChanged += new System.EventHandler(this.ChangeTextBox_TextChanged);
            // 
            // ChangeItemMainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.changeItemTextBoxPower);
            this.Controls.Add(this.changeItemTextBoxTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okButton);
            this.Name = "ChangeItemMainForm";
            this.Load += new System.EventHandler(this.ChangeItemMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ChangeItemMainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
