using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8DesignPatterns.Collectable
{
    internal class Junk : Item
    {
        public Junk(string name, string description) : base(name, description) { }

        public override string Use()
        {
            return "Unfortunately, Junk has no use";
        }
    }
}
