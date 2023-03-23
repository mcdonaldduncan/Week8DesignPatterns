using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8DesignPatterns.Riddles
{
    internal class RiddleModel
    {
        public string Question { get; set; }
        public RiddleType RiddleType { get; set; }

        private bool BooleanAnswer { get; set; }
        private string MultipleAnswer { get; set; }

        public bool CheckAnswer(string answer)
        {
            return answer == MultipleAnswer;
        }

        public bool CheckAnswer(bool answer)
        {
            return answer == BooleanAnswer;
        }

        public string GetAnswer()
        {
            return MultipleAnswer == string.Empty ? "A Herring" : MultipleAnswer;
        }

        public RiddleModel(string question, RiddleType riddleType, string multipleAnswer)
        {
            Question = question;
            RiddleType = riddleType;
            MultipleAnswer = multipleAnswer;
        }

        public RiddleModel(string question, RiddleType riddleType, bool booleanAnswer)
        {
            Question = question;
            RiddleType = riddleType;
            BooleanAnswer = booleanAnswer;
            MultipleAnswer = string.Empty;
        }
    }

    public enum RiddleType
    {
        BOOLEAN,
        MULTIPLE
    }
}
