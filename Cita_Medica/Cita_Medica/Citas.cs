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
    public partial class Citas : Form
    {
        public Citas()
        {
            InitializeComponent();
            this.TopLevel = false;
        }

        private void Citas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clinicaSet.Paciente' Puede moverla o quitarla según sea necesario.
            this.pacienteTableAdapter.Fill(this.clinicaSet.Paciente);

            // TODO: esta línea de código carga datos en la tabla 'clinicaSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.clinicaSet.Usuario);
            // TODO: esta línea de código carga datos en la tabla 'clinicaSet.Medico' Puede moverla o quitarla según sea necesario.
            this.medicoTableAdapter.Fill(this.clinicaSet.Medico);

            // TODO: esta línea de código carga datos en la tabla 'clinicaSet.Paciente' Puede moverla o quitarla según sea necesario.
            this.pacienteTableAdapter.Fill(this.clinicaSet.Paciente);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarCitas agregar = new AgregarCitas();

            int idpaciente = int.Parse(comboPaciente.SelectedValue.ToString());
            int idmedico = int.Parse(comboMedico.SelectedValue.ToString()) ;    
            if (agregar.Agregar(idpaciente, idmedico, dateTimePicker1.Value))
            {
                MessageBoxIcon icon = MessageBoxIcon.Information;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Cita Agregada", "Estado", buttons, icon);


            }
            else
            {
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(agregar.Error, "Error", MessageBoxButtons.OK, icon);
            }
        }
    }
}
