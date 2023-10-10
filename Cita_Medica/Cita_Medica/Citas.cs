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
    public partial class Citas : Form
    {
        public Citas()
        {
            InitializeComponent();
            this.TopLevel = false; // Establece el formulario como secundario en la jerarquía de ventanas
        }

        private void Citas_Load(object sender, EventArgs e)
        {
            // Carga datos de pacientes, usuarios y médicos al formulario
            this.pacienteTableAdapter.Fill(this.clinicaSet.Paciente);
            this.usuarioTableAdapter.Fill(this.clinicaSet.Usuario);
            this.medicoTableAdapter.Fill(this.clinicaSet.Medico);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarCitas agregar = new AgregarCitas(); // Crea una instancia de la clase AgregarCitas

            // Obtiene el ID del paciente y el ID del médico seleccionados en los ComboBox
            int idpaciente = int.Parse(comboPaciente.SelectedValue.ToString());
            int idmedico = int.Parse(comboMedico.SelectedValue.ToString());

            // Intenta agregar una nueva cita utilizando los datos seleccionados en el formulario
            if (agregar.Agregar(idpaciente, idmedico, dateTimePicker1.Value))
            {
                MessageBoxIcon icon = MessageBoxIcon.Information; // Define un ícono de información
                MessageBoxButtons buttons = MessageBoxButtons.OK; // Define botones de "Aceptar"

                // Muestra un mensaje de éxito al agregar la cita
                MessageBox.Show("Cita Agregada", "Estado", buttons, icon);
            }
            else
            {
                MessageBoxIcon icon = MessageBoxIcon.Error; // Define un ícono de error

                // Muestra un mensaje de error con el mensaje de error proporcionado por AgregarCitas
                MessageBox.Show(agregar.Error, "Error", MessageBoxButtons.OK, icon);
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pacienteTableAdapter.FillBy(this.clinicaSet.Paciente);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ultimos_PacientesToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pacienteTableAdapter.Ultimos_Pacientes(this.clinicaSet.Paciente);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
