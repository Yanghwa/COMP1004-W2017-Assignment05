
//FileName: MailOrder.cs
//FileType: Visual C# Source file
//Author: Junghwan Yang
//Created On: 16/01/2017
//Copy Rights: Junghwan Yang
//Description: This app calculates total sales bonus depening on work hours and total sales amount.
//            It also print all information using messagebox.

/////////////////////////////////////////////////////////////////////////

using Assignment01.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment01
{
    public partial class MailOrder : Form
    {
        //PRIVATE INSTANCE VARIABLES
        private string _employeeName;
        private string _employeeId;
        private string _workedHours;
        private string _totalSales;
        private int _maximumWorkHours = 160;
        private decimal _bonusAmountPercent = Decimal.Parse("0.02");
        private string _salesBonus;

        //CONSTRUCTORS --------------------------

        /// <summary>
        /// Default Constructor
        /// </summary>
        public MailOrder()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Save Employee information to calculate total bonus amount
        /// </summary>
        private void _saveEmployeeInformation()
        {
            _employeeName = EmployeeNameText.Text;
            _employeeId = EmployeeIdText.Text;
            _workedHours = TotalHoursWorkedText.Text;
            _totalSales = TotalMontlySalesText.Text;
            _validateParameters();
        }

        /// <summary>
        /// Validate if each parameters are suitable format and values
        /// </summary>
        private void _validateParameters()
        {
            if(string.IsNullOrEmpty(_workedHours))
            {
                _workedHours = "0";
                TotalHoursWorkedText.Text = _workedHours;
            }
            else
            {
                _workedHours = TotalHoursWorkedText.Text;
            }
            if(string.IsNullOrEmpty(_totalSales))
            {
                _totalSales = "0";
                TotalMontlySalesText.Text = _totalSales;
            }
            else
            {
                _totalSales = TotalMontlySalesText.Text;
            }
        }

        /// <summary>
        /// Validate language and change language
        /// </summary>
        private void _validateLanguage()
        {
            if (this.RadioEnglishButton.Checked)
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("");
            }
            else if (this.RadioFrenchButton.Checked)
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("fr-FR");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("kr-KR");
            }
            EmployeeName.Text = Language.EmployeeName;
            EmployeeId.Text = Language.EmployeeId;
            TotalHoursWorked.Text = Language.TotalHoursWorked;
            TotalMontlySales.Text = Language.TotalMontlySales;
            SaleBonus.Text = Language.SaleBonus;
            LanguageBox.Text = Language.LanguageBox;
            CalculateButton.Text = Language.CalculateButton;
            ClearButton.Text = Language.ClearButton;
            PrintButton.Text = Language.PrintButton;

        }

        /// <summary>
        /// Event handler for Clear Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            _employeeName = "";
            _employeeId = "";
            _workedHours = "";
            _salesBonus = "";
            EmployeeNameText.Text = _employeeName;
            EmployeeIdText.Text = _employeeId;
            TotalHoursWorkedText.Text = _workedHours;
            SalesBonusText.Text = _salesBonus;
        }

        /// <summary>
        /// Event handler for Print Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintButton_Click(object sender, EventArgs e)
        {
            _saveEmployeeInformation();
            CalculateButton_Click(sender, e);
            MessageBox.Show(Language.EmployeeName + _employeeName + "\n" + Language.EmployeeId + _employeeId + "\n" + Language.TotalHoursWorked + _workedHours + "\n" + Language.TotalMontlySales+ _totalSales + "\n" + Language.SaleBonus+ _salesBonus, "Total Bonus Summary");
        }

        /// <summary>
        /// Event handler for Calculate Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            decimal totalBonusDecimal;
            _saveEmployeeInformation();
            TotalMontlySalesText.Text = "$" + string.Format("{0:#,##0.00}", double.Parse(_totalSales));
            Button CalculateButton = sender as Button;
            totalBonusDecimal = System.Convert.ToDecimal(_totalSales) * _bonusAmountPercent * (System.Convert.ToDecimal(_workedHours) / _maximumWorkHours);
            _salesBonus = "$" + totalBonusDecimal.ToString("F");
            SalesBonusText.Text = _salesBonus;
        }

        /// <summary>
        /// Detecting radio button to change language
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _language_CheckedChanged(object sender, EventArgs e)
        {
            _validateLanguage();
        }
    }
}
