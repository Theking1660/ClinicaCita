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
using Cita_Medica.ClinicaSetTableAdapters; // Importa el espacio de nombres ClinicaSetTableAdapters

namespace Cita_Medica
{
    public partial class ModificarCitas : Form
    {
        public ModificarCitas()
        {
            InitializeComponent();
            this.TopLevel = false; // Establece el formulario como secundario en la jerarquía de ventanas
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick_1); // Asocia el evento CellClick del DataGridView a la función dataGridView1_CellContentClick_1
        }

        DateTime FechaAnterior; // Variable para almacenar la fecha anterior antes de la modificación

        private void ModificarCitas_Load(object sender, EventArgs e)
        {
            // Carga datos de pacientes, médicos y citas en el formulario
            this.pacienteTableAdapter.Fill(this.clinicaSet.Paciente);
            this.medicoTableAdapter.Fill(this.clinicaSet.Medico);
            this.citasTableAdapter.Fill(this.clinicaSet.Citas);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Maneja el evento CellContentClick del DataGridView al hacer clic en una celda
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string Nombre = selectedRow.Cells[0].Value.ToString();
                string Doctor = selectedRow.Cells[1].Value.ToString();
                DateTime Fecha = DateTime.Parse(selectedRow.Cells[2].Value.ToString());

                // Asigna valores a los controles en el formulario según la fila seleccionada
                comboMedico.Text = Doctor;
                comboPaciente.Text = Nombre;
                dateTimePicker1.Value = Fecha;
                FechaAnterior = Fecha; // Almacena la fecha anterior antes de la modificación
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Maneja el clic en el botón "Actualizar Cita"
            ActualizarCitas actualizar = new ActualizarCitas();
            int idpaciente = int.Parse(comboPaciente.SelectedValue.ToString());
            int idmedico = int.Parse(comboMedico.SelectedValue.ToString());

            // Llama a la función Actualizar de la clase ActualizarCitas
            actualizar.Actualizar(idmedico, idpaciente, dateTimePicker1.Value, FechaAnterior, false);

            MessageBoxIcon iconO = MessageBoxIcon.Information;
            MessageBoxIcon iconE = MessageBoxIcon.Error;
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            // Muestra un mensaje según si la cita se actualizó o no
            if (actualizar.Error == "Cita Modificada")
                MessageBox.Show(actualizar.Error, "Estado", buttons, iconO);
            else
                MessageBox.Show(actualizar.Error, "ERROR", buttons, iconE);

            CitasTableAdapter citas = new CitasTableAdapter();
            dataGridView1.DataSource = null;

            dataGridView1.Refresh();
            citasBindingSource.DataSource = citas.GetData();
            dataGridView1.DataSource = citasBindingSource;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Maneja el clic en el botón "Eliminar Cita"
            ActualizarCitas actualizar = new ActualizarCitas();
            int idpaciente = int.Parse(comboPaciente.SelectedValue.ToString());
            int idmedico = int.Parse(comboMedico.SelectedValue.ToString());

            // Llama a la función Actualizar de la clase ActualizarCitas con la opción de eliminación (true)
            actualizar.Actualizar(idmedico, idpaciente, dateTimePicker1.Value, FechaAnterior, true);

            MessageBoxIcon iconO = MessageBoxIcon.Information;
            MessageBoxIcon iconE = MessageBoxIcon.Error;
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            // Muestra un mensaje según si la cita se eliminó o no
            if (actualizar.Error == "Cita Modificada")
                MessageBox.Show(actualizar.Error, "Estado", buttons, iconO);
            else
                MessageBox.Show(actualizar.Error, "ERROR", buttons, iconE);

            CitasTableAdapter citas = new CitasTableAdapter();
            dataGridView1.DataSource = null;

            dataGridView1.Refresh();
            citasBindingSource.DataSource = citas.GetData();
            dataGridView1.DataSource = citasBindingSource;
        }
    }
}
