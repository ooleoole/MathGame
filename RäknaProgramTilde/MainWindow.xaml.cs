using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RäknaProgramTilde
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public GameRound Game { get; set; }
        public SetEqvationOperator GetEqvationOperatorIndex { get; set; }
        public int OperatorIndex { get; set; }

        public MainWindow(GameMode gameMode, DifficultyLevel diffLevel)
        {
            this.GetEqvationOperatorIndex = new SetEqvationOperator();
            this.Game = new GameRound(10, gameMode, diffLevel);
            InitializeComponent();

            tbAnswer.Focus();
            this.OperatorIndex = GetEqvationOperatorIndex.GetEqvationOperatorIndexDependingOnGameMode(Game);
            SetEqvationOperator(Game.Operators[OperatorIndex]);
            SetTbEqvationNUmmbers();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            tbAnswer.Focus();
            UserInput userAnswer = new UserInput(tbAnswer.Text);
            bool isAnswerCorrect = Game.ValidateAnswer(userAnswer.InputFromUser, Convert.ToInt32(tbNumberOne.Text), Convert.ToInt32(TbNumberTwo.Text), Convert.ToChar(tbOperator.Text));
            tbProgress.Text += Game.ResultToString(tbNumberOne.Text, TbNumberTwo.Text, userAnswer.InputFromUser, isAnswerCorrect, Game.Operators[OperatorIndex].Value);
            this.OperatorIndex = GetEqvationOperatorIndex.GetEqvationOperatorIndexDependingOnGameMode(Game);
            SetEqvationOperator(Game.Operators[OperatorIndex]);
            tbAnswer.Text = null;
            
            Game.SetGameLvl(isAnswerCorrect);
            SetTbEqvationNUmmbers();
            AlertWithRedOrGreenOnRightOrWrongAnswer(isAnswerCorrect);
        }

        private void SetTbEqvationNUmmbers()
        {
            RandomNumber randomNumbers = new RandomNumber(Game,OperatorIndex);
            tbNumberOne.Text = randomNumbers.GeneratedRandomNumbers[0].ToString();
            TbNumberTwo.Text = randomNumbers.GeneratedRandomNumbers[1].ToString();
        }

        private void tbSvar_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void tbSvar_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void tbProgress_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.tbProgress.IsReadOnly = true;

            tbProgress.ScrollToEnd();
        }

        private void AlertWithRedOrGreenOnRightOrWrongAnswer(bool isAnswerValid)
        {
            if (isAnswerValid == false)
            {
                cbError.IsChecked = true;
                cbError.IsChecked = false;

                cbError.IsChecked = false;
            }
            else if (isAnswerValid == true)
            {
                radioButton.IsChecked = true;
                radioButton.IsChecked = false;
            }
        }

        private void SetEqvationOperator(EqvationOperator _operator)
        {
            tbOperator.Text = _operator.Value.ToString();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
           
        }
    }
}