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
            SupressorRB.Click += SupressorRB_Click;
            CostTB.KeyUp += TextBoxes_KeyUp;
            CostTB.KeyPress += BasicTextBox_KeyPress;
            QuantityTB.KeyUp += TextBoxes_KeyUp;
            QuantityTB.KeyPress += BasicTextBox_KeyPress;
            QuantityTB.KeyPress += QuantityTB_KeyPress;
            AddBCICheckBox.Click += AddBCICheckBox_Click;

            //Select the default Item type
            AccessoryRB.Checked = true;
            CurrentItem = new Accessory();
            ReCalculate();
        }

        /// <summary>
        /// Handles recalculating the price after a chenge in whether or not a BCI check is necessary.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBCICheckBox_Click(object sender, EventArgs e)
        {
            ReCalculate();
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
        /// Handles recalculating the price after adding a new digit to the price or changing the quantity
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxes_KeyUp(object sender, KeyEventArgs e)
        {
            ReCalculate();
        }

        /// <summary>
        /// Handles keystrokes and forbids the use of letters in the cost box. Warns the user 
        /// to not use letters in the cost box if they try.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BasicTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        /// <summary>
        /// Handles clicking the Ammo radio button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AmmoRB_Click(object sender, EventArgs e)
        {
            CurrentItem = new Ammo();
            ReCalculate();
        }

        /// <summary>
        /// Handles clicking the Firearm radio button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FirearmRB_Click(object sender, EventArgs e)
        {
            CurrentItem = new Firearm();
            ReCalculate();
        }

        /// <summary>
        /// Handles clicking the Accessory radio button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccessoryRB_Click(object sender, EventArgs e)
        {
            CurrentItem = new Accessory();
            ReCalculate();
        }

        private void SupressorRB_Click(object sender, EventArgs e)
        {
            CurrentItem = new Supressor();
            ReCalculate();
        }

        /// <summary>
        /// Calculates the correct price based upon the current value in the text box and 
        /// the currently selected item. It then sets the price box's text to relfect the new price.
        /// </summary>
        private void ReCalculate()
        {
            double.TryParse(CostTB.Text, out double cost);

            double unitPrice = CurrentItem.Calculate(cost);
            RetailPriceTB.Text = unitPrice.ToString();

            int.TryParse(QuantityTB.Text, out int quantity);
            double subTotal = unitPrice * quantity;
            SubTotalTB.Text = subTotal.ToString();

            //Add the cost of a BCI check if necessary.
            if (AddBCICheckBox.Checked)
                subTotal = subTotal + 7.5;

            TotalTB.Text = AddTax(subTotal).ToString();
        }

        /// <summary>
        /// Adds the appropriate sales tax for salt lake county, Utah as of May 2019.
        /// </summary>
        /// <param name="price">The price to add tax to</param>
        /// <returns>The given price with salestax added</returns>
        public double AddTax(double price)
        {
            return Math.Round((price * 1.0725), 2);
        }
    }
}
