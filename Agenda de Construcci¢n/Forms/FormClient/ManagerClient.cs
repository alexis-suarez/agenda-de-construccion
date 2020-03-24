using System;
using System.Windows.Forms;

namespace Agenda_de_Construcción
{
    public partial class ManagerClient : Form
    {
        private ListClient ListClient;
        private int Index;

        public ManagerClient(ref ListClient ListClient)
        {
            InitializeComponent();

            this.ListClient = ListClient;

            this.LoadListView();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            new RegisterClient(ref this.ListClient).ShowDialog();

            this.LoadListView();

            new Serializable().SavaData(ref ListClient);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (this.listViewClient.Items.Count != 0)
            {
                DialogResult Dialogue = MessageBox.Show("¿Desea Borrar El Cliente?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Dialogue == DialogResult.Yes)
                {
                    if (this.ListClient[this.GetIndex(this.listViewClient.FocusedItem.SubItems[0].Text)].ListConstruction.Count == 0)
                    {
                        this.ListClient.RemoveAt(this.GetIndex(this.listViewClient.FocusedItem.SubItems[0].Text));
                        this.LoadListView();
                        new Serializable().SavaData(ref ListClient);
                    }

                    else
                    {
                        MessageBox.Show("No se Borrará ya que hay Construcciones Registradas");
                    }
                }
            }
        }

        private void buttonEdite_Click(object sender, EventArgs e)
        {
            if (this.listViewClient.Items.Count != 0)
            {
                this.Index = GetIndex(this.listViewClient.FocusedItem.SubItems[0].Text);

                new EditeClient(ref this.ListClient, ref this.Index).ShowDialog();

                this.LoadListView();

                new Serializable().SavaData(ref ListClient);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadListView()
        {
            this.ListClient.QuickSort(0, this.ListClient.Count - 1, 0);
            this.ListClient.QuickSort(0, this.ListClient.Count - 1, 0);
            this.ListClient.QuickSort(0, this.ListClient.Count - 1, 0);
            this.ListClient.QuickSort(0, this.ListClient.Count - 1, 0);
            this.ListClient.QuickSort(0, this.ListClient.Count - 1, 0);

            this.listViewClient.Items.Clear();

            foreach (Client Client in this.ListClient)
            {
                string[] StringClient = { Client.ID,
                                          Client.Name.FirstName,
                                          Client.Name.LastName,
                                          Client.Address.Street,
                                          Client.Address.Suburb,
                                          Client.Address.Number,
                                          Client.Phone,
                                          Client.Mobile,
                                          Client.Email
                                        };

                ListViewItem ListViewItem = new ListViewItem(StringClient);
                this.listViewClient.Items.Add(ListViewItem);
            }
        }

        private int GetIndex(string Value)
        {
            int i = 0;
            int pos = 0;

            while (i < this.ListClient.Count)
            {
                if (this.ListClient[i].ID == Value)
                {
                    pos = i;
                }

                i++;
            }

            return pos;
        }

        private void listViewClient_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Index = GetIndex(this.listViewClient.FocusedItem.SubItems[0].Text);

            new ManagerConstruction(ref this.ListClient, ref this.Index).ShowDialog();
        }
    }
}
