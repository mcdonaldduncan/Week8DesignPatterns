using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8DesignPatterns.Levels;
using Week8DesignPatterns.Singleton;

namespace Week8DesignPatterns
{
    internal class GameManager
    {
        public List<ILevel> Levels { get; set; }
        public int CurrentIndex = 0;

        public GameManager()
        {
            Initialize();
        }

        public void Initialize()
        {
            Levels = new List<ILevel>();

            Levels.Add(LevelFactory.CreateLevel("Basement", 0));
            Levels.Add(LevelFactory.CreateLevel("Ground Floor", 1));
            Levels.Add(LevelFactory.CreateLevel("Residential", 2));
            Levels.Add(LevelFactory.CreateLevel("Laboratory", 3));
            Levels.Add(LevelFactory.CreateLevel("Dining Hall", 4));
            Levels.Add(LevelFactory.CreateLevel("PentHouse", 5));
        }

        public void IncrementLevel()
        {
            CurrentIndex++;
        }

        public bool GameWin()
        {
            return CurrentIndex >= Levels.Count;
        }

        public bool GameLose()
        {
            return Player.Instance.LoseLife();
        }

    }
}
