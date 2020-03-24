using System;
using System.Windows.Forms;

namespace Agenda_de_Construcción
{
    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
