using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
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

        // CONSTRUCTORS ---------------------------------
        public SharpAutoForm()
        {
            InitializeComponent();
            _initializeVariablesOptions();
        }

        // PRIVATE METHODS +++++++++++++++++++++++++++++++++
        /// <summary>
        /// Event handler for clicking buttons or menus in the file menu bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _eventsButton_Click(object sender, EventArgs e)
        {
            Button ClickedButton = sender as Button;
            switch (ClickedButton.Tag.ToString())
            {
                case "Calculate":
                    LoadingForm Nowloading = new LoadingForm();
                    Nowloading.previousForm = this;
                    Nowloading.ShowDialog(this);
                    _subTotal = _basePrice + _additionalOptions + _exteriorOptions;
                    _salesTax = _subTotal * _taxRate;
                    decimal Total = _subTotal + _salesTax;
                    decimal AmountDue = Total - _tradeInAllowance;
                    SalesTaxText.Text = string.Format("{0:#,##0.00}", _salesTax);
                    SubTotalText.Text = string.Format("{0:#,##0.00}", _subTotal);
                    TotalText.Text = string.Format("{0:#,##0.00}", Total);
                    AmountDueText.Text = string.Format("{0:#,##0.00}", AmountDue);
                    break;
                case "Clear":
                    _initializeVariablesOptions();
                    break;
                case "Exit":
                    _exitSharpAutoForm_Click(sender, e);
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
        private void _aboutOptionHelpMenu_Click(object sender, EventArgs e)
        {
            AboutBoxForm aboutForm = new AboutBoxForm();
            //modal method to display the form
            aboutForm.ShowDialog();
        }

        private void _fontOptionEditMenu_Click(object sender, EventArgs e)
        {
            if (SharpAutoFontDialog.ShowDialog() == DialogResult.OK)
            {
                BasePriceText.Font = AmountDueText.Font = SharpAutoFontDialog.Font;
            }
        }

        private void _colorOptionEditMenu_Click(object sender, EventArgs e)
        {
            if(SharpAutoColorDialog.ShowDialog() == DialogResult.OK)
            {
                BasePriceText.ForeColor = AmountDueText.ForeColor = SharpAutoColorDialog.Color;
            }
        }

        private void _sharpAutoForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void _exitSharpAutoForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _additionalItems_CheckedChanged(object sender, EventArgs e)
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
            AdditionalOptionsText.Text = string.Format("{0:#,##0.00}", _additionalOptions + _exteriorOptions);
        }

        private void _exteriorOptionsRadio_Click(object sender, EventArgs e)
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
            AdditionalOptionsText.Text = string.Format("{0:#,##0.00}", _additionalOptions + _exteriorOptions);
        }

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

        private void _basePriceText_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(BasePriceText.Text)) {
                _basePrice = decimal.Parse("0");
            } else
            {
                _basePrice = decimal.Parse(BasePriceText.Text);
            }
            
            BasePriceText.Text = string.Format("{0:#,##0.00}", _basePrice);
        }

        private void _tradeAllowanceText_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BasePriceText.Text))
            {
                _tradeInAllowance = decimal.Parse("0");
            } else
            {
                _tradeInAllowance = decimal.Parse(TradeAllowanceText.Text);
            }
            TradeAllowanceText.Text = string.Format("{0:#,##0.00}", _tradeInAllowance);
        }

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


        }

        
    }
}
