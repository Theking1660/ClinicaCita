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
            this.TopLevel = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarPaciente agregar = new AgregarPaciente();
            if (agregar.Agregar(TxtNombre.Text, long.Parse(TxtCedula.Text), dateFecha.Value, TxtNumero.Text))
            {
                MessageBoxIcon icon = MessageBoxIcon.Information;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Paciente Agregado", "Estado", buttons, icon);


            }
            else
            {
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(agregar.Error, "Error", MessageBoxButtons.OK, icon);
            }

        }
    }
}
