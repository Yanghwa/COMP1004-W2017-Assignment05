
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
            _localizeLanguage();
        }


        //EVENT HANDLERS -------------------------

        /// <summary>
        /// Event handler for hours text, it validates if hours are lower than 160
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IsTooHighTotalHoursWorked(object sender, EventArgs e)
        {
            try
            {
                if (decimal.Parse(TotalWorkedHoursInput.Text) > _maximumWorkHours)
                {
                    MessageBox.Show(Language.TooMuchHours, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TotalWorkedHoursInput.Text = "0";
                }
                else
                {
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
        private void LeaveTotalMonthlySalesTap(object sender, EventArgs e)
        {
            _validateTotalSalesIsEmpty();
            _changeSalesTextFormat();
        }

        /// <summary>
        /// Event handler for sales format, if cursor went in of this tab, it removes symbol and format
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterTotalMonthlySalesTap(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_totalSales))
            {
                TotalMonthlySalesInput.Text = "";
            }
            else if (_totalSales == "0")
            {
                TotalMonthlySalesInput.Text = "";
            }
            else
            {
                _totalSales = Regex.Replace(_totalSales, @"[^-?\d+\.]", "");
                TotalMonthlySalesInput.Text = _totalSales;
            }
        }

        /// <summary>
        /// Event handler for hours format, if cursor went out of this tab, numbers are saved
        /// </summary>
        private void LeaveTotalWorkedHourTap(object sender, EventArgs e)
        {
            _validateWorkHoursIsEmpty();
            if (string.IsNullOrEmpty(_workedHours))
            {
                _workedHours = "0";
                TotalWorkedHoursInput.Text = _workedHours;
            }
        }

        /// <summary>
        /// Event handler for hours format, if cursor went in of this tab, it removes when it is zero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterTotalWorkedHourTap(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_workedHours))
            {
                TotalWorkedHoursInput.Text = "";
            }
            else if (_workedHours == "0")
            {
                TotalWorkedHoursInput.Text = "";
            }
            else
            {
                TotalWorkedHoursInput.Text = _workedHours;
            }
        }

        /// <summary>
        /// Event handler for Next Button, it clear texts except total sales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickNextButton(object sender, EventArgs e)
        {
            _employeeName = "";
            _employeeId = "";
            _workedHours = "";
            _salesBonus = "";
            EmployeeNameInput.Text = _employeeName;
            EmployeeIdInput.Text = _employeeId;
            TotalWorkedHoursInput.Text = _workedHours;
            SalesBonusInput.Text = _salesBonus;
        }

        /// <summary>
        /// Event handler for Calculate, Pring Button, is calculates total bonus depending on each parameters and print with clicking print button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickCalculatePrintButton(object sender, EventArgs e)
        {
            Button CalculatePrintButton = sender as Button;
            decimal totalBonusDecimal;
            decimal totalSales;
            decimal workHours;

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
            _changeSalesTextFormat();
            _salesBonus = _currencySymbol + totalBonusDecimal.ToString("F");
            SalesBonusInput.Text = _salesBonus;
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
        private void _changeLanguages(object sender, EventArgs e)
        {
            _localizeLanguage();
            ClickNextButton(sender, e);
            _changeSalesTextFormat();
        }

        /// <summary>
        /// Event handler for sales and hous text, it validates each values is suitable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _validateOnlyNumber(object sender, KeyPressEventArgs e)
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


        //FUNCTIONS ----------------------------------

        /// <summary>
        /// This method saves Employee information to calculate total bonus amount and to validate each information
        /// </summary>
        private void _saveEmployeeInformation()
        {
            _employeeName = EmployeeNameInput.Text;
            _employeeId = EmployeeIdInput.Text;
            _workedHours = TotalWorkedHoursInput.Text;
            _totalSales = TotalMonthlySalesInput.Text;
            _validateTotalSalesIsEmpty();
            _validateWorkHoursIsEmpty();
            _isErrorHappened();
        }

        /// <summary>
        /// This method validates if total sales value is empty or not
        /// </summary>
        private void _validateTotalSalesIsEmpty()
        {
            if (string.IsNullOrEmpty(_totalSales))
            {
                _totalSales = "0";
                TotalMonthlySalesInput.Text = _totalSales;
            }
            else
            {
                _totalSales = TotalMonthlySalesInput.Text;
            }
        }
        /// <summary>
        /// This method validates if work hours value is empty or not
        /// </summary>
        private void _validateWorkHoursIsEmpty()
        {
            if (string.IsNullOrEmpty(_workedHours))
            {
                _workedHours = "0";
                TotalWorkedHoursInput.Text = _workedHours;
            }
            else
            {
                _workedHours = TotalWorkedHoursInput.Text;
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
            TotalWorkedHours.Text = Language.TotalHoursWorked;
            TotalMonthlySales.Text = Language.TotalMontlySales;
            SalesBonus.Text = Language.SaleBonus;
            LanguageBox.Text = Language.LanguageBox;
            CalculateButton.Text = Language.CalculateButton;
            NextButton.Text = Language.ClearButton;
            PrintButton.Text = Language.PrintButton;
        }


        /// <summary>
        /// This method shows errorMessages what is wrong
        /// </summary>
        private void _isErrorHappened()
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
        /// This method helps to change format with currency and price format
        /// </summary>
        private void _changeSalesTextFormat()
        {
            if (string.IsNullOrEmpty(_totalSales))
            {
                _totalSales = "0";
                TotalMonthlySalesInput.Text = _currencySymbol + string.Format("{0:#,##0.00}", double.Parse(_totalSales));
            }
            else
            {
                _totalSales = Regex.Replace(_totalSales, @"[^-?\d+\.]", "");
                TotalMonthlySalesInput.Text = _currencySymbol + string.Format("{0:#,##0.00}", double.Parse(_totalSales));
            }
        }

    }
}
