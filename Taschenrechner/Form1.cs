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
        Rechenoperationen _rechenoperationen = new Rechenoperationen();

        public Form1()
        {
            InitializeComponent();
        }

        //Addieren
        private void btnAddition_Click(object sender, EventArgs e)
        {
            _rechenoperationen.Addition(txtOperand1, txtOperand2, lblErgebnis, lblOperator);
        }

        //Subtrahieren
        private void btnSubtraktion_Click(object sender, EventArgs e)
        {
            _rechenoperationen.Subtraktion(txtOperand1, txtOperand2, lblErgebnis, lblOperator);
        }

        //Multiplikation
        private void btnMultiplikation_Click(object sender, EventArgs e)
        {
            _rechenoperationen.Multiplikation(txtOperand1, txtOperand2, lblErgebnis, lblOperator);
        }

        //Division
        private void button1_Click(object sender, EventArgs e)
        {
            _rechenoperationen.Division(txtOperand1, txtOperand2, lblErgebnis, lblOperator);
        }

        //Maximum
        private void btnMaximum_Click(object sender, EventArgs e)
        {
            _rechenoperationen.Maximum(txtOperand1, txtOperand2, lblErgebnis, lblOperator);
        }

        //Potenz
        private void btnPotenz_Click(object sender, EventArgs e)
        {
            _rechenoperationen.Potenz(txtOperand1, txtOperand2, lblErgebnis, lblOperator);
        }


        //Mittelwert
        private void btnMittelwert_Click(object sender, EventArgs e)
        {
            _rechenoperationen.Mittelwert(txtOperand1, txtOperand2, lblErgebnis, lblOperator);
        }
    }
}