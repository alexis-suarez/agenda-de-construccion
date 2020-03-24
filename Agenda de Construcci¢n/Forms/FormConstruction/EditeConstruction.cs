using System;
using System.Windows.Forms;

namespace Agenda_de_Construcción
{
    public partial class EditeConstruction : Form
    {
        private ListClient ListClient;
        private int IndexClient;
        private int IndexConstr;

        public EditeConstruction(ref ListClient ListClient, ref int IndexClient, ref int IndexConstr)
        {
            InitializeComponent();

            this.ListClient = ListClient;
            this.IndexClient = IndexClient;
            this.IndexConstr = IndexConstr;

            this.LoadData();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!IsEmptyTextBox())
            {
                this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].ProjectName = this.textBoxName.Text;
                this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].Description = this.textBoxDescription.Text;
                this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].Address.Street = this.textBoxStreet.Text;
                this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].Address.Suburb = this.textBoxSuburb.Text;
                this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].Address.Number = this.textBoxNumber.Text;
                this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].StartProject = this.monthCalendarStartDate.SelectionStart;
                this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].FinishProject = this.monthCalendarEndDate.SelectionStart;

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
            this.textBoxName.Text = this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].ProjectName;
            this.textBoxDescription.Text = this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].Description;
            this.textBoxStreet.Text = this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].Address.Street;
            this.textBoxSuburb.Text = this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].Address.Suburb;
            this.textBoxNumber.Text = this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].Address.Number;
            this.monthCalendarStartDate.SetDate(this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].StartProject);
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
