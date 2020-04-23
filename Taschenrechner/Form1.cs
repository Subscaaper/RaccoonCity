using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Addieren
        private void btnAddition_Click(object sender, EventArgs e)
        {
            double zahl1 = Convert.ToDouble(txtOperand1.Text);
            double zahl2 = Convert.ToDouble(txtOperand2.Text);
            double ergebnis = zahl1 + zahl2;
            lblErgebnis.Text = Convert.ToString(ergebnis);
            lblOperator.Text = "+";
        }

        //Subtrahieren
        private void btnSubtraktion_Click(object sender, EventArgs e)
        {
            double zahl1 = Convert.ToDouble(txtOperand1.Text);
            double zahl2 = Convert.ToDouble(txtOperand2.Text);
            double ergebnis = zahl1 - zahl2;
            lblErgebnis.Text = Convert.ToString(ergebnis);
            lblOperator.Text = "-";
        }

        //Mittelwert
        private void btnMittelwert_Click(object sender, EventArgs e)
        {
            double zahl1 = Convert.ToDouble(txtOperand1.Text);
            double zahl2 = Convert.ToDouble(txtOperand2.Text);
            double ergebnis = (zahl1 + zahl2) / 2;
            lblErgebnis.Text = Convert.ToString(ergebnis);
            lblOperator.Text = "Durchschnitt";
        }

        //Maximumwert
        private void btnMaximum_Click(object sender, EventArgs e)
        {
            double zahl1 = Convert.ToDouble(txtOperand1.Text);
            double zahl2 = Convert.ToDouble(txtOperand2.Text);
            double ergebnis = Math.Max(zahl1, zahl2);
            lblErgebnis.Text = Convert.ToString(ergebnis);
            lblOperator.Text = "Max";
        }

        //Minimumwert
        private void btnPotenz_Click(object sender, EventArgs e)
        {
            double zahl1 = Convert.ToDouble(txtOperand1.Text);
            double zahl2 = Convert.ToDouble(txtOperand2.Text);
            double ergebnis = Math.Pow(zahl1, zahl2);
            lblErgebnis.Text = Convert.ToString(ergebnis);
            lblOperator.Text = "Potenz";
        }

        //Multiplikation
        private void btnMultiplikation_Click(object sender, EventArgs e)
        {
            double zahl1 = Convert.ToDouble(txtOperand1.Text);
            double zahl2 = Convert.ToDouble(txtOperand2.Text);
            double ergebnis = zahl1 * zahl2;
            lblErgebnis.Text = Convert.ToString(ergebnis);
            lblOperator.Text = "*";
        }

        //Division
        private void button1_Click(object sender, EventArgs e)
        {
            double zahl1 = Convert.ToDouble(txtOperand1.Text);
            double zahl2 = Convert.ToDouble(txtOperand2.Text);
            double ergebnis = zahl1 / zahl2;
            lblErgebnis.Text = Convert.ToString(ergebnis);
            lblOperator.Text = "/";
        }
    }
}