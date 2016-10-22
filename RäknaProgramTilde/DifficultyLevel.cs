using System.Windows;

namespace RäknaProgramTilde
{
    public class DifficultyLevel
    {
        public int Value { get; set; }

        public DifficultyLevel(int diffLvl)
        {
            if (IsDifficultyLevelVailid(diffLvl))
            {
                this.Value = diffLvl;
            }
        }

        private bool IsDifficultyLevelVailid(int diffLvl)
        {
            if (diffLvl == 1 || diffLvl == 2 || diffLvl == 3)
            {
                return true;
            }
            else
            {
                MessageBox.Show("DifficultyLevel error\nKontakta system admin ");
                return false;
            }
        }
    }
}