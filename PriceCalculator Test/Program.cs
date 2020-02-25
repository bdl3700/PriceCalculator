using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items;

namespace PriceCalculator_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> supportedItemTypes = new HashSet<string>() {"firearm", "ammo", "accessory" };
            Console.WriteLine("Please enter an item type: ");
            string type = Console.ReadLine().ToLower();
            AbstractItemType item = null;

            if (!supportedItemTypes.Contains(type))
            {
                Console.WriteLine($"Item Type not supported, please select an option from: {supportedItemTypes.ToString()}");
                Main(args);
            }
            
            switch (type)
            {
                case "firearm":
                    item = new Firearm();
                    break;
                case "accessory":
                    item = new Accessory();
                    break;
                case "ammo":
                    item = new Accessory();
                    break;
            }

            Console.WriteLine("Enter the item's cost: ");
            if (!double.TryParse(Console.ReadLine(), out double cost))
            {
                Console.WriteLine("That wasn't a valid number, let's try that again.");
                Main(args);
            }

            Console.WriteLine($"That {type} would cost ${item.Calculate(cost)}");
        }
    }
}
