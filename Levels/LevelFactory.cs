using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8DesignPatterns.Riddles;
using Week8DesignPatterns.Collectable.Factory;

namespace Week8DesignPatterns.Levels
{
    internal class LevelFactory
    {
        private static RiddleBank RiddleBank = new RiddleBank();
        private static Random random = new Random();

        static string[] itemTypes = { "Potion", "Battery", "Junk" };
        static string[] descriptions = { "Shiny!", "Looks Questionable", "Wonder what that does?", "Im sure this will be useful" };
        static string[] itemNames = { "Felix", "Joe", "Guybrush", "Wallace", "Gromit" };

        public static ILevel CreateLevel(string name, int number)
        {
            ILevel level = null;

            level = new MansionFloor();

            level.Name = name;
            level.Number = number;
            level.Riddle = new Riddle(random.Next(RiddleBank.GetRiddleCount()), RiddleBank);
            level.Item = ItemFactory.CreateItem(
                itemTypes[random.Next(itemTypes.Length)],
                itemNames[random.Next(itemNames.Length)],
                descriptions[random.Next(descriptions.Length)]
                );

            return level;
        }

    }
}
