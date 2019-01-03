using System.Windows.Forms;

namespace MyIndustry.MVVM
{
    partial class IndustryMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private ListBox plantListBox;
        private ListBox powerListBox;
        private Button SerializeButton;
        private Button DeserializeButton;
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "IndustryMainForm";

            this.SerializeButton = new System.Windows.Forms.Button();
            this.DeserializeButton = new System.Windows.Forms.Button();
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
            // SerializeButton
            // 
            this.SerializeButton.Location = new System.Drawing.Point(167, 13);
            this.SerializeButton.Name = "SerialazeButton";
            this.SerializeButton.Size = new System.Drawing.Size(95, 23);
            this.SerializeButton.TabIndex = 0;
            this.SerializeButton.Text = "Сохранить";
            this.SerializeButton.UseVisualStyleBackColor = true;
            this.SerializeButton.Click += new System.EventHandler(this.SerializeButton_Click);
            // 
            // DeserialazeButton
            // 
            this.DeserializeButton.Location = new System.Drawing.Point(287, 13);
            this.DeserializeButton.Name = "DeserialazeButton";
            this.DeserializeButton.Size = new System.Drawing.Size(106, 23);
            this.DeserializeButton.TabIndex = 1;
            this.DeserializeButton.Text = "Восстановить";
            this.DeserializeButton.UseVisualStyleBackColor = true;
            this.DeserializeButton.Click += new System.EventHandler(this.DeserializeButton_Click);
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
            this.Controls.Add(this.DeserializeButton);
            this.Controls.Add(this.SerializeButton);
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
            // this.Load += new System.EventHandler(this.IndustryMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}