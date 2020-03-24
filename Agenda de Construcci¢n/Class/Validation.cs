using System;
using System.Windows.Forms;

namespace Agenda_de_Construcción
{
    public class Validation
    {
        public Validation()
        {

        }

        public void ValidateLetter(KeyPressEventArgs KeyPress)
        {
            if ((char.IsLetter(KeyPress.KeyChar)) || (char.IsControl(KeyPress.KeyChar)) || (char.IsSeparator(KeyPress.KeyChar)))
            {
                KeyPress.Handled = false;
            }

            else
            {
                KeyPress.Handled = true;
                MessageBox.Show("Solo se permiten letras.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void ValidateNumberInteger(KeyPressEventArgs KeyPress)
        {
            if ((char.IsNumber(KeyPress.KeyChar)) || (char.IsControl(KeyPress.KeyChar)) || (char.IsSeparator(KeyPress.KeyChar)))
            {
                KeyPress.Handled = false;
            }

            else
            {
                KeyPress.Handled = true;
                MessageBox.Show("Solo se permiten números.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void ValidateNumberReal(KeyPressEventArgs KeyPress, TextBox TextBox)
        {
            if ((char.IsNumber(KeyPress.KeyChar)) || (char.IsControl(KeyPress.KeyChar)))
            {
                KeyPress.Handled = false;
            }
            else if ((KeyPress.KeyChar == '.') && (!TextBox.Text.Contains(".")))
            {
                KeyPress.Handled = false;
            }
            else
            {
                KeyPress.Handled = true;
                MessageBox.Show("Solo se permiten números.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
