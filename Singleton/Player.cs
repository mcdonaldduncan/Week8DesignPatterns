using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8DesignPatterns.Collectable;

namespace Week8DesignPatterns.Singleton
{
    internal class Player
    {
        private static Player? instance;

        public static Player Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Player();
                    instance.Inventory = new List<ICollectable>();
                }

                return instance;
            }
        }

        private int Lives = 5;
        private List<ICollectable> Inventory;

        public bool LoseLife()
        {
            return --Lives <= 0;
        }

        public void AddLife()
        {
            Lives++;
        }

        public int GetLives()
        {
            return Lives;
        }

        public void AddCollectable(ICollectable collectable)
        {
            Inventory.Add(collectable);
        }

        public string DisplayCollectables()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Inventory)
            {
                sb.AppendLine($"{item.Name} : {item.GetType().Name}");
            }

            return sb.ToString();
        }

        public void UseCollectable(int index)
        {
            Inventory[index].Use();
        }
    }
}
