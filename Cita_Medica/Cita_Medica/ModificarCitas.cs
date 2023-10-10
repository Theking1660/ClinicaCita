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
using Cita_Medica.ClinicaSetTableAdapters;

namespace Cita_Medica
{
    public partial class ModificarCitas : Form
    {
        public ModificarCitas()
        {
            InitializeComponent();
            this.TopLevel = false;
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick_1);


        }
        DateTime FechaAnterior;
        private void ModificarCitas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clinicaSet.Paciente' Puede moverla o quitarla según sea necesario.
            this.pacienteTableAdapter.Fill(this.clinicaSet.Paciente);
            // TODO: esta línea de código carga datos en la tabla 'clinicaSet.Medico' Puede moverla o quitarla según sea necesario.
            this.medicoTableAdapter.Fill(this.clinicaSet.Medico);
            // TODO: esta línea de código carga datos en la tabla 'clinicaSet.Citas' Puede moverla o quitarla según sea necesario.
            this.citasTableAdapter.Fill(this.clinicaSet.Citas);

            

        }




        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string Nombre = selectedRow.Cells[0].Value.ToString();
                string Doctor = selectedRow.Cells[1].Value.ToString();
                DateTime Fecha = DateTime.Parse(selectedRow.Cells[2].Value.ToString());

                comboMedico.Text = Doctor;
                comboPaciente.Text = Nombre;
                dateTimePicker1.Value = Fecha;
                FechaAnterior = Fecha;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActualizarCitas actualizar = new ActualizarCitas();
            int idpaciente = int.Parse(comboPaciente.SelectedValue.ToString());
            int idmedico = int.Parse(comboMedico.SelectedValue.ToString());

            actualizar.Actualizar(idmedico, idpaciente, dateTimePicker1.Value, FechaAnterior, false);

            

            // Actualiza el DataGridView
          

            MessageBoxIcon iconO = MessageBoxIcon.Information;
            MessageBoxIcon iconE = MessageBoxIcon.Error;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            

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
            ActualizarCitas actualizar = new ActualizarCitas();
            int idpaciente = int.Parse(comboPaciente.SelectedValue.ToString());
            int idmedico = int.Parse(comboMedico.SelectedValue.ToString());

            actualizar.Actualizar(idmedico, idpaciente, dateTimePicker1.Value, FechaAnterior, true);

            MessageBoxIcon iconO = MessageBoxIcon.Information;
            MessageBoxIcon iconE = MessageBoxIcon.Error;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
         
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
