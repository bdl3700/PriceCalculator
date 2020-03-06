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
            AmmoRB.Click += AmmoRB_Click;
            CostTB.KeyUp += CostTB_KeyUp;
            CostTB.KeyPress += CostTB_KeyPress;

            //Select the default Item type
            AccessoryRB.PerformClick();
        }

        /// <summary>
        /// Handles recalculating the price after adding a new digit to the price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CostTB_KeyUp(object sender, KeyEventArgs e)
        {
            ReCalculate();
        }

        /// <summary>
        /// Handles keystrokes and forbids the use of letters in the cost box. Warns the user 
        /// to not use letters in the cost box if they try.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CostTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please only enter digits in the cost box.");
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

        /// <summary>
        /// Calculates the correct price based upon the current value in the text box and 
        /// the currently selected item. It then sets the price box's text to relfect the new price.
        /// </summary>
        private void ReCalculate()
        {
            double.TryParse(CostTB.Text, out double cost);
            TotalTB.Text = CurrentItem.Calculate(cost).ToString();
        }
    }
}
