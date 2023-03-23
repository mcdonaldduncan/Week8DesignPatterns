using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8DesignPatterns.Riddles;
using Week8DesignPatterns.Collectable;

namespace Week8DesignPatterns.Levels
{
    internal class MansionFloor : ILevel
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public ICollectable Item { get; set; }

        public Riddle Riddle { get; set; }
    }
}
