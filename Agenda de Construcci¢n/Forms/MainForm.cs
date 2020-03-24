using System;
using System.Windows.Forms;

namespace Agenda_de_Construcción
{
    public partial class MainForm : Form
    {
        private ListClient ListClient;
        private int IndexClient;
        private int IndexConstr;
        private int IndexMaterial;
        private double TotalCost;

        public MainForm(ref ListClient ListClient)
        {
            InitializeComponent();

            this.ListClient = ListClient;
            this.IndexClient = -1;
            this.IndexConstr = -1;
            this.IndexMaterial = -1;
            this.TotalCost = 0;

            this.LoadComboBoxClient(ref this.comboBoxClient);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult Dialogue = MessageBox.Show("¿Desea Cerrar el Sistema?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Dialogue == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (!this.IsEmptyComboBox() && !string.IsNullOrEmpty(this.comboBoxConstruction.Text))
            {
                this.IndexClient = this.GetIndexClient(this.comboBoxClient.Text);
                this.IndexConstr = this.GetIndexConstruction(this.IndexClient, this.comboBoxConstruction.Text);

                this.LoadListViewMaterial();
                this.LoadDataConstruction();
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (!this.IsEmptyComboBox() && this.IndexClient != -1)
            {
                try
                {
                    this.IndexConstr = this.GetIndexConstruction(this.IndexClient, this.comboBoxConstruction.Text);

                    new RegisterMaterial(ref this.ListClient, ref this.IndexClient, ref this.IndexConstr).ShowDialog();
                }

                finally
                {
                    this.LoadListViewMaterial();
                    this.LoadDataConstruction();

                    new Serializable().SavaData(ref ListClient);
                }
            }

            else
            {
                MessageBox.Show("Elegir Cliente y su Construcción.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!this.IsEmptyComboBox() && this.IndexClient != -1)
            {
                DialogResult Dialogue = MessageBox.Show("¿Desea Borrar El Material o Servicio?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Dialogue == DialogResult.Yes)
                {
                    try
                    {
                        string Value = this.listViewMaterial.FocusedItem.SubItems[0].Text;

                        this.IndexConstr = this.GetIndexConstruction(this.IndexClient, this.comboBoxConstruction.Text);
                        this.IndexMaterial = this.GetIndexMaterial(this.IndexClient, this.IndexConstr, Value);

                        this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].ListMaterial.RemoveAt(this.IndexMaterial);
                    }
                    
                    finally
                    {
                        this.LoadListViewMaterial();
                        this.LoadDataConstruction();

                        new Serializable().SavaData(ref ListClient);
                    }
                }
            }

            else
            {
                MessageBox.Show("Elegir Cliente y su Construcción.");
            }
        }

        private void buttonEdite_Click(object sender, EventArgs e)
        {
            if (!this.IsEmptyComboBox() && this.IndexClient != -1)
            {
                try
                {
                    string Value = this.listViewMaterial.FocusedItem.SubItems[0].Text;

                    this.IndexConstr = this.GetIndexConstruction(this.IndexClient, this.comboBoxConstruction.Text);
                    this.IndexMaterial = this.GetIndexMaterial(this.IndexClient, this.IndexConstr, Value);

                    new EditeMaterial(ref this.ListClient, ref this.IndexClient, ref this.IndexConstr, ref this.IndexMaterial).ShowDialog();
                }
                
                finally
                {
                    this.LoadListViewMaterial();
                    this.LoadDataConstruction();

                    new Serializable().SavaData(ref ListClient);
                }
            }

            else
            {
                MessageBox.Show("Elegir Cliente y su Construcción.");
            }
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            new ManagerClient(ref this.ListClient).ShowDialog();

            this.LoadComboBoxClient(ref this.comboBoxClient);
        }

        private void buttonMoneyRecieved_Click(object sender, EventArgs e)
        {
            if (!this.IsEmptyComboBox() && this.IndexClient != -1)
            {
                this.IndexClient = this.GetIndexClient(this.comboBoxClient.Text);
                this.IndexConstr = this.GetIndexConstruction(this.IndexClient, this.comboBoxConstruction.Text);

                new ManagerMoney(ref this.ListClient, this.IndexClient, this.IndexConstr).ShowDialog();

                this.LoadListViewMaterial();
                this.LoadDataConstruction();
            } 
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            new Settings().ShowDialog();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        private bool IsEmptyComboBox()
        {
            return string.IsNullOrEmpty(this.comboBoxClient.Text) &&
                   string.IsNullOrEmpty(this.comboBoxConstruction.Text);
        }

        private void ClearTextBox()
        {
            this.textBoxName.Clear();
            this.textBoxDescription.Clear();
            this.textBoxStreet.Clear();
            this.textBoxSuburb.Clear();
            this.textBoxNumber.Clear();
            this.textBoxTotal.Clear();
            this.textBoxStartDate.Clear();
        }

        private void LoadListViewMaterial()
        {
            this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].ListMaterial.QuickSort(0, this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].ListMaterial.Count - 1);

            this.listViewMaterial.Items.Clear();
            this.TotalCost = 0;

            foreach (Material Material in this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].ListMaterial)
            {
                string[] StringMaterial = { Material.ID,
                                            Material.MaterialName,
                                            Material.Description,
                                            "$" + Material.Import.ToString(),
                                            Material.Quantity.ToString(),
                                            "$" + Material.Total.ToString(),
                                            Material.PurcheseDate.ToShortDateString()
                                          };

                this.TotalCost += Material.Total;

                ListViewItem ListViewItem = new ListViewItem(StringMaterial);
                this.listViewMaterial.Items.Add(ListViewItem);
            }
        }

        private void LoadDataConstruction()
        {
            this.textBoxName.Text = this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].ProjectName;
            this.textBoxDescription.Text = this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].Description;
            this.textBoxStreet.Text = this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].Address.Street;
            this.textBoxSuburb.Text = this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].Address.Suburb;
            this.textBoxNumber.Text = this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].Address.Number;
            this.textBoxStartDate.Text = this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].StartProject.ToShortDateString();
            this.textBoxTotal.Text = "$" + this.TotalCost.ToString();
        }

        // Functions for ComboBoxs

        private void LoadComboBoxClient(ref ComboBox ComboBox)
        {
            this.ListClient.QuickSort(0, this.ListClient.Count - 1, 1);
            this.comboBoxClient.Items.Clear();

            foreach (Client Client in this.ListClient)
            {
                ComboBox.Items.Add(Client.Name.FullNameByFirstname);
            }
        }

        private void LoadComboBoxConstruction(ref ComboBox ComboBox)
        {
            ComboBox.Items.Clear();

            this.IndexClient = this.GetIndexClient(this.comboBoxClient.Text);

            foreach (Construction Construction in this.ListClient[this.IndexClient].ListConstruction)
            {
                ComboBox.Items.Add(Construction.ProjectName);
            }
        }

        private void comboBoxClient_Click(object sender, EventArgs e)
        {
            this.comboBoxConstruction.Text = "";
            this.ClearTextBox();
            this.listViewMaterial.Items.Clear();
            this.IndexClient = -1;
            this.IndexConstr = -1;
            this.IndexMaterial = -1;
        }

        private void comboBoxConstruction_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.comboBoxClient.Text))
            {
                this.IndexClient = this.GetIndexClient(this.comboBoxClient.Text);

                if (this.IndexClient != -1)
                {
                    this.LoadComboBoxConstruction(ref this.comboBoxConstruction);
                }
            }
        }

        /// Funtions to Get Index

        private int GetIndexClient(string Value)
        {
            int i = 0;
            int pos = 0;

            while (i < this.ListClient.Count)
            {
                if (this.ListClient[i].Name.FullNameByFirstname == Value)
                {
                    pos = i;
                    break;
                }

                i++;
            }

            return pos;
        }

        private int GetIndexConstruction(int Index, string Value)
        {
            int i = 0;
            int pos = 0;

            while (i < this.ListClient[Index].ListConstruction.Count)
            {
                if (this.ListClient[Index].ListConstruction[i].ProjectName == Value)
                {
                    pos = i;
                    break;
                }

                i++;
            }

            return pos;
        }

        private int GetIndexMaterial(int IndexClient, int IndexConstruction, string Value)
        {
            int i = 0;
            int pos = 0;

            while (i < this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].ListMaterial.Count)
            {
                if (this.ListClient[IndexClient].ListConstruction[IndexConstruction].ListMaterial[i].ID == Value)
                {
                    pos = i;
                    break;
                }

                i++;
            }

            return pos;
        }

        // Print Configuration

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (!this.IsEmptyComboBox() && this.IndexClient != -1 && this.IndexConstr != -1)
            {
                this.printDialog.Document = this.printDocument;
                DialogResult DialogResult = this.printDialog.ShowDialog();

                if (DialogResult == DialogResult.OK)
                {
                    this.printDocument.PrinterSettings = this.printDialog.PrinterSettings;
                    this.printDocument.PrinterSettings.DefaultPageSettings.Landscape = false;
                    this.printDocument.Print();
                }
            }

            else
            {
                MessageBox.Show("Elegir Cliente y su Construcción.");
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int Height = 50;

            e.Graphics.DrawString("CLIENTE: " + this.ListClient[this.IndexClient].Name.FullNameByFirstname, new System.Drawing.Font("Calibri", 9), System.Drawing.Brushes.Black, 50, Height);
            e.Graphics.DrawString("CONSTRUCCIÓN: " + this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].ProjectName, new System.Drawing.Font("Calibri", 9), System.Drawing.Brushes.Black, 450, Height);

            Height += 15;

            e.Graphics.DrawString("CALLE: " + this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].Address.Street + " #" + this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].Address.Number, new System.Drawing.Font("Calibri", 9), System.Drawing.Brushes.Black, 50, Height);
            e.Graphics.DrawString("COLONIA: " + this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].Address.Suburb, new System.Drawing.Font("Calibri", 9), System.Drawing.Brushes.Black, 450, Height);

            Height += 50;

            e.Graphics.DrawString("MATERIAL O SERVICIO", new System.Drawing.Font("Calibri", 9), System.Drawing.Brushes.Black, 50, Height);
            e.Graphics.DrawString("DESCRIPCIÓN", new System.Drawing.Font("Calibri", 9), System.Drawing.Brushes.Black, 200, Height);
            e.Graphics.DrawString("IMP", new System.Drawing.Font("Calibri", 9), System.Drawing.Brushes.Black, 550, Height);
            e.Graphics.DrawString("CAN", new System.Drawing.Font("Calibri", 9), System.Drawing.Brushes.Black, 600, Height);
            e.Graphics.DrawString("TOTAL", new System.Drawing.Font("Calibri", 9), System.Drawing.Brushes.Black, 650, Height);
            e.Graphics.DrawString("FECHA", new System.Drawing.Font("Calibri", 9), System.Drawing.Brushes.Black, 710, Height);

            Height += 15;

            int i = 50;

            while (i < 780)
            {
                e.Graphics.DrawString("- ", new System.Drawing.Font("Calibri", 9), System.Drawing.Brushes.Black, i, Height);
                i += 5;
            }

            Height += 15;

            foreach (ListViewItem ListViewItem in this.listViewMaterial.Items)
            {
                e.Graphics.DrawString(ListViewItem.SubItems[1].Text, new System.Drawing.Font("Calibri", 9), System.Drawing.Brushes.Black, 50, Height);
                e.Graphics.DrawString(ListViewItem.SubItems[2].Text, new System.Drawing.Font("Calibri", 9), System.Drawing.Brushes.Black, 200, Height);
                e.Graphics.DrawString(ListViewItem.SubItems[3].Text, new System.Drawing.Font("Calibri", 9), System.Drawing.Brushes.Black, 550, Height);
                e.Graphics.DrawString(ListViewItem.SubItems[4].Text, new System.Drawing.Font("Calibri", 9), System.Drawing.Brushes.Black, 600, Height);
                e.Graphics.DrawString(ListViewItem.SubItems[5].Text, new System.Drawing.Font("Calibri", 9), System.Drawing.Brushes.Black, 650, Height);
                e.Graphics.DrawString(ListViewItem.SubItems[6].Text, new System.Drawing.Font("Calibri", 9), System.Drawing.Brushes.Black, 710, Height);
                Height += 15;
            }

            Height += 20;

            e.Graphics.DrawString("TOTAL", new System.Drawing.Font("Calibri", 9), System.Drawing.Brushes.Black, 50, Height);
            e.Graphics.DrawString("$" + this.TotalCost.ToString(), new System.Drawing.Font("Calibri", 9), System.Drawing.Brushes.Black, 650, Height);
        }
    }
}
