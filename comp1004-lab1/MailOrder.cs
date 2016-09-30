using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Lehel Guitars Bonus Calculator
 * Karl Kovacs
 * September 30, 2016
 * This is an app for calculating the sales bonus for
 * a made up company by the name of Lehel Guitars
 */

namespace comp1004_lab1
{
    public partial class MailOrder : Form
    {
        public MailOrder()
        {
            InitializeComponent();
        }

        private void _LehelGuitarsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       

        private void _FrenchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Method changes all english values to french when FrenchRadioButton is clicked
            EmployeeNameLabel.Text = (EmployeeNameLabel.Text == "Employee's Name:") ? "Nom de L'Employé:" : "Employee's Name:";
            EmployeeIDLabel.Text = (EmployeeIDLabel.Text == "Employee ID:") ? "ID des Employé:s" : "Employee ID:";
            HoursWorkedLabel.Text = (HoursWorkedLabel.Text == "Hours Worked:") ? "Heures Travaillées:" : "Hours Worked:";
            TotalSalesLabel.Text = (TotalSalesLabel.Text == "Total Sales:") ? "Ventes Totales:" : "Total Sales:";
            SalesBonusLabel.Text = (SalesBonusLabel.Text == "Sales Bonus:") ? "Bonus de Vente:" : "Sales Bonus:";
            CalculateButton.Text = (CalculateButton.Text == "Calculate") ? "Calculer" : "Calculate";
            PrintButton.Text = (PrintButton.Text == "Print") ? "Impression" : "Print";
            NextButton.Text = (NextButton.Text == "Clear") ? "Clair" : "Clear";
            LanguageLabel.Text = (LanguageLabel.Text == "Language") ? "La Langue" : "Language";
            


        }

        //Handler for the print Button
        private void _PrintButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your form is being sent to the printer! / Votre formulaire est envoyé à l'imprimante", "Printing / Impression");
        }

        //Handler for the ClearButton
        private void _ClearButton_Click(object sender, EventArgs e)
        {
            //Method resets the text boxes to blank when the clear button is clicked
            EmployeeNameTextBox.Text = null;
            EmployeeIDTextBox.Text = null;
            HoursWorkedTextBox.Text = null;
            SalesBonusTextBox.Text = null;
           

        }
        //Handler for the "Calculate" button
        private void _CalculateButton_Click(object sender, EventArgs e)
        {
            double HoursBefore;
            double Hours;
            double TotalBefore;
            double Total;
            double Bonus;

            //Makes sure all data is entered properly
            try
            {
                //Convert the text box strings into doubles
                
                TotalBefore = Convert.ToDouble((TotalSalesTextBox.Text as string).TrimStart('$'));
                HoursBefore = Convert.ToDouble(HoursWorkedTextBox.Text);


                //Make sure the Total Hours entered is not above 160
                if (HoursBefore > 160)
                {
                    MessageBox.Show("Hours Worked cannot exceed 160 / Heures travaillées ne peut pas dépasser 160", "Error / Erreur");
                    HoursWorkedTextBox.Focus();
                    HoursWorkedTextBox.SelectAll();
                }

                else
                {

                    //Calculate percentage of total hours worked
                    Hours = HoursBefore / 160;
                    //Calculate 2% of Total Sales
                    Total = TotalBefore * 0.02;

                    //Calaculate Bonus
                    Bonus = Total * Hours;

                    //Refill Textbox with the calculated info
                    HoursWorkedTextBox.Text = HoursBefore.ToString();
                    TotalSalesTextBox.Text = TotalBefore.ToString("C2");
                    SalesBonusTextBox.Text = Bonus.ToString("C2");
                }
               



            }
            //If data is not entered properly a message will apear to the user
            catch (Exception)
            {

                  MessageBox.Show("Please make sure ALL data is entered and that it is VALID / Faire S'il vous plaît que toutes les données sont entrées et qu'il est valide", "Error / Erreur");
                  
            }

           

            
        }
    }
}
