using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8DesignPatterns.Collectable.Factory
{
    internal class ItemFactory
    {
        private static Random random = new Random();

        public static ICollectable CreateItem(string type, string name, string description)
        {
            ICollectable item;

            switch (type)
            {
                case "Potion":
                    item = new Potion(name, description, random.Next(-1, 1));
                    break;

                case "Battery":
                    item = new Battery(name, description, random.Next(-1, 1));
                    break;

                case "Junk":
                    item = new Junk(name, description);
                    break;

                default:
                    throw new ArgumentException("Invalid Item Type!");
            }

            return item;
        }

    }
}
