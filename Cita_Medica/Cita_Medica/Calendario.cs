using Cita_Medica.ClinicaSetTableAdapters; // Importa el espacio de nombres ClinicaSetTableAdapters
using Cita_Medica.Modelos; // Importa el espacio de nombres Modelos
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
            this.TopLevel = false; // Establece el formulario como secundario en la jerarquía de ventanas
        }

        CitasFecha citasFecha = null; // Declaración de una instancia de la clase CitasFecha

        private void Calendario_Load(object sender, EventArgs e)
        {
            // Carga datos de citas en el formulario
            this.citasTableAdapter.Fill(this.clinicaSet.Citas);

            // Configura el MonthCalendar para permitir seleccionar una sola fecha
            monthCalendar1.MaxSelectionCount = 1;

            // Inicializa una instancia de la clase CitasFecha
            citasFecha = new CitasFecha();

            // Asocia el evento DateChanged del MonthCalendar a la función monthCalendar1_DateChanged
            monthCalendar1.DateChanged += new DateRangeEventHandler(monthCalendar1_DateChanged);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Obtiene una lista de fechas actualizada desde la instancia de CitasFecha
            List<string> dates = citasFecha.Actualizar();

            // Obtiene la fecha seleccionada en el MonthCalendar
            DateTime fechaSeleccionada = monthCalendar1.SelectionStart;

            // Verifica si la fecha seleccionada está en la lista de fechas disponibles
            if (dates.Contains(fechaSeleccionada.ToShortDateString()))
            {
                CitasTableAdapter citas = new CitasTableAdapter();

                // Filtra y obtiene información de citas para la fecha seleccionada
                var info = citas.GetData().Where(c => c.Fecha.ToShortDateString() == fechaSeleccionada.ToShortDateString());

                // Configura la fuente de datos del control DataGridView
                citasBindingSource.DataSource = info.ToArray();
                dataGridView1.DataSource = citasBindingSource.DataSource;

                // Actualiza y refresca el control DataGridView
                dataGridView1.Refresh();

                // Oculta columnas no deseadas en el DataGridView
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["RowError"].Visible = false;
                dataGridView1.Columns["Table"].Visible = false;
                dataGridView1.Columns["RowState"].Visible = false;
                dataGridView1.Columns["HasErrors"].Visible = false;
            }
            else
            {
                // Si la fecha seleccionada no está en la lista de fechas disponibles, borra el DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
            }
        }
    }
}
