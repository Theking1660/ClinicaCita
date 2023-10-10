using Cita_Medica.Funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cita_Medica
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Iniciar_Seccion validar = new Iniciar_Seccion();
            if(validar.Validar(TxtUsuario.Text,TxtContra.Text))
            {
                MessageBox.Show("Inicio de sesión exitoso.");

                Principal principal = new Principal();
                principal.WindowState = FormWindowState.Maximized;
                principal.Show();

                this.Hide();
            }
            else
                MessageBox.Show("Nombre de usuario o contraseña incorrectos. Intenta de nuevo.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
