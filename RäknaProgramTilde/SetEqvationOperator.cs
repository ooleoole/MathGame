using System;
using System.Collections.Generic;

namespace RäknaProgramTilde
{
    public class SetEqvationOperator
    {

        private int GenarateRandomEqvationOperator(int operatorListIndex)
        {

            Random random = new Random();
            return random.Next(operatorListIndex);
        }

        public int GetEqvationOperatorIndexDependingOnGameMode(GameRound game)
        {
            switch (game.Mode.Value)
            {
                case "NormalMode":
                    return GeneratEqvationOperatorBasedOnGameProgress(game.GameProgresIndex);

                case "MixedMode":
                    return GenarateRandomEqvationOperator(game.Operators.Count);

                case "AdditonAndSubtraction":
                    return GenarateRandomEqvationOperator(game.Operators.Count);

            }
            return 1;
        }

        private int GeneratEqvationOperatorBasedOnGameProgress(int gameLevel)
        {
            if (gameLevel > 15)
            {
                return 1;
            }
            else if (gameLevel > 20)
            {
                return 2;
            }
            else if (gameLevel > 25)
            {
                return 3;
            }
            else
            {
                return 0;
            }

        }

    }

}