using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Week8DesignPatterns.Riddles;
using Week8DesignPatterns.Singleton;

namespace Week8DesignPatterns
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }

        GameManager GameManager = new GameManager();
        string[] answers;
        string[] answerKey = { "A", "B", "C", "D" };


        int currentIndex => GameManager.CurrentIndex;
        Riddle currentRiddle => GameManager.Levels[currentIndex].Riddle;

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            DisplayCurrentInfo();
            Timer.Instance.TimeExpired += LoseDisplay;
        }

        public void SetAnswerPanel(RiddleType answerType)
        {
            grd_BooleanChoice.Visibility = answerType == RiddleType.BOOLEAN ? Visibility.Visible : Visibility.Hidden;
            grd_MultipleChoice.Visibility = answerType == RiddleType.MULTIPLE ? Visibility.Visible : Visibility.Hidden;
        }


        public void DisplayCurrentInfo()
        {
            tb_Timer.Text = Timer.Instance.GetRemainingTime().ToString();
            tb_Lives.Text = Player.Instance.GetLives().ToString();
            tb_Inventory.Text = Player.Instance.DisplayCollectables();
            tb_FloorNnumber.Text = currentIndex.ToString();

            if (currentIndex >= GameManager.Levels.Count)
            {
                WinDisplay();
                return;
            }

            tb_FloorName.Text = GameManager.Levels[currentIndex].Name;
            answers = currentRiddle.GetAnswers();
            SetAnswerPanel(currentRiddle.GetRiddleType());

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(currentRiddle.RiddleQuestion());

            if (currentRiddle.GetRiddleType() == RiddleType.MULTIPLE)
            {
                for (int i = 0; i < answers.Length; i++)
                {
                    sb.AppendLine(answerKey[i] + ": " + answers[i]);
                }
            }
            

            tb_Display.Text = sb.ToString();
        }

        void LoseDisplay()
        {
            tb_Display.Text = "You Lose!";
            grd_BooleanChoice.Visibility = Visibility.Hidden;
            grd_MultipleChoice.Visibility = Visibility.Hidden;
        }

        void WinDisplay()
        {
            tb_Display.Text = "You Win!";
            grd_BooleanChoice.Visibility = Visibility.Hidden;
            grd_MultipleChoice.Visibility = Visibility.Hidden;
        }

        private void btn_True_Click(object sender, RoutedEventArgs e)
        {
            CheckAnswer(true);
        }

        private void btn_False_Click(object sender, RoutedEventArgs e)
        {
            CheckAnswer(false);
        }

        private void btn_B_Click(object sender, RoutedEventArgs e)
        {
            CheckAnswer(1);
        }

        private void btn_D_Click(object sender, RoutedEventArgs e)
        {
            CheckAnswer(3);
        }

        private void btn_A_Click(object sender, RoutedEventArgs e)
        {
            CheckAnswer(0);
        }

        private void btn_C_Click(object sender, RoutedEventArgs e)
        {
            CheckAnswer(2);
        }

        public void CheckAnswer(int index)
        {
            if (currentRiddle.CheckAnswer(answers[index]))
            {
                Player.Instance.AddCollectable(GameManager.Levels[currentIndex].Item);
                GameManager.IncrementLevel();
                DisplayCurrentInfo();
            }
            else
            {
                if (Player.Instance.LoseLife())
                {
                    LoseDisplay();
                }

                DisplayCurrentInfo();
                tb_Display.Text += "\nIncorrect\n";
            }
        }

        public void CheckAnswer(bool answer)
        {
            if (currentRiddle.CheckAnswer(answer))
            {
                Player.Instance.AddCollectable(GameManager.Levels[currentIndex].Item);
                GameManager.IncrementLevel();
                DisplayCurrentInfo();
            }
            else
            {
                if (Player.Instance.LoseLife())
                {
                    LoseDisplay();
                }

                DisplayCurrentInfo();
                tb_Display.Text += "\nIncorrect\n";
            }
        }
    }
}
