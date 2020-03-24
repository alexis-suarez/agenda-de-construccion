using System;
using System.Windows.Forms;

namespace Agenda_de_Construcción
{
    public partial class ManagerMoney : Form
    {
        private ListClient ListClient;
        private int IndexClient;
        private int IndexConstr;
        private int IndexMoney;
        private double TotalCost;

        public ManagerMoney(ref ListClient ListClient, int IndexClient, int IndexConstr)
        {
            InitializeComponent();

            this.ListClient = ListClient;
            this.IndexClient = IndexClient;
            this.IndexConstr = IndexConstr;
            this.IndexMoney = -1;
            this.TotalCost = 0;

            this.LoadListView();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            new RegisterMoney(ref this.ListClient, this.IndexClient, this.IndexConstr).ShowDialog();

            this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].ListMoney.QuickSort(0, this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].ListMoney.Count - 1);

            this.LoadListView();

            new Serializable().SavaData(ref ListClient);
        }

        private void buttonEdite_Click(object sender, EventArgs e)
        {
            if (this.listViewMoney.Items.Count != 0)
            {
                this.IndexMoney = this.GetIndex(this.listViewMoney.FocusedItem.SubItems[0].Text);

                new EditeMoney(ref this.ListClient, this.IndexClient, this.IndexConstr, this.IndexMoney).ShowDialog();

                this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].ListMoney.QuickSort(0, this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].ListMoney.Count - 1);

                this.LoadListView();

                new Serializable().SavaData(ref ListClient);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (this.listViewMoney.Items.Count != 0)
            {
                DialogResult Dialogue = MessageBox.Show("¿Desea Borrar el Dinero?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Dialogue == DialogResult.Yes)
                {
                    this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].ListMoney.RemoveAt(this.GetIndex(this.listViewMoney.FocusedItem.SubItems[0].Text));

                    this.LoadListView();

                    new Serializable().SavaData(ref ListClient);
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadListView()
        {
            this.listViewMoney.Items.Clear();
            this.TotalCost = 0;

            foreach (MoneyReceived Money in this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].ListMoney)
            {
                string[] StringMoney = { Money.ID,
                                         Money.Description,
                                         "$" + Money.Money.ToString(),
                                         Money.Date.ToShortDateString()
                                       };

                this.TotalCost += Money.Money;

                ListViewItem ListViewItem = new ListViewItem(StringMoney);
                this.listViewMoney.Items.Add(ListViewItem);
            }

            this.textBoxTotal.Text = "$" + this.TotalCost.ToString();
        }

        private int GetIndex(string Value)
        {
            int i = 0;
            int pos = 0;

            while (i < this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].ListMoney.Count)
            {
                if (this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].ListMoney[i].ID == Value)
                {
                    pos = i;
                }

                i++;
            }

            return pos;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
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

        private void printDocumentMoney_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int Height = 50;

            e.Graphics.DrawString("CLIENTE: " + this.ListClient[this.IndexClient].Name.FullNameByFirstname, new System.Drawing.Font("Calibri", 9), System.Drawing.Brushes.Black, 50, Height);

            Height += 15;

            e.Graphics.DrawString("CONSTRUCCIÓN: " + this.ListClient[this.IndexClient].ListConstruction[this.IndexConstr].ProjectName, new System.Drawing.Font("Calibri", 9), System.Drawing.Brushes.Black, 50, Height);

            Height += 50;

            e.Graphics.DrawString("DESCRIPCIÓN", new System.Drawing.Font("Calibri", 9), System.Drawing.Brushes.Black, 50, Height);
            e.Graphics.DrawString("CAPITAL", new System.Drawing.Font("Calibri", 9), System.Drawing.Brushes.Black, 600, Height);
            e.Graphics.DrawString("FECHA", new System.Drawing.Font("Calibri", 9), System.Drawing.Brushes.Black, 700, Height);

            Height += 15;

            int i = 50;

            while (i < 780)
            {
                e.Graphics.DrawString("- ", new System.Drawing.Font("Calibri", 9), System.Drawing.Brushes.Black, i, Height);
                i += 5;
            }

            Height += 15;

            foreach (ListViewItem ListViewItem in this.listViewMoney.Items)
            {
                e.Graphics.DrawString(ListViewItem.SubItems[1].Text, new System.Drawing.Font("Calibri", 9), System.Drawing.Brushes.Black, 50, Height);
                e.Graphics.DrawString(ListViewItem.SubItems[2].Text, new System.Drawing.Font("Calibri", 9), System.Drawing.Brushes.Black, 600, Height);
                e.Graphics.DrawString(ListViewItem.SubItems[3].Text, new System.Drawing.Font("Calibri", 9), System.Drawing.Brushes.Black, 700, Height);
                Height += 15;
            }

            Height += 20;

            e.Graphics.DrawString("TOTAL", new System.Drawing.Font("Calibri", 9), System.Drawing.Brushes.Black, 50, Height);
            e.Graphics.DrawString("$" + this.TotalCost.ToString(), new System.Drawing.Font("Calibri", 9), System.Drawing.Brushes.Black, 600, Height);
        }
    }
}
