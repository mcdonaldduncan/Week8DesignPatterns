using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8DesignPatterns.Collectable
{
    internal class Potion : Item
    {
        int LifeBonus { get; set; }

        public Potion(string name, string description, int lifeBonus) : base(name, description)
        {
            LifeBonus = lifeBonus;
        }

        public override string Use()
        {


            return $"The potion granted you {LifeBonus} additional lives!";
        }
    }
}
