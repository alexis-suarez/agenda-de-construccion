using System;
using System.Windows.Forms;

namespace Agenda_de_Construcción
{
    public partial class EditeMaterial : Form
    {
        private ListClient ListClient;
        private int IndexClient;
        private int IndexConstruction;
        private int IndexMaterial;

        public EditeMaterial(ref ListClient ListClient, ref int IndexClient, ref int IndexConstruction, ref int IndexMaterial)
        {
            InitializeComponent();

            this.ListClient = ListClient;
            this.IndexClient = IndexClient;
            this.IndexConstruction = IndexConstruction;
            this.IndexMaterial = IndexMaterial;

            this.LoadTexBox();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!IsEmptyTextBox())
            {
                this.ListClient[this.IndexClient].ListConstruction[this.IndexConstruction].ListMaterial[this.IndexMaterial].MaterialName = this.textBoxName.Text;
                this.ListClient[this.IndexClient].ListConstruction[this.IndexConstruction].ListMaterial[this.IndexMaterial].Description = this.textBoxDescription.Text;
                this.ListClient[this.IndexClient].ListConstruction[this.IndexConstruction].ListMaterial[this.IndexMaterial].Import = Convert.ToDouble(this.textBoxImport.Text);
                this.ListClient[this.IndexClient].ListConstruction[this.IndexConstruction].ListMaterial[this.IndexMaterial].Quantity = Convert.ToDouble(this.textBoxQuantity.Text);
                this.ListClient[this.IndexClient].ListConstruction[this.IndexConstruction].ListMaterial[this.IndexMaterial].PurcheseDate = this.monthCalendar1.SelectionStart;

                this.ListClient[this.IndexClient].ListConstruction[this.IndexConstruction].ListMaterial[this.IndexMaterial].Total = Convert.ToDouble(this.textBoxImport.Text) * Convert.ToDouble(this.textBoxQuantity.Text);

                MessageBox.Show("Registro Actualizado.");

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

        private void LoadTexBox()
        {
            this.textBoxName.Text = this.ListClient[this.IndexClient].ListConstruction[this.IndexConstruction].ListMaterial[this.IndexMaterial].MaterialName;
            this.textBoxDescription.Text = this.ListClient[this.IndexClient].ListConstruction[this.IndexConstruction].ListMaterial[this.IndexMaterial].Description;
            this.textBoxImport.Text = this.ListClient[this.IndexClient].ListConstruction[this.IndexConstruction].ListMaterial[this.IndexMaterial].Import.ToString();
            this.textBoxQuantity.Text = this.ListClient[this.IndexClient].ListConstruction[this.IndexConstruction].ListMaterial[this.IndexMaterial].Quantity.ToString();
            this.monthCalendar1.SetDate(this.ListClient[this.IndexClient].ListConstruction[this.IndexConstruction].ListMaterial[this.IndexMaterial].PurcheseDate);
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
