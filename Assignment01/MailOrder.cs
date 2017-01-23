using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            MessageBox.Show("Employee's Name: " + _employeeName + "\n" + "Employee ID: " + _employeeId + "\n" + "Hours Worked:" + _workedHours + "\n" + "Total Sales: "+ _totalSales + "\n" + "Sales Bonus: "+ _salesBonus, "Total Bonus Summary");
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
            Button CalculateButton = sender as Button;
            totalBonusDecimal = System.Convert.ToDecimal(_totalSales) * _bonusAmountPercent * (System.Convert.ToDecimal(_workedHours) / _maximumWorkHours);
            _salesBonus = "$" + totalBonusDecimal.ToString();
            SalesBonusText.Text = _salesBonus;
        }
    }
}
