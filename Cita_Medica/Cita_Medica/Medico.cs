using Cita_Medica.Funciones; // Importa el espacio de nombres Funciones
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
    public partial class Medico : Form
    {
        public Medico()
        {
            InitializeComponent();
            this.TopLevel = false; // Establece el formulario como secundario en la jerarquía de ventanas
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            AgregarMedico agregar = new AgregarMedico(); // Crea una instancia de la clase AgregarMedico

            // Intenta agregar un nuevo médico con los datos proporcionados
            if (agregar.Agregar(TxtNombre.Text, TxtEspecialidad.Text, TxtContra.Text))
            {
                MessageBoxIcon icon = MessageBoxIcon.Information; // Define un ícono de información
                MessageBoxButtons buttons = MessageBoxButtons.OK; // Define botones de "Aceptar"

                // Muestra un mensaje de éxito al agregar el médico
                MessageBox.Show("Médico Agregado", "Estado", buttons, icon);

                // Limpia los campos de entrada después de agregar con éxito
                TxtContra.Text = string.Empty;
                TxtEspecialidad.Text = string.Empty;
                TxtNombre.Text = string.Empty;
            }
            else
            {
                MessageBoxIcon icon = MessageBoxIcon.Error; // Define un ícono de error

                // Muestra un mensaje de error con el mensaje de error proporcionado por AgregarMedico
                MessageBox.Show(agregar.Error, "Error", MessageBoxButtons.OK, icon);
            }
        }
    }
}
