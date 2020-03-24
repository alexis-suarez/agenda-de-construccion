using System;
using System.Windows.Forms;

namespace Agenda_de_Construcción
{
    public partial class RegisterContruction : Form
    {
        private ListClient ListClient;
        private int Index;

        public RegisterContruction(ref ListClient ListClient, ref int Index)
        {
            InitializeComponent();

            this.ListClient = ListClient;
            this.Index = Index;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (!IsEmptyTextBox())
            {
                Construction Construction = new Construction(DateTime.Now.ToUniversalTime().ToString(),
                                                             this.textBoxName.Text,
                                                             this.textBoxDescription.Text,
                                                             new Address(this.textBoxStreet.Text,
                                                             this.textBoxSuburb.Text,
                                                             this.textBoxNumber.Text),
                                                             this.monthCalendar1.SelectionStart);

                this.ListClient[this.Index].ListConstruction.Add(Construction);

                MessageBox.Show("Registro Completado.");

                this.Close();
            }

            else
            {
                MessageBox.Show("Llenar los Campos.");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsEmptyTextBox()
        {
            return string.IsNullOrEmpty(this.textBoxName.Text) &&
                   string.IsNullOrEmpty(this.textBoxDescription.Text) &&
                   string.IsNullOrEmpty(this.textBoxStreet.Text) &&
                   string.IsNullOrEmpty(this.textBoxSuburb.Text) &&
                   string.IsNullOrEmpty(this.textBoxNumber.Text);
        }
    }
}
