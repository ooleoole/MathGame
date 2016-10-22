using System.Windows;

namespace RäknaProgramTilde
{
    public class EqvationOperator
    {
        public char Value { get; set; }

        public EqvationOperator(char operator_)
        {
            if (IsEqvationOperator(operator_))
            {
                this.Value = operator_;
            }
        }

        private bool IsEqvationOperator(char operator_)
        {
            if (operator_ == '*' || operator_ == '/' || operator_ == '+' || operator_ == '-')
            {
                return true;
            }
            else
            {
                MessageBox.Show("EqvationOperator error\nKontakta systemadmin");
                return false;
            }
        }
    }
}