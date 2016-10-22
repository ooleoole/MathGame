using System;
using System.Windows;

namespace RäknaProgramTilde
{
    internal class UserInput
    {
        public int InputFromUser { get; private set; }

        public UserInput(string InputFromUser)
        {
            try
            {
                this.InputFromUser = Convert.ToInt32(InputFromUser);
            }
            catch
            {
                MessageBox.Show("Felaktig Inmatning");
            }
        }
    }
}