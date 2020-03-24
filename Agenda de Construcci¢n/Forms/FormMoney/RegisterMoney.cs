using System;
using System.Windows.Forms;

namespace Agenda_de_Construcción
{
    public partial class RegisterMoney : Form
    {
        private ListClient ListClient;
        private int IndexClient;
        private int IndexConstr;

        public RegisterMoney(ref ListClient ListClient, int IndexClient, int IndexConstr)
        {
            InitializeComponent();

            this.ListClient = ListClient;
            this.IndexClient = IndexClient;
            this.IndexConstr = IndexConstr;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (!this.IsEmptyTextBox())
            {
                MoneyReceived Money = new MoneyReceived(DateTime.Now.ToUniversalTime().ToString(),
                                                        Convert.ToDouble(this.textBoxMoney.Text),
                                                        this.textBoxDescription.Text,
                                                        this.monthCalendarDate.SelectionStart);

                this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].ListMoney.Add(Money);

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
            return string.IsNullOrEmpty(this.textBoxDescription.Text) &&
                   string.IsNullOrEmpty(this.textBoxMoney.Text);
        }

        private void textBoxMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            new Validation().ValidateNumberReal(e, this.textBoxMoney);
        }
    }
}
