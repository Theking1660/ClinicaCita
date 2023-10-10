using Cita_Medica.ClinicaSetTableAdapters;
using Cita_Medica.Modelos;
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
    public partial class Calendario : Form
    {
        public Calendario()
        {
            InitializeComponent();
            this.TopLevel = false;
        }
        CitasFecha citasFecha = null;

        private void Calendario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clinicaSet.Citas' Puede moverla o quitarla según sea necesario.
            this.citasTableAdapter.Fill(this.clinicaSet.Citas);
            // Configurar el MonthCalendar
            monthCalendar1.MaxSelectionCount = 1;
            citasFecha = new CitasFecha();
            // Manejar el evento DateChanged del MonthCalendar
            monthCalendar1.DateChanged += new DateRangeEventHandler(monthCalendar1_DateChanged);

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            List<string> dates = citasFecha.Actualizar();
            DateTime fechaSeleccionada = monthCalendar1.SelectionStart;
            if (dates.Contains(fechaSeleccionada.ToShortDateString()))
            {
                CitasTableAdapter citas = new CitasTableAdapter();
                var info = citas.GetData().Where(c => c.Fecha.ToShortDateString() == fechaSeleccionada.ToShortDateString());
             citasBindingSource.DataSource = info.ToArray();
                dataGridView1.DataSource = citasBindingSource.DataSource;
                    
                dataGridView1.Refresh();
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["RowError"].Visible = false;
                dataGridView1.Columns["Table"].Visible = false;
                dataGridView1.Columns["RowState"].Visible = false;
                dataGridView1.Columns["HasErrors"].Visible = false;
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
            }
        }
    }
}
