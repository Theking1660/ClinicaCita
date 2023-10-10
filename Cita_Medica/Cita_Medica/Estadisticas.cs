using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; // Importa el espacio de nombres necesario para usar gráficos

namespace Cita_Medica
{
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
            this.TopLevel = false; // Establece el formulario como secundario en la jerarquía de ventanas
        }

        // Clase auxiliar para representar una cita con fecha
        public class Cita
        {
            public DateTime Fecha { get; set; }
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clinicaSet.Citas' Puede moverla o quitarla según sea necesario.
            this.citasTableAdapter.Fill(this.clinicaSet.Citas);

            List<Cita> listaDeCitas = new List<Cita>();

            // Llena la lista de citas con fechas desde la base de datos
            foreach (var item in this.clinicaSet.Citas)
            {
                var fecha = new Cita
                {
                    Fecha = item.Fecha
                };
                listaDeCitas.Add(fecha);
            }

            // Realiza el análisis de las citas para obtener los días y horas más frecuentes
            var citasPorDiaYHora = listaDeCitas
                .GroupBy(c => new { Dia = c.Fecha.DayOfWeek, Hora = c.Fecha.Hour })
                .Select(group => new
                {
                    DiaHora = $"{group.Key.Dia} - {group.Key.Hora}:00",
                    Cantidad = group.Count()
                })
                .OrderByDescending(item => item.Cantidad)
                .Take(10); // Obtén los 10 días y horas más frecuentes

            // Llena el gráfico con los datos
            chart1.Series.Clear();
            var series = new Series("Frecuencia");

            foreach (var cita in citasPorDiaYHora)
            {
                series.Points.AddXY(cita.DiaHora, cita.Cantidad);
                series.Color = Color.OrangeRed;
            }

            chart1.Series.Add(series);
            series.ChartType = SeriesChartType.Bar;

            // Personaliza el aspecto visual del gráfico
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.Title = "Día - Hora";
            chart1.ChartAreas[0].AxisY.Title = "Cantidad";
            chart1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Myanmar Text", 14);
            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Myanmar Text", 14);

            chart1.Titles.Add("Días y Horas más Frecuentes");
            chart1.Titles[0].Font = new Font("Nyanmar Text", 16, FontStyle.Bold);

            // Ajusta la leyenda del gráfico
            chart1.Legends.Add(new Legend("Leyenda"));
            chart1.Legends[0].Title = "Leyenda";
            chart1.Series[0].LegendText = "Frecuencia";
            chart1.BackColor = Color.LightGray;

            // Actualiza el gráfico
            chart1.DataBind();
        }
    }
}
