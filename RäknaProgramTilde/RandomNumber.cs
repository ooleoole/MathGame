using System;
using System.Collections.Generic;

namespace RäknaProgramTilde
{
    internal class RandomNumber
    {
        public List<int> GeneratedRandomNumbers { get; private set; }

        public RandomNumber(GameRound round,int operatorIndex)
        {
            Random rand = new Random();
            int randomNumber1 = GenearateNumberBasedOnGameLvl(round.GameProgresIndex, rand);
            int randomNumber2 = GenearateNumberBasedOnGameLvl(round.GameProgresIndex, rand);

            List<int> genratedRandomNumbers = new List<int>{ randomNumber1, randomNumber2 };
            this.GeneratedRandomNumbers = genratedRandomNumbers;
            GameRoundIdentifyer(round, operatorIndex);

        }

        public int GenearateNumberBasedOnGameLvl(int gameLvl, Random rand)
        {
            return rand.Next(1,gameLvl);
        }
        public void GameRoundIdentifyer(GameRound round, int operatorIndex)
        {
            switch (round.Operators[operatorIndex].Value)
            {
                case '-':
                    GeneratedRandomNumbers.Sort();
                    GeneratedRandomNumbers.Reverse();
                    break;
                case'/':
                    GeneratedRandomNumbers.Sort();
                    GeneratedRandomNumbers.Reverse();
                    break;
            }

        }
        
    }
}