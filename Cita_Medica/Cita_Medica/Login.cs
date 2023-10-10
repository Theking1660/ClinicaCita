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

        // Evento Click del botón "Iniciar Sesión"
        private void button1_Click(object sender, EventArgs e)
        {
            Iniciar_Seccion validar = new Iniciar_Seccion();

            // Validar el inicio de sesión con el nombre de usuario y la contraseña ingresados
            if (validar.Validar(TxtUsuario.Text, TxtContra.Text))
            {
                MessageBox.Show("Inicio de sesión exitoso.");

                // Crear una instancia del formulario principal
                Principal principal = new Principal();
                principal.WindowState = FormWindowState.Maximized; // Maximizar el formulario principal
                principal.Show(); // Mostrar el formulario principal

                this.Hide(); // Ocultar el formulario de inicio de sesión
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos. Intenta de nuevo.");
            }
        }

        // Evento Click del botón de cierre en la esquina superior derecha del formulario
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cerrar la aplicación al hacer clic en la "x".
        }

        // Evento FormClosing del formulario de inicio de sesión
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Manejar el evento de cierre del formulario de inicio de sesión
            // y asegurarse de que se cierre toda la aplicación al hacer clic en la "x".

            if (e.CloseReason == CloseReason.UserClosing)
            {
                // El cierre fue solicitado por el usuario, no por otro motivo (por ejemplo, una excepción).
                Application.Exit(); // Cierra la aplicación por completo.
            }
        }
    }
}


/*Este código pertenece a la clase Login en C# y se refiere a la interfaz de inicio de sesión de una aplicación. A continuación, se describe lo que hace el código:

El formulario Login tiene una función constructora (public Login()) que se ejecuta cuando se crea una instancia de este formulario. 
En el constructor, se inicializan los componentes y se configuran los eventos.

El evento Click del botón "Iniciar Sesión" (button1_Click) se encarga de validar el inicio de sesión. 
Crea una instancia de la clase Iniciar_Seccion para validar el nombre de usuario y la contraseña ingresados. 
Si las credenciales son válidas, muestra un mensaje de éxito, crea una instancia del formulario principal (Principal), lo maximiza, lo muestra y oculta el formulario de inicio de sesión.

El evento Click del botón de cierre en la esquina superior derecha del formulario (label3_Click) se encarga de cerrar la aplicación por completo cuando se hace clic en la "x".

El evento FormClosing del formulario de inicio de sesión (Login_FormClosing) maneja el evento de cierre del formulario y asegura que se cierre toda la aplicación si el cierre fue solicitado por el usuario (por ejemplo, al hacer clic en la "x").

En resumen, este código controla la lógica de inicio de sesión y el cierre de la aplicación en el formulario de inicio de sesión de la aplicación.*/