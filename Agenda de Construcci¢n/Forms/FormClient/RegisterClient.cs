using System;
using System.Windows.Forms;

namespace Agenda_de_Construcción
{
    public partial class RegisterClient : Form
    {
        private ListClient ListClient;

        public RegisterClient(ref ListClient ListClient)
        {
            InitializeComponent();

            this.ListClient = ListClient;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (!IsEmptyTextBox())
            {
                string ID = DateTime.Now.ToUniversalTime().ToString();

                Client Client = new Client(ID,
                                           new Name(this.textBoxFirstName.Text,
                                           this.textBoxLastName.Text),
                                           new Address(this.textBoxStreet.Text,
                                           this.textBoxSuburb.Text,
                                           this.textBoxNumber.Text),
                                           this.textBoxNumberPhone.Text,
                                           this.textBoxNumberMobile.Text,
                                           this.textBoxEmail.Text);

                this.ListClient.Add(Client);
                
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
            return string.IsNullOrEmpty(this.textBoxFirstName.Text) &&
                   string.IsNullOrEmpty(this.textBoxLastName.Text) &&
                   string.IsNullOrEmpty(this.textBoxStreet.Text) &&
                   string.IsNullOrEmpty(this.textBoxSuburb.Text) &&
                   string.IsNullOrEmpty(this.textBoxNumber.Text) &&
                   (string.IsNullOrEmpty(this.textBoxNumberPhone.Text) ||
                   string.IsNullOrEmpty(this.textBoxNumberMobile.Text));
        }
    }
}
