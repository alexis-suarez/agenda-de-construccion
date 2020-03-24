using System;
using System.Windows.Forms;

namespace Agenda_de_Construcción
{
    public partial class EditeMoney : Form
    {
        private ListClient ListClient;
        private int IndexClient;
        private int IndexConstr;
        private int IndexMoney;

        public EditeMoney(ref ListClient ListClient, int IndexClient, int IndexConstr, int IndexMoney)
        {
            InitializeComponent();

            this.ListClient = ListClient;
            this.IndexClient = IndexClient;
            this.IndexConstr = IndexConstr;
            this.IndexMoney = IndexMoney;

            this.LoadData();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!IsEmptyTextBox())
            {
                this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].ListMoney[this.IndexMoney].Description = this.textBoxDescription.Text;
                this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].ListMoney[this.IndexMoney].Money = Convert.ToDouble(this.textBoxMoney.Text);
                this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].ListMoney[this.IndexMoney].Date = monthCalendarDate.SelectionStart;

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
            this.textBoxDescription.Text = this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].ListMoney[this.IndexMoney].Description;
            this.textBoxMoney.Text = this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].ListMoney[this.IndexMoney].Money.ToString();
            this.monthCalendarDate.SetDate(this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].ListMoney[this.IndexMoney].Date);
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
