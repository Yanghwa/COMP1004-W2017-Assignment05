//FileName: SharpAutoForm.cs
//FileType: Visual C# Source file
//Author: Junghwan Yang
//Created On: 30/01/2017
//Copy Rights: Junghwan Yang
//Description: This application calculates total Amount Due depening on auto price, additional options, and tax.
//            It also has menu bar to use it easy and extra options like font, color, and about.

/////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpAutoForm
{
    /// <summary>
    /// Sharp Auto Form for the calculator auto prices
    /// </summary>
    public partial class SharpAutoForm : Form
    {
        //PRIVATE INSTANCE VARIABLES
        private decimal _basePrice;
        private decimal _additionalOptions;
        private decimal _exteriorOptions;
        private decimal _taxRate = decimal.Parse("0.13");
        private decimal _salesTax;
        private decimal _tradeInAllowance;
        private decimal _stereoSystemItemOption = decimal.Parse("425.76");
        private decimal _leatherInteriorItemOption = decimal.Parse("987.41");
        private decimal _computerNavigationItemOption = decimal.Parse("1741.23");
        private decimal _standardExteriorOption = decimal.Parse("0");
        private decimal _pearlizedExteriorOption = decimal.Parse("345.72");
        private decimal _customizedExteriorOption = decimal.Parse("599.99");
        private decimal _subTotal;
        private string _currency = "$ ";

        // CONSTRUCTORS ---------------------------------
        public SharpAutoForm()
        {
            InitializeComponent();
            _initializeVariablesOptions();
        }

        // PRIVATE METHODS +++++++++++++++++++++++++++++++++
        // EVENT HANDLERS -----------------------------------------
        /// <summary>
        /// Event handler for clicking buttons or menus in the file menu bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _clickEventsButtons(object sender, EventArgs e)
        {
            Button ClickedButton = sender as Button;
            switch (ClickedButton.Tag.ToString())
            {
                case "Calculate":
                    _clickCalculateMenuToolStrip(sender, e);
                    break;
                case "Clear":
                    _initializeVariablesOptions();
                    break;
                case "Exit":
                    _clickExitMenuToolStrip(sender, e);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Event handler for clicking about button in the help menu bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _clickAboutOptionHelpMenu(object sender, EventArgs e)
        {
            AboutBoxForm aboutForm = new AboutBoxForm();
            //modal method to display the form
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Event handler to open font style changing option when font menu in menu bar is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _clickFontOptionEditMenu(object sender, EventArgs e)
        {
            if (SharpAutoFontDialog.ShowDialog() == DialogResult.OK)
            {
                BasePriceText.Font = AmountDueText.Font = SharpAutoFontDialog.Font;
            }
        }

        /// <summary>
        /// Event handler to open font color changing option when color menu in menu bar is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _clickColorOptionEditMenu(object sender, EventArgs e)
        {
            if(SharpAutoColorDialog.ShowDialog() == DialogResult.OK)
            {
                BasePriceText.ForeColor = SharpAutoColorDialog.Color;
                AmountDueText.BackColor = AmountDueText.BackColor;
                AmountDueText.ForeColor = SharpAutoColorDialog.Color;
            }
        }

        /// <summary>
        /// Eent handler to close application when exit menu in menu bar is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _clickExitMenuToolStrip(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Event handler to ask confirming users really want to close this application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _formClosingSharpAutoForm(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("If you want to close, push OK button.", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
            }
            else
            {
                e.Cancel = true;
            }
        }


        /// <summary>
        /// Event handler to decide additional item value depending on which check button is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _checkChangedAdditionalItems(object sender, EventArgs e)
        {
            CheckBox ClickedCheckButton = sender as CheckBox;
            switch (ClickedCheckButton.Tag.ToString())
            {
                case "StereoSystem":
                    if(ClickedCheckButton.Checked == true)
                    {
                        _additionalOptions += _stereoSystemItemOption;
                    } else
                    {
                        _additionalOptions -= _stereoSystemItemOption;
                    }
                    break;
                case "LeatherInterior":
                    if(ClickedCheckButton.Checked == true)
                    {
                        _additionalOptions += _leatherInteriorItemOption;
                    } else
                    {
                        _additionalOptions -= _leatherInteriorItemOption;
                    }
                    break;
                case "ComputerNavigation":
                    if (ClickedCheckButton.Checked == true)
                    {
                        _additionalOptions += _computerNavigationItemOption;
                    }
                    else
                    {
                        _additionalOptions -= _computerNavigationItemOption;
                    }
                    break;
                default:
                    break;
            }
            AdditionalOptionsText.Text = _currency + string.Format("{0:#,##0.00}", _additionalOptions + _exteriorOptions);
        }

        /// <summary>
        /// Event handler to decide exterior value depending on which radio button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _clickExteriorOptionsRadio(object sender, EventArgs e)
        {
            RadioButton ExteriorOption = sender as RadioButton;
            switch(ExteriorOption.Tag.ToString()) {
                case "Standard":
                    _exteriorOptions = _standardExteriorOption;
                    break;
                case "Pearlized":
                    _exteriorOptions = _pearlizedExteriorOption;
                    break;
                case "CustomizedDetailing":
                    _exteriorOptions = _customizedExteriorOption;
                    break;
                default:
                    _exteriorOptions = _standardExteriorOption;
                    break;
            }
            AdditionalOptionsText.Text = _currency + string.Format("{0:#,##0.00}", _additionalOptions + _exteriorOptions);
        }

        /// <summary>
        /// Event handler to validate input value is only numbers with one dot 
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
        
        /// <summary>
        /// Event handler to detect base price value is 0 or empty when leave from textbox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _leaveBasePriceText(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(BasePriceText.Text)) {
                _basePrice = decimal.Parse("0");
            } else
            {
                BasePriceText.Text = Regex.Replace(BasePriceText.Text, @"[^-?\d+\.]", "");
                _basePrice = decimal.Parse(BasePriceText.Text);
            }
            
            BasePriceText.Text = _currency + string.Format("{0:#,##0.00}", _basePrice);
        }

        /// <summary>
        /// Event handler to detect trade-in-allowance value is 0 or empty when leave from textbox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _leaveTradeAllowanceText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TradeAllowanceText.Text))
            {
                _tradeInAllowance = decimal.Parse("0");
            } else
            {
                TradeAllowanceText.Text = Regex.Replace(TradeAllowanceText.Text, @"[^-?\d+\.]", "");
                _tradeInAllowance = decimal.Parse(TradeAllowanceText.Text);
            }
            TradeAllowanceText.Text = _currency + string.Format("{0:#,##0.00}", _tradeInAllowance);
        }

        /// <summary>
        /// Event handler to detect base price value is 0 when enter to textbox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _enterBasePriceText(object sender, EventArgs e)
        {
            if(_basePrice.Equals(0))
            {
                BasePriceText.Text = "";
            } else
            {
                BasePriceText.Text = Regex.Replace(BasePriceText.Text, @"[^-?\d+\.]", "");
            }
            
        }

        /// <summary>
        /// Event handler to detect trade-in-allowance value is 0 when enter to textbox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _enterTradeInAllowanceText(object sender, EventArgs e)
        {
            if (_tradeInAllowance.Equals(0))
            {
                TradeAllowanceText.Text = "";
            } else
            {
                TradeAllowanceText.Text = Regex.Replace(TradeAllowanceText.Text, @"[^-?\d+\.]", "");
            }
        }

        /// <summary>
        /// Event handler when click clear menu in the menu bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _clickClearMenuToolStrip(object sender, EventArgs e)
        {
            _initializeVariablesOptions();
        }

        /// <summary>
        /// Event handler when click calculate menu in the menu bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _clickCalculateMenuToolStrip(object sender, EventArgs e)
        {
            _leaveBasePriceText(sender, e);
            _leaveTradeAllowanceText(sender, e);
            LoadingForm Nowloading = new LoadingForm();
            Nowloading.ShowDialog(this);
            _subTotal = _basePrice + _additionalOptions + _exteriorOptions;
            _salesTax = _subTotal * _taxRate;
            decimal Total = _subTotal + _salesTax;
            decimal AmountDue = Total - _tradeInAllowance;
            SalesTaxText.Text = _currency + string.Format("{0:#,##0.00}", _salesTax);
            SubTotalText.Text = _currency + string.Format("{0:#,##0.00}", _subTotal);
            TotalText.Text = _currency + string.Format("{0:#,##0.00}", Total);
            AmountDueText.Text = _currency + string.Format("{0:#,##0.00}", AmountDue);
            if (_additionalOptions + _exteriorOptions == 0)
            {
                AdditionalOptionsText.Text = _currency + string.Format("{0:#,##0.00}", 0);
            }
        }

        //PRIVATE METHOD - NOT EVENT HANDLER ++++++++++++++++++++++++++++++
        /// <summary>
        /// this method initializes all variables and texts
        /// </summary>
        private void _initializeVariablesOptions()
        {
            decimal _basePrice = decimal.Parse("0");
            decimal _additionalOptions = decimal.Parse("0");
            decimal _exteriorOptions = decimal.Parse("0");
            decimal _salesTax = decimal.Parse("0");
            decimal _tradeInAllowance = decimal.Parse("0");
            decimal _subTotal = decimal.Parse("0");
            BasePriceText.Text = "";
            AdditionalOptionsText.Text = "";
            SubTotalText.Text = "";
            SalesTaxText.Text = "";
            TotalText.Text = "";
            TradeAllowanceText.Text = "0";
            AmountDueText.Text = "";
            StandardRadio.Checked = true;
            StereoSystemCheck.Checked = LeatherInteriorCheck.Checked = ComputerNavigationCheck.Checked = false;
        }

    }
}
