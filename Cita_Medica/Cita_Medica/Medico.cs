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
    public partial class Medico : Form
    {
        public Medico()
        {
            InitializeComponent();
            this.TopLevel = false;
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            AgregarMedico agregar = new AgregarMedico();
            if (agregar.Agregar(TxtNombre.Text, TxtEspecialidad.Text, TxtContra.Text))
            { 
                MessageBoxIcon icon = MessageBoxIcon.Information;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Medico Agregado", "Estado", buttons, icon);

                TxtContra.Text = string.Empty;
                TxtEspecialidad.Text = string.Empty;
                TxtNombre.Text = string.Empty;
            }
            else
            {
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(agregar.Error,"Error",MessageBoxButtons.OK,icon);
            }

        }
    }
}
