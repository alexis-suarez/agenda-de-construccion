using System;
using System.Windows.Forms;

namespace Agenda_de_Construcción
{
    public partial class EditeClient : Form
    {
        private ListClient ListClient;
        private int Index;

        public EditeClient(ref ListClient ListClient, ref int Index)
        {
            InitializeComponent();

            this.ListClient = ListClient;
            this.Index = Index;

            this.LoadData();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!IsEmptyTextBox())
            {
                this.ListClient[this.Index].Name.FirstName = this.textBoxFirstName.Text;
                this.ListClient[this.Index].Name.LastName = this.textBoxLastName.Text;
                this.ListClient[this.Index].Address.Street = this.textBoxStreet.Text;
                this.ListClient[this.Index].Address.Suburb = this.textBoxSuburb.Text;
                this.ListClient[this.Index].Address.Number = this.textBoxNumber.Text;
                this.ListClient[this.Index].Phone = this.textBoxNumberPhone.Text;
                this.ListClient[this.Index].Mobile = this.textBoxNumberMobile.Text;
                this.ListClient[this.Index].Email = this.textBoxEmail.Text;

                MessageBox.Show("Registro Actualizado.");

                this.Close();
            }

            else { MessageBox.Show("Llenar los Campos."); }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadData()
        {
            this.textBoxFirstName.Text = this.ListClient[this.Index].Name.FirstName;
            this.textBoxLastName.Text = this.ListClient[this.Index].Name.LastName;

            this.textBoxStreet.Text = this.ListClient[this.Index].Address.Street;
            this.textBoxSuburb.Text = this.ListClient[this.Index].Address.Suburb;
            this.textBoxNumber.Text = this.ListClient[this.Index].Address.Number;

            this.textBoxNumberPhone.Text = this.ListClient[this.Index].Phone;
            this.textBoxNumberMobile.Text = this.ListClient[this.Index].Mobile;
            this.textBoxEmail.Text = this.ListClient[this.Index].Email;
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
