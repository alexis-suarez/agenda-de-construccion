using System;
using System.Windows.Forms;

namespace Agenda_de_Construcción
{
    public partial class RegisterMaterial : Form
    {
        private ListClient ListClient;
        private int IndexClient;
        private int IndexConstruction;

        public RegisterMaterial(ref ListClient ListClient, ref int IndexClient, ref int IndexConstruction)
        {
            InitializeComponent();

            this.ListClient = ListClient;
            this.IndexClient = IndexClient;
            this.IndexConstruction = IndexConstruction;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (!IsEmptyTextBox())
            {
                string ID = DateTime.Now.ToUniversalTime().ToString();

                Material Material = new Material(ID,
                                                 this.textBoxName.Text,
                                                 this.textBoxDescription.Text,
                                                 Convert.ToDouble(this.textBoxImport.Text),
                                                 Convert.ToDouble(this.textBoxQuantity.Text),
                                                 this.monthCalendar1.SelectionStart);

                this.ListClient[this.IndexClient].ListConstruction[this.IndexConstruction].ListMaterial.Add(Material);

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
                   string.IsNullOrEmpty(this.textBoxImport.Text) &&
                   string.IsNullOrEmpty(this.textBoxQuantity.Text);
        }

        private void textBoxImport_KeyPress(object sender, KeyPressEventArgs e)
        {
            new Validation().ValidateNumberReal(e, this.textBoxImport);
        }

        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            new Validation().ValidateNumberReal(e, this.textBoxQuantity);
        }
    }
}
