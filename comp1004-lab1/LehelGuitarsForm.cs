using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp1004_lab1
{
    public partial class LehelGuitarsForm : Form
    {
        public LehelGuitarsForm()
        {
            InitializeComponent();
        }

        private void LehelGuitarsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void EnglishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void FrenchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Method changes all english values to french when FrenchRadioButton is clicked
            EmployeeNameLabel.Text = (EmployeeNameLabel.Text == "Employee's Name:") ? "Nom de L'Employé:" : "Employee's Name:";
            EmployeeIDLabel.Text = (EmployeeIDLabel.Text == "Employee ID:") ? "ID des Employé:s" : "Employee ID:";
            HoursWorkedLabel.Text = (HoursWorkedLabel.Text == "Hours Worked:") ? "Heures Travaillées:" : "Hours Worked:";
            TotalSalesLabel.Text = (TotalSalesLabel.Text == "Total Sales:") ? "Ventes Totales:" : "Total Sales:";
            SalesBonusLabel.Text = (SalesBonusLabel.Text == "Sales Bonus:") ? "Bonus de Vente:" : "Sales Bonus:";
            CalculateButton.Text = (CalculateButton.Text == "Calculate") ? "Calculer" : "Calculate";
            PrintButton.Text = (PrintButton.Text == "Print") ? "Impression" : "Print";
            ClearButton.Text = (ClearButton.Text == "Clear") ? "Clair" : "Clear";
            LanguageLabel.Text = (LanguageLabel.Text == "Language") ? "La Langue" : "Language";
            


        }
    }
}
