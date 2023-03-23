using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8DesignPatterns.Collectable
{
    abstract class Item : ICollectable
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public abstract string Use();


        public Item(string name, string description)
        {
            Name = name;
            Description = description;
        }

    }
}
