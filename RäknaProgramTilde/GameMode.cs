using System.Windows;
namespace RäknaProgramTilde
{
    public class GameMode
    {
        public string Value { get; set; }

        public GameMode(string gameMode)
        {
            if (IsGameMode(gameMode))
            {
                this.Value = gameMode;
            }
        }
        private bool IsGameMode(string gameMode)
        {
            if (gameMode.Equals("MixedMode") || gameMode.Equals("NormalMode") || gameMode.Equals("AdditonAndSubtraction"))
            {
                return true;
            }
            else
            {
                MessageBox.Show("GameMode error.\nKontakta SystemAdmin");
                return false;
            }
        }
    }
}