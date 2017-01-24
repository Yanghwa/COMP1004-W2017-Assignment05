
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
using System.Text.RegularExpressions;
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
        private string _currencySymbol;
        private string _errorMessages;
        private bool _errorExist = false;

        //CONSTRUCTORS --------------------------

        /// <summary>
        /// Default Constructor
        /// </summary>
        public MailOrder()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method saves Employee information to calculate total bonus amount and to validate each information
        /// </summary>
        private void _saveEmployeeInformation()
        {
            _employeeName = EmployeeNameText.Text;
            _employeeId = EmployeeIdText.Text;
            _workedHours = TotalHoursWorkedText.Text;
            _totalSales = TotalMontlySalesText.Text;
            _validateParameters();
            _errorCheckingMessages();
        }

        /// <summary>
        /// This method validates if each parameters are suitable format and values
        /// </summary>
        private void _validateParameters()
        {
            if (string.IsNullOrEmpty(_workedHours))
            {
                _workedHours = "0";
                TotalHoursWorkedText.Text = _workedHours;
            }
            else
            {
                _workedHours = TotalHoursWorkedText.Text;
            }
            if (string.IsNullOrEmpty(_totalSales))
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
        /// This method localizes language and change language depending on localization
        /// </summary>
        private void _localizeLanguage()
        {
            if (this.RadioEnglishButton.Checked)
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("");
                _currencySymbol = "$ ";
            }
            else if (this.RadioFrenchButton.Checked)
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("fr-FR");
                _currencySymbol = "€ ";
            }
            // for Korean
            else
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("kr-KR");
                _currencySymbol = "₩ ";
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
        /// Event handler for Clear Button, it clear texts except total sales
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
        /// Event handler for Calculate, Pring Button, is calculates total bonus depending on each parameters and print with clicking print button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatePrintButton_Click(object sender, EventArgs e)
        {
            Button CalculatePrintButton = sender as Button;
            decimal totalBonusDecimal;
            decimal totalSales;
            decimal workHours;
            _localizeLanguage();
            _saveEmployeeInformation();
            if (_errorExist)
            {
                _errorExist = false;
                return;
            }
            if (Decimal.TryParse(_totalSales, out totalSales))
            {
                totalSales = Decimal.Parse(_totalSales);
            }
            else
            {
                _totalSales = Regex.Replace(_totalSales, @"[^-?\d+\.]", "");
                totalSales = Decimal.Parse(_totalSales);
            }
            workHours = Decimal.Parse(_workedHours);
            totalBonusDecimal = totalSales * _bonusAmountPercent * (workHours / _maximumWorkHours);
            TotalMontlySalesText.Text = _currencySymbol + string.Format("{0:#,##0.00}", double.Parse(_totalSales));
            Button CalculateButton = sender as Button;
            _salesBonus = _currencySymbol + totalBonusDecimal.ToString("F");
            SalesBonusText.Text = _salesBonus;
            switch (CalculatePrintButton.Tag as String)
            {
                case "Print":
                    MessageBox.Show(Language.EmployeeName + _employeeName + "\n" + Language.EmployeeId + _employeeId + "\n" + Language.TotalHoursWorked + _workedHours + "\n" + Language.TotalMontlySales + _totalSales + "\n" + Language.SaleBonus + _salesBonus, "Total Bonus Summary");
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Event handler for changing languages button, it detects radio button and changes language
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _language_CheckedChanged(object sender, EventArgs e)
        {
            _localizeLanguage();
            ClearButton_Click(sender, e);
            if (string.IsNullOrEmpty(_totalSales))
            {
            }
            else
            {
                _totalSales = Regex.Replace(_totalSales, "$2", _currencySymbol);
                TotalMontlySalesText.Text = _totalSales;
            }
        }

        /// <summary>
        /// Event handler for sales and hous text, it validates each values is suitable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _numberValuesValidation(object sender, KeyPressEventArgs e)
        {
            //only number and "." allowed
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            {
                e.Handled = true;
            }
            TextBox inputText = sender as TextBox;
            //only one "." allowed
            if (e.KeyChar == '.' && inputText.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// This method shows errorMessages what is wrong
        /// </summary>
        private void _errorCheckingMessages()
        {
            if (string.IsNullOrEmpty(_employeeId))
            {
                _errorMessages += Language.NoEmployeeId + "\n";
                _errorExist = true;
            }
            if (string.IsNullOrEmpty(_employeeName))
            {
                _errorMessages += Language.NoEmployeeName + "\n";
                _errorExist = true;
            }
            if (Decimal.Parse(_workedHours) > 160)
            {
                _errorMessages += Language.TooMuchHours + "\n";
                _errorExist = true;
            }
            if (string.IsNullOrEmpty(_errorMessages))
            {
            }
            else
            {
                MessageBox.Show(_errorMessages, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                _errorMessages = "";
            }
        }

        /// <summary>
        /// Event handler for hours text, it validates if hours are lower than 160
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TotalHoursWorkedText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (decimal.Parse(TotalHoursWorkedText.Text) > _maximumWorkHours)
                {
                    // If the number is negative, display it in Red.
                    TotalHoursWorkedText.ForeColor = Color.Red;
                }
                else
                {
                    // If the number is not negative, display it in Black.
                    TotalHoursWorkedText.ForeColor = Color.Black;
                }
            }
            catch
            {

            }

        }

        /// <summary>
        /// Event handler for sales format, if cursor went out of this tab, it changes symbol and format depending on localization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TotalMontlySalesText_Leave(object sender, EventArgs e)
        {
            //TotalMontlySalesText.Text = _currencySymbol + string.Format("{0:#,##0.00}", double.Parse(_totalSales));
        }
    }
}
