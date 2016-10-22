using System.Collections.Generic;
using System.Windows;

namespace RäknaProgramTilde
{
    /// <summary>
    /// Interaction logic for StartMenu.xaml
    /// </summary>
    public partial class StartMenu : Window
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(new GameMode("NormalMode"), new DifficultyLevel(GetDifficultFromCbBox(comboBox.Text)));
            main.Show();
            this.Close();
        }

        private void comboBox_Loaded(object sender, RoutedEventArgs e)
        {
            comboBox.ItemsSource = new List<string> { "Lätt", "Medium", "Svårt" };
        }

        private int GetDifficultFromCbBox(string cbBoxChoice)
        {
            int diffLevel = 0;
            switch (cbBoxChoice)
            {
                case "Lätt":
                    diffLevel = 1;
                    break;

                case "Medium":
                    diffLevel = 2;
                    break;

                case "Svårt":
                    diffLevel = 3;
                    break;
            }
            return diffLevel;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(new GameMode("MixedMode"), new DifficultyLevel(GetDifficultFromCbBox(comboBox.Text)));
            main.Show();
            this.Close();
        }

        private void btAdditonAndSubtraction_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(new GameMode("AdditonAndSubtraction"), new DifficultyLevel(GetDifficultFromCbBox(comboBox.Text)));
            main.Show();
            this.Close();

        }
    }
}