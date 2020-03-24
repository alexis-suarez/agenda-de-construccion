using System;
using System.Windows.Forms;

namespace Agenda_de_Construcción
{
    public partial class ManagerConstruction : Form
    {
        private ListClient ListClient;
        private int IndexClient;
        private int IndexConstr;

        public ManagerConstruction(ref ListClient ListClient, ref int IndexClient)
        {
            InitializeComponent();

            this.ListClient = ListClient;
            this.IndexClient = IndexClient;

            this.labelClient.Text = this.ListClient[this.IndexClient].Name.FullNameByFirstname;

            LoadListView();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            new RegisterContruction(ref this.ListClient, ref this.IndexClient).ShowDialog();

            LoadListView();

            new Serializable().SavaData(ref ListClient);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (this.listViewConstr.Items.Count != 0)
            {
                DialogResult Dialogue = MessageBox.Show("¿Desea Borrar La Construcción?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Dialogue == DialogResult.Yes)
                {
                    this.ListClient[this.IndexClient].ListConstruction.RemoveAt(this.GetIndex(this.listViewConstr.FocusedItem.SubItems[0].Text));
                    this.LoadListView();
                    new Serializable().SavaData(ref ListClient);
                }
            }
        }

        private void buttonEdite_Click(object sender, EventArgs e)
        {
            if (this.listViewConstr.Items.Count != 0)
            {
                this.IndexConstr = this.GetIndex(this.listViewConstr.FocusedItem.SubItems[0].Text);

                new EditeConstruction(ref this.ListClient, ref this.IndexClient, ref IndexConstr).ShowDialog();

                LoadListView();

                new Serializable().SavaData(ref ListClient);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadListView()
        {
            this.ListClient[this.IndexClient].ListConstruction.QuickSort(0, this.ListClient[this.IndexClient].ListConstruction.Count - 1);
            this.listViewConstr.Items.Clear();

            foreach (Construction Construction in this.ListClient[this.IndexClient].ListConstruction)
            {
                string[] StringClient = { Construction.ID,
                                          Construction.ProjectName,
                                          Construction.Description,
                                          Construction.Address.Street,
                                          Construction.Address.Suburb,
                                          Construction.Address.Number.ToString(),
                                          Construction.StartProject.ToShortDateString(),
                                          Construction.FinishProject.ToShortDateString()
                                        };

                ListViewItem ListViewItem = new ListViewItem(StringClient);
                this.listViewConstr.Items.Add(ListViewItem);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private int GetIndex(string Value)
        {
            int i = 0;
            int pos = 0;

            while (i < this.ListClient.Count)
            {
                if (this.ListClient[this.IndexClient].ListConstruction[i].ID == Value)
                {
                    pos = i;
                }
                i++;
            }

            return pos;
        }
    }
}
