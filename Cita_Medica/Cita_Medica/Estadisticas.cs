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
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
            this.TopLevel = false;
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clinicaSet.Citas' Puede moverla o quitarla según sea necesario.
            this.citasTableAdapter.Fill(this.clinicaSet.Citas);

        }
    }
}
