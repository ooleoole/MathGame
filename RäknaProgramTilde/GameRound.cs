using System.Collections.Generic;

namespace RäknaProgramTilde
{
    public class GameRound
    {
        public int GameProgresIndex { get; private set; }
        public GameMode Mode { get; set; }
        public DifficultyLevel Level { get; set; }
        public List<EqvationOperator> Operators { get; set; }

        public GameRound(int startingGameProgres, GameMode mode, DifficultyLevel level)
        {
            this.GameProgresIndex = startingGameProgres;
            this.Level = level;
            this.Mode = mode;
            switch (mode.Value)
            {
                case "AdditonAndSubtraction":

                    this.Operators = new List<EqvationOperator>() { new EqvationOperator('+'), new EqvationOperator('-') };
                    break;

                case "NormalMode":

                    this.Operators = new List<EqvationOperator>() { new EqvationOperator('+'), new EqvationOperator('-'), new EqvationOperator('/'), new EqvationOperator('*') };

                    break;

                case "MixedMode":
                    this.Operators = new List<EqvationOperator>() { new EqvationOperator('+'), new EqvationOperator('-'), new EqvationOperator('/'), new EqvationOperator('*') };
                    break;
            }
        }

        public bool ValidateAnswer(int userAnswer, int nummberOne, int nummberTwo, char _operator)
        {
            switch (_operator)
            {
                case '+':
                    if (userAnswer == nummberOne + nummberTwo)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case '-':
                    if (userAnswer == nummberOne - nummberTwo)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case '*':
                    if (userAnswer == nummberOne * nummberTwo)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case '/':
                    if (userAnswer == nummberOne / nummberTwo)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }
            return false;
        }

        public void SetGameLvl(bool validatedAnswer)
        {
            if (validatedAnswer == true)
            {
                this.GameProgresIndex++;
            }
            else if (validatedAnswer == false && GameProgresIndex > 2)
            {
                this.GameProgresIndex--;
            }
        }

        public string ResultToString(string number1, string number2, int userAnswer, bool validatedAnswer, char eqvationOperator)
        {
            if (validatedAnswer == true)
            {
                return $"{number1} {eqvationOperator} {number2} = {userAnswer}  R\n";
            }
            else
            {
                return $"{number1} {eqvationOperator} {number2} = {userAnswer}  F\n";
            }
        }
    }
}