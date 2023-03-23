using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8DesignPatterns.Riddles
{
    internal class RiddleBank
    {
        private Dictionary<int, RiddleModel> bank = new Dictionary<int, RiddleModel>();
        private Random random = new Random();

        public RiddleBank()
        {
            bank = new Dictionary<int, RiddleModel>();
            InitializeData();
        }

        private void InitializeData()
        {
            bank.Add(0, new RiddleModel("I am taken from a mine and shut up in a wooden case, from which I am never released, and yet I am used by almost every person. What am I?", RiddleType.MULTIPLE, "A pencil lead"));
            bank.Add(1, new RiddleModel("What has a head and a tail, but no body?", RiddleType.MULTIPLE, "A coin"));
            bank.Add(2, new RiddleModel("What has a neck but no head, arms, or legs?", RiddleType.MULTIPLE, "A bottle"));
            bank.Add(3, new RiddleModel("What is always in front of you but can't be seen?", RiddleType.MULTIPLE, "The future"));
            bank.Add(4, new RiddleModel("What belongs to you but is used more by others?", RiddleType.MULTIPLE, "Your name"));
            bank.Add(5, new RiddleModel("What has a thumb and four fingers but is not alive?", RiddleType.MULTIPLE, "A glove"));
            bank.Add(6, new RiddleModel("What is so fragile that saying its name breaks it?", RiddleType.MULTIPLE, "Silence"));
            bank.Add(7, new RiddleModel("What has many keys but can't open a single lock?", RiddleType.MULTIPLE, "A keyboard"));
            bank.Add(8, new RiddleModel("What is full of holes but still holds water?", RiddleType.MULTIPLE, "A sponge"));
            bank.Add(9, new RiddleModel("What has a face and two hands but no arms or legs?", RiddleType.MULTIPLE, "A clock"));


            bank.Add(10, new RiddleModel("The only letter that does not appear in any U.S. state name is the letter 'Q'.", RiddleType.BOOLEAN, true));
            bank.Add(11, new RiddleModel("A group of flamingos is called a flamboyance.", RiddleType.BOOLEAN, true));
            bank.Add(12, new RiddleModel("The shortest war in history lasted only 38 minutes.", RiddleType.BOOLEAN, true));
            bank.Add(13, new RiddleModel("The Great Wall of China is visible from space.", RiddleType.BOOLEAN, false));
            bank.Add(14, new RiddleModel("The unicorn is the national animal of Scotland.", RiddleType.BOOLEAN, true));
        }


        public RiddleModel GetRiddle(int id)
        {
            return bank[id];
        }

        public string[] GetRiddleAnswers(int id)
        {
            string[] answers = new string[4];

            int selected = random.Next(4);

            for (int i = 0; i < answers.Length; i++)
            {
                if (i == selected)
                {
                    answers[i] = bank[id].GetAnswer();
                }
                else
                {
                    answers[i] = bank[random.Next(bank.Count)].GetAnswer();
                }
            }

            return answers;
        }

        public int GetRiddleCount()
        {
            return bank.Count;
        }

    }
}
/*
 


"I am taken from a mine and shut up in a wooden case, from which I am never released, and yet I am used by almost every person. What am I?", "A pencil lead"
"What has a head and a tail, but no body?", "A coin"
"What has a neck but no head, arms, or legs?", "A bottle"
"What is always in front of you but can't be seen?", "The future"
"What belongs to you but is used more by others?", "Your name"
"What has a thumb and four fingers but is not alive?", "A glove"
"What is so fragile that saying its name breaks it?", "Silence"
"What has many keys but can't open a single lock?", "A keyboard"
"What is full of holes but still holds water?", "A sponge"
"What has a face and two hands but no arms or legs?", "A clock"




"The only letter that does not appear in any U.S. state name is the letter 'Q'.", RiddleType.BOOLEAN, True
"A group of flamingos is called a flamboyance.", RiddleType.BOOLEAN, True
"The shortest war in history lasted only 38 minutes.", RiddleType.BOOLEAN, True
"The Great Wall of China is visible from space.", RiddleType.BOOLEAN, False
"The unicorn is the national animal of Scotland.", RiddleType.BOOLEAN, True








*/