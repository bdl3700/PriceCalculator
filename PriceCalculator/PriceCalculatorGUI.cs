using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Items;

namespace PriceCalculator
{
    public partial class PriceCalculatorGUI : Form
    {
        /// <summary>
        /// The Item that is to be used for calculations. This changes each time one of the Radio 
        /// Buttons is pressed.
        /// </summary>
        private AbstractItemType CurrentItem;

        public PriceCalculatorGUI()
        {
            //Setup Gui
            InitializeComponent();

            //Add Event Handlers
            AccessoryRB.Click += AccessoryRB_Click;
            FirearmRB.Click += FirearmRB_Click;
            FirearmRB.CheckedChanged += FirearmRB_CheckedChanged;
            AmmoRB.Click += AmmoRB_Click;
            NFAItemRB.Click += NFAItemRB_Click;
            CostTB.KeyUp += CostTB_KeyUp;
            CostTB.KeyPress += BasicTextBox_KeyPress;
            RetailPriceTB.KeyUp += RetailAndQuantityTB_KeyUp;
            RetailPriceTB.KeyPress += BasicTextBox_KeyPress;
            QuantityTB.KeyUp += RetailAndQuantityTB_KeyUp;
            QuantityTB.KeyPress += BasicTextBox_KeyPress;
            QuantityTB.KeyPress += QuantityTB_KeyPress;
            AddBCICheckBox.Click += AddBCICheckBox_Click;

            //Select the default Item type
            AccessoryRB.Checked = true;
            CurrentItem = new Accessory();
            CalculateFromCost();
        }


        /// <summary>
        /// Handles recalculating the price after a chenge in whether or not a BCI check is necessary.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBCICheckBox_Click(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        /// <summary>
        /// Enables or Disables the option to add a BCI check based upon whether or not the transaction is for a firearm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FirearmRB_CheckedChanged(object sender, EventArgs e)
        {
            if (AddBCICheckBox.Checked)
                AddBCICheckBox.Checked = false;
            AddBCICheckBox.Enabled = !AddBCICheckBox.Enabled;
        }

        /// <summary>
        /// Updates the total prices when the retail price or the quantity selected is updates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RetailAndQuantityTB_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateTotals();
        }

        /// <summary>
        /// Handles recalculating the price after adding a new digit to the price or changing the quantity
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CostTB_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateFromCost();
        }

        /// <summary>
        /// Handles keystrokes and forbids the use of letters box. Warns the user 
        /// to not use letters in the cost box if they try.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BasicTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region HotKey Handlers
            if (e.KeyChar == 'a')
            {
                e.Handled = true;
                if (AccessoryRB.Checked)
                    AmmoRB.PerformClick();
                else
                    AccessoryRB.PerformClick();
                return;
            }
            if (e.KeyChar == 'f')
            {
                e.Handled = true;
                FirearmRB.PerformClick();
                return;
            }
            if (e.KeyChar == 'n')
            {
                e.Handled = true;
                NFAItemRB.PerformClick();
                return;
            }
            if (e.KeyChar == 'b')
            {

                e.Handled = true;

                if (FirearmRB.Checked)
                {
                    AddBCICheckBox.Checked = !AddBCICheckBox.Checked;
                    AddBCICheckBox_Click(null, null);
                }

                return;
            }
            if (e.KeyChar == 'c')
            {
                e.Handled = true;
                CostTB.Focus();
                CostTB.SelectAll();
                return;
            }
            if (e.KeyChar == 'r')
            {
                e.Handled = true;
                RetailPriceTB.Focus();
                RetailPriceTB.SelectAll();
                return;
            }
            if (e.KeyChar == 'q')
            {
                e.Handled = true;
                QuantityTB.Focus();
                QuantityTB.SelectAll();
                return;
            }
            #endregion

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only digits");
            }
            if (e.KeyChar == '-')
            {
                e.Handled = true;
                MessageBox.Show("Please enter only positive numbers");
            }
        }

        /// <summary>
        /// disallows the use of '.' characters in the quantity box in order to assure integer item quantities.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuantityTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.Handled = true;
                MessageBox.Show("Please enter only whole numbers in the quantity box");
            }
        }

        #region Radio Button Handlers
        /// <summary>
        /// Handles clicking the Ammo radio button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AmmoRB_Click(object sender, EventArgs e)
        {
            CurrentItem = new Ammo();
            CalculateFromCost();
        }

        /// <summary>
        /// Handles clicking the Firearm radio button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FirearmRB_Click(object sender, EventArgs e)
        {
            CurrentItem = new Firearm();
            CalculateFromCost();
        }

        /// <summary>
        /// Handles clicking the Accessory radio button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccessoryRB_Click(object sender, EventArgs e)
        {
            CurrentItem = new Accessory();
            CalculateFromCost();
        }

        private void NFAItemRB_Click(object sender, EventArgs e)
        {
            CurrentItem = new NFAItem();
            CalculateFromCost();
        }
        #endregion

        /// <summary>
        /// Calculates the correct price based upon the current value in the cost text box, the quantity, and 
        /// the currently selected item. It then sets the price box's text to reflect the new price.
        /// </summary>
        private void CalculateFromCost()
        {
            double.TryParse(CostTB.Text, out double cost);

            double unitPrice = CurrentItem.Calculate(cost);
            RetailPriceTB.Text = unitPrice.ToString();

            CalculateTotals();
        }

        /// <summary>
        /// Given a unit price and quantity calculates the appropriate subtotal and total prices and writes the 
        /// new values to the appropraite text boxes.
        /// </summary>
        /// <param name="unitPrice"></param>
        private void CalculateTotals()
        {
            double.TryParse(RetailPriceTB.Text, out double unitPrice);

            unitPrice = Math.Round(unitPrice, 2, MidpointRounding.AwayFromZero);

            int.TryParse(QuantityTB.Text, out int quantity);
            double subTotal = unitPrice * quantity;

            //Add the cost of a BCI check if necessary.
            if (AddBCICheckBox.Checked)
                subTotal = subTotal + 7.5;

            SubTotalTB.Text = subTotal.ToString();

            TotalTB.Text = AddTax(subTotal).ToString();
        }

        /// <summary>
        /// Adds the appropriate sales tax for salt lake county, Utah as of May 2019.
        /// </summary>
        /// <param name="price">The price to add tax to</param>
        /// <returns>The given price with salestax added</returns>
        public double AddTax(double price)
        {
            return Math.Round((price * 1.0725), 2, MidpointRounding.AwayFromZero);
        }
    }
}
