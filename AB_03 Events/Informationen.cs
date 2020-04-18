using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AB_03_Events
{
    public partial class Informationen : Form
    {
        public Informationen()
        {
            InitializeComponent();
        }

        private void btnschliessen_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}