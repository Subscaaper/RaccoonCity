using System;
using System.Windows.Forms;

namespace Taschenrechner
{
    public class Rechenoperationen
    {
        public void Addition(TextBox Operand1, TextBox Operand2, Label Ergebnis, Label Operator)
        {
            double zahl1 = Convert.ToDouble(Operand1.Text);
            double zahl2 = Convert.ToDouble(Operand2.Text);
            double ergebnis = zahl1 + zahl2;
            Ergebnis.Text = Convert.ToString(ergebnis);
            Operator.Text = "+";
        }
        
        public void Subtraktion(TextBox Operand1, TextBox Operand2, Label Ergebnis, Label Operator)
        {
            double zahl1 = Convert.ToDouble(Operand1.Text);
            double zahl2 = Convert.ToDouble(Operand2.Text);
            double ergebnis = zahl1 - zahl2;
            Ergebnis.Text = Convert.ToString(ergebnis);
            Operator.Text = "-";
        }
        public void Multiplikation(TextBox Operand1, TextBox Operand2, Label Ergebnis, Label Operator)
        {
            double zahl1 = Convert.ToDouble(Operand1.Text);
            double zahl2 = Convert.ToDouble(Operand2.Text);
            double ergebnis = zahl1 * zahl2;
            Ergebnis.Text = Convert.ToString(ergebnis);
            Operator.Text = "*";
        }
        public void Division(TextBox Operand1, TextBox Operand2, Label Ergebnis, Label Operator)
        {
            double zahl1 = Convert.ToDouble(Operand1.Text);
            double zahl2 = Convert.ToDouble(Operand2.Text);
            double ergebnis = zahl1 / zahl2;
            Ergebnis.Text = Convert.ToString(ergebnis);
            Operator.Text = "/";
        }
        public void Potenz(TextBox Operand1, TextBox Operand2, Label Ergebnis, Label Operator)
        {
            double zahl1 = Convert.ToDouble(Operand1.Text);
            double zahl2 = Convert.ToDouble(Operand2.Text);
            double ergebnis = Math.Pow(zahl1, zahl2);
            Ergebnis.Text = Convert.ToString(ergebnis);
            Operator.Text = "Potenz";
        }
        public void Maximum(TextBox Operand1, TextBox Operand2, Label Ergebnis, Label Operator)
        {
            double zahl1 = Convert.ToDouble(Operand1.Text);
            double zahl2 = Convert.ToDouble(Operand2.Text);
            double ergebnis = Math.Max(zahl1, zahl2);
            Ergebnis.Text = Convert.ToString(ergebnis);
            Operator.Text = "Max";
        }
        public void Mittelwert(TextBox Operand1, TextBox Operand2, Label Ergebnis, Label Operator)
        {
            double zahl1 = Convert.ToDouble(Operand1.Text);
            double zahl2 = Convert.ToDouble(Operand2.Text);
            double ergebnis = (zahl1 + zahl2) / 2;
            Ergebnis.Text = Convert.ToString(ergebnis);
            Operator.Text = "Durchschnitt";
        }
    }
}