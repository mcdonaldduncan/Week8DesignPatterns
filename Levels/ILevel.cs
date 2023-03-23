using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8DesignPatterns.Riddles;
using Week8DesignPatterns.Collectable;

namespace Week8DesignPatterns.Levels
{
    internal interface ILevel
    {
        string Name { get; set; }
        int Number { get; set; }

        ICollectable Item { get; set; }

        Riddle Riddle { get; set; }
    }
}
