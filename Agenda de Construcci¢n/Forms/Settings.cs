using System;
using System.Windows.Forms;

namespace Agenda_de_Construcción
{
    public partial class Settings : Form
    {
        private Login Login;

        public Settings()
        {
            InitializeComponent();

            this.Login = new Login();
            new Serializable().LoadUser(ref this.Login);

            this.textBoxUser.Text = this.Login.UserName;
            this.textBoxPass.Text = this.Login.Password;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!this.IsEmptyTexBox())
            {
                new Serializable().SavaUser(new Login(this.textBoxUser.Text, this.textBoxPass.Text));

                MessageBox.Show("Registrado ;D");
            }

            else
            {
                MessageBox.Show("Falta llenar un Campo :$");
            }
        }

        private bool IsEmptyTexBox()
        {
            return string.IsNullOrEmpty(this.textBoxUser.Text) && string.IsNullOrEmpty(this.textBoxPass.Text);
        }
    }
}
