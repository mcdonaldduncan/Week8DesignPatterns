using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8DesignPatterns.Collectable
{
    internal class Battery : Item
    {
        int Charge { get; set; }

        public Battery(string name, string description, int charge) : base(name, description)
        {
            Charge = charge;
        }

        public override string Use()
        {


            return "You use the battery to extend the time you can stay in the mansion";
        }
    }
}
