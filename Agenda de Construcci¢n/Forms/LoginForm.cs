using System;
using System.Windows.Forms;

namespace Agenda_de_Construcción
{
    public partial class LoginForm : Form
    {
        private ListClient ListClient;
        private Login Login;
        private uint Count;

        public LoginForm(ref ListClient ListClient)
        {
            InitializeComponent();

            this.ListClient = ListClient;
            this.Login = new Login();
            new Serializable().LoadUser(ref this.Login);
            this.Count = 0;
        }

        private void buttonEntre_Click(object sender, EventArgs e)
        {
            if (this.Count < 2)
            {
                if (!this.IsEmptyTexBox())
                {
                    if ((this.textBoxUserName.Text == "admin" && this.textBoxPassword.Text == "admin") ||
                        (this.textBoxUserName.Text == this.Login.UserName && this.textBoxPassword.Text == this.Login.Password))
                    {
                        this.Hide();

                        new MainForm(ref this.ListClient).ShowDialog();
                        this.ClearTextBox();

                        this.Close();
                    }

                    else
                    {
                        this.ClearTextBox();
                        MessageBox.Show("Verifique el Usuario y la Contraseña");
                        this.Count++;
                    }
                }

                else
                {
                    this.ClearTextBox();
                    MessageBox.Show("Verifique el Usuario y la Contraseña");
                    this.Count++;
                }
            }
            
            else
            {
                this.ClearTextBox();
                MessageBox.Show("Se Cerrará el Programa por Seguridad ;)");
                this.Close();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsEmptyTexBox()
        {
            return string.IsNullOrEmpty(this.textBoxUserName.Text) &&
                   string.IsNullOrEmpty(this.textBoxPassword.Text);
        }

        private void ClearTextBox()
        {
            this.textBoxUserName.Clear();
            this.textBoxPassword.Clear();
        }
    }
}
