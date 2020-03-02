using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    /// <summary>
    /// The basic outline of everything that an ItemType needs to have in order to work in
    /// the PriceCalculator.
    /// </summary>
    public abstract class AbstractItemType
    {
        /// <summary>
        /// A decimal representation of the amount of margin desired. Represented as 1-(percent markup).
        /// 
        /// EX: a 15% markup would have a margin of .85
        ///     a 45% markup would have a margin of .55
        ///     etc.
        /// </summary>
        protected double Margin { get; set;}

        /// <summary>
        /// The primary method that will be used by the Controller/GUI to calculate the
        /// retail price of the item in question.
        /// </summary>
        /// <param name="cost">The cost of the item</param>
        /// <returns>The retail price of the Item</returns>
        public abstract double Calculate(double cost);
        
        /// <summary>
        /// Used to round the price of the given price to the specified threshold
        /// </summary>
        /// <param name="price">The unrounded price of the item</param>
        /// <param name="threshold">The number of dollars to which to round the price</param>
        /// <returns>A rounded price</returns>
        public abstract double Round(double price, double threshold);

        /// <summary>
        /// Used to set the cents of the price prior to reporting the final price.
        /// </summary>
        /// <param name="price">The rounded price of the item</param>
        /// <returns>The input price with the appropriate amount of cents</returns>
        public double PrepDecimal(double price)
        {
            price = Math.Round(price);

            if (price%10 == 0)
            {
                return price - .05;
            }
            else
            {
                return price - .01;
            }
        }
    }
}
