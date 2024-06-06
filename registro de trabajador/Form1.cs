using Microsoft.Win32;
using System.Diagnostics.Eventing.Reader;

namespace registro_de_trabajador
{
    public partial class Form1 : Form
    {
        private Contraseña contrase;
        public Form1()
        {
            InitializeComponent();
            contrase = new Contraseña("15052618");
        }


        private void Enterbtn_Click(object sender, EventArgs e)
        {
            Registro ventana = new Registro();

            string contraseñaingresada = passwordtbox.Text;

            if (contrase.Verificar(contraseñaingresada))
            {
                ventana.Show();
                this.Hide();
                MessageBox.Show("Password is rigth");

            }


            else
            {
                MessageBox.Show("Password is wrong");
            }

        }

        private void passwordtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

 
    }
}
