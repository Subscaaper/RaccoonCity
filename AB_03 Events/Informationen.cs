using System;
using System.Drawing;
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
            Hide();
        }


        private void Informationen_Resize(object sender, EventArgs e)
        {
            //Resize
            Control control = (Control) sender;

            if (control.Size.Height != control.Size.Width)
            {
                control.Size = new Size(control.Size.Width, control.Size.Width);
            }
            //Neues Label
            Label lblAusgabe = new Label();
            lblAusgabe.Font = new Font(FontFamily.GenericSansSerif, 10);
            lblAusgabe.Location = new Point(60, 240);
            lblAusgabe.Size = new Size(320, 50);
            lblAusgabe.Text = "Dies ist ein Informationsformular";
            Controls.Add(lblAusgabe);
            lblAusgabe.Enabled = false;
        }
    }
}