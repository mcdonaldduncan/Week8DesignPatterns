using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8DesignPatterns.Riddles
{
    internal class Riddle
    {
        private int RiddleID { get; set; }
        private RiddleBank DataBank { get; set; }

        private Random random = new Random();

        public Riddle(int riddleID, RiddleBank dataBank)
        {
            RiddleID = riddleID;
            DataBank = dataBank;
        }

        public string RiddleQuestion()
        {
            return DataBank.GetRiddle(RiddleID).Question;
        }

        public RiddleType GetRiddleType()
        {
            return DataBank.GetRiddle(RiddleID).RiddleType;
        }

        public bool CheckAnswer(string answer)
        {
            return DataBank.GetRiddle(RiddleID).CheckAnswer(answer);
        }

        public bool CheckAnswer(bool answer)
        {
            return DataBank.GetRiddle(RiddleID).CheckAnswer(answer);
        }

        public string[] GetAnswers()
        {
            return DataBank.GetRiddleAnswers(RiddleID);
        }

        //public string[] RiddleAnswers()
        //{
        //    string[] answers = new string[4];

        //    int selected = random.Next(4);

        //    for (int i = 0; i < answers.Length; i++)
        //    {
        //        if (i == selected)
        //        {
        //            answers[i] = DataBank.GetRiddle(RiddleID).
        //        }
        //    }
        //}
    }
}
