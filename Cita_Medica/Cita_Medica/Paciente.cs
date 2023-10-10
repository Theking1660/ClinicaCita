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
    public partial class Paciente : Form
    {
        public Paciente()
        {
            InitializeComponent();
            this.TopLevel = false; // Establece el formulario como secundario en la jerarquía de ventanas
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Evento de clic en el label (sin código asociado)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarPaciente agregar = new AgregarPaciente(); // Crea una instancia de la clase AgregarPaciente

            // Intenta agregar un nuevo paciente con los datos proporcionados
            if (agregar.Agregar(TxtNombre.Text, long.Parse(TxtCedula.Text), dateFecha.Value, TxtNumero.Text))
            {
                MessageBoxIcon icon = MessageBoxIcon.Information; // Define un ícono de información
                MessageBoxButtons buttons = MessageBoxButtons.OK; // Define botones de "Aceptar"

                // Muestra un mensaje de éxito al agregar el paciente
                MessageBox.Show("Paciente Agregado", "Estado", buttons, icon);
            }
            else
            {
                MessageBoxIcon icon = MessageBoxIcon.Error; // Define un ícono de error

                // Muestra un mensaje de error con el mensaje de error proporcionado por AgregarPaciente
                MessageBox.Show(agregar.Error, "Error", MessageBoxButtons.OK, icon);
            }
        }
    }
}
/*Este código es parte de un formulario llamado "Paciente" que permite agregar nuevos pacientes. 
Cuando se hace clic en el botón "Agregar", crea una instancia de la clase AgregarPaciente y llama a su método Agregar para intentar agregar un nuevo paciente utilizando los datos ingresados en el formulario.
Luego, muestra un mensaje de éxito o error según el resultado de la operación.*/