using Cita_Medica.ClinicaSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Cita_Medica
{
    public partial class Principal : Form
    {
        // Variables para controlar si se han abierto los diferentes formularios secundarios
        private bool pacienteFormAbierto = false;
        private bool calendarioForm = false;
        private bool CitasForm = false;
        private bool MedicoForm = false;
        private bool ModificarcitasForm = false;
        private bool EstadisticaForm = false;

        // Instancias de los formularios secundarios
        private Paciente formularioPaciente = new Paciente();
        private Calendario calendario = new Calendario();
        private Citas citas = new Citas();
        private Medico medico = new Medico();
        private ModificarCitas modificar = new ModificarCitas();
        private Estadisticas estadisticas = new Estadisticas();

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clinicaSet.Citas' Puede moverla o quitarla según sea necesario.
            this.citasTableAdapter.Fill(this.clinicaSet.Citas);
        }

        // Método para cerrar formularios secundarios
        private void CerrarForms(Form form)
        {
            // Según el tipo de formulario, se actualiza la variable correspondiente
            if (form is Paciente)
            {
                pacienteFormAbierto = false;
            }
            else if (form is Calendario)
            {
                calendarioForm = false;
            }
            else if (form is Citas)
            {
                CitasForm = false;
            }
            else if (form is Medico)
            {
                MedicoForm = false;
            }
            else if (form is ModificarCitas)
            {
                ModificarcitasForm = false;
            }
            else if (form is Estadisticas)
            {
                EstadisticaForm = false;
            }
        }

        // Evento Click del botón "Paciente"
        private void button2_Click(object sender, EventArgs e)
        {
            if (!pacienteFormAbierto)
            {
                formularioPaciente = new Paciente();
                List<Form> formulariosACerrar = new List<Form>();

                // Recorrer todos los formularios abiertos excepto el formulario principal
                foreach (Form form in Application.OpenForms)
                {
                    if (form != this && form != formularioPaciente) // Excluye el formulario principal
                    {
                        formulariosACerrar.Add(form); // Agrega el formulario a la lista temporal
                    }
                }

                // Cerrar los formularios almacenados en la lista temporal
                foreach (Form form in formulariosACerrar)
                {
                    form.Hide();
                    CerrarForms(form);
                }

                formularioPaciente.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(formularioPaciente);

                // Asegurarse de que el formulario Paciente esté en el frente (por encima del DataGridView)
                formularioPaciente.BringToFront();

                pacienteFormAbierto = true;

                // Manejar el evento de cierre del formulario Paciente para actualizar la variable pacienteFormAbierto
                formularioPaciente.FormClosed += (s, args) =>
                {
                    pacienteFormAbierto = false;
                    CitasTableAdapter citas = new CitasTableAdapter();
                    dataGridView1.DataSource = null;
                    dataGridView1.Refresh();
                    citasBindingSource.DataSource = citas.GetData();
                    dataGridView1.DataSource = citasBindingSource;
                };

                formularioPaciente.Show();
            }
            else
            {
                // Si el formulario ya está abierto, enfócalo en lugar de abrir una nueva instancia
                formularioPaciente.Focus();
            }
        }

        // Evento Click del botón "Calendario"
        private void button4_Click(object sender, EventArgs e)
        {
            if (!calendarioForm)
            {
                calendario = new Calendario();
                List<Form> formulariosACerrar = new List<Form>();

                // Recorrer todos los formularios abiertos excepto el formulario principal
                foreach (Form form in Application.OpenForms)
                {
                    if (form != this && form != calendario) // Excluye el formulario principal
                    {
                        formulariosACerrar.Add(form); // Agrega el formulario a la lista temporal
                    }
                }

                // Cerrar los formularios almacenados en la lista temporal
                foreach (Form form in formulariosACerrar)
                {
                    form.Hide();
                    CerrarForms(form);
                }

                calendario.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(calendario);

                // Asegurarse de que el formulario Calendario esté en el frente
                calendario.BringToFront();

                calendarioForm = true;

                // Manejar el evento de cierre del formulario Calendario para actualizar la variable calendarioForm
                calendario.FormClosed += (s, args) =>
                {
                    calendarioForm = false;
                    CitasTableAdapter citas = new CitasTableAdapter();
                    dataGridView1.DataSource = null;
                    dataGridView1.Refresh();
                    citasBindingSource.DataSource = citas.GetData();
                    dataGridView1.DataSource = citasBindingSource;
                };

                calendario.Show();
            }
            else
            {
                // Si el formulario ya está abierto, enfócalo en lugar de abrir una nueva instancia
                calendario.Focus();
            }
        }

        // Evento Click del botón "Modificar Citas"
        private void button5_Click(object sender, EventArgs e)
        {
            if (!ModificarcitasForm)
            {
                modificar = new ModificarCitas();
                List<Form> formulariosACerrar = new List<Form>();

                // Recorrer todos los formularios abiertos excepto el formulario principal
                foreach (Form form in Application.OpenForms)
                {
                    if (form != this && form != modificar) // Excluye el formulario principal
                    {
                        formulariosACerrar.Add(form); // Agrega el formulario a la lista temporal
                    }
                }

                // Cerrar los formularios almacenados en la lista temporal
                foreach (Form form in formulariosACerrar)
                {
                    form.Hide();
                    CerrarForms(form);
                }

                modificar.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(modificar);

                // Asegurarse de que el formulario Modificar Citas esté en el frente
                modificar.BringToFront();

                ModificarcitasForm = true;

                // Manejar el evento de cierre del formulario Modificar Citas para actualizar la variable ModificarcitasForm
                modificar.FormClosed += (s, args) =>
                {
                    ModificarcitasForm = false;
                    CitasTableAdapter citas = new CitasTableAdapter();
                    dataGridView1.DataSource = null;
                    dataGridView1.Refresh();
                    citasBindingSource.DataSource = citas.GetData();
                    dataGridView1.DataSource = citasBindingSource;
                };

                modificar.Show();
            }
            else
            {
                // Si el formulario ya está abierto, enfócalo en lugar de abrir una nueva instancia
                modificar.Focus();
            }
        }

        // Evento Click del botón "Citas"
        private void button3_Click(object sender, EventArgs e)
        {
            if (!CitasForm)
            {
                citas = new Citas();
                List<Form> formulariosACerrar = new List<Form>();

                // Recorrer todos los formularios abiertos excepto el formulario principal
                foreach (Form form in Application.OpenForms)
                {
                    if (form != this && form != citas) // Excluye el formulario principal
                    {
                        formulariosACerrar.Add(form); // Agrega el formulario a la lista temporal
                    }
                }

                // Cerrar los formularios almacenados en la lista temporal
                foreach (Form form in formulariosACerrar)
                {
                    form.Hide();
                    CerrarForms(form);
                }

                citas.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(citas);

                // Asegurarse de que el formulario Citas esté en el frente
                citas.BringToFront();

                CitasForm = true;

                // Manejar el evento de cierre del formulario Citas para actualizar la variable CitasForm
                citas.FormClosed += (s, args) =>
                {
                    CitasForm = false;
                    CitasTableAdapter citas = new CitasTableAdapter();
                    dataGridView1.DataSource = null;
                    dataGridView1.Refresh();
                    citasBindingSource.DataSource = citas.GetData();
                    dataGridView1.DataSource = citasBindingSource;
                };

                citas.Show();
            }
            else
            {
                // Si el formulario ya está abierto, enfócalo en lugar de abrir una nueva instancia
                citas.Focus();
            }
        }

        // Evento Click del botón "Médico"
        private void button1_Click(object sender, EventArgs e)
        {
            if (!MedicoForm)
            {
                medico = new Medico();
                List<Form> formulariosACerrar = new List<Form>();

                // Recorrer todos los formularios abiertos excepto el formulario principal
                foreach (Form form in Application.OpenForms)
                {
                    if (form != this && form != medico) // Excluye el formulario principal
                    {
                        formulariosACerrar.Add(form); // Agrega el formulario a la lista temporal
                    }
                }

                // Cerrar los formularios almacenados en la lista temporal
                foreach (Form form in formulariosACerrar)
                {
                    form.Hide();
                    CerrarForms(form);
                }

                medico.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(medico);

                // Asegurarse de que el formulario Médico esté en el frente
                medico.BringToFront();

                MedicoForm = true;

                // Manejar el evento de cierre del formulario Médico para actualizar la variable MedicoForm
                medico.FormClosed += (s, args) =>
                {
                    MedicoForm = false;
                    CitasTableAdapter citas = new CitasTableAdapter();
                    dataGridView1.DataSource = null;
                    dataGridView1.Refresh();
                    citasBindingSource.DataSource = citas.GetData();
                    dataGridView1.DataSource = citasBindingSource;
                };

                medico.Show();
            }
            else
            {
                // Si el formulario ya está abierto, enfócalo en lugar de abrir una nueva instancia
                medico.Focus();
            }
        }

        // Evento Click del botón "Estadísticas"
        private void button6_Click(object sender, EventArgs e)
        {
            if (!EstadisticaForm)
            {
                estadisticas = new Estadisticas();
                List<Form> formulariosACerrar = new List<Form>();

                // Recorrer todos los formularios abiertos excepto el formulario principal
                foreach (Form form in Application.OpenForms)
                {
                    if (form != this && form != estadisticas) // Excluye el formulario principal
                    {
                        formulariosACerrar.Add(form); // Agrega el formulario a la lista temporal
                    }
                }

                // Cerrar los formularios almacenados en la lista temporal
                foreach (Form form in formulariosACerrar)
                {
                    form.Hide();
                    CerrarForms(form);
                }

                estadisticas.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(estadisticas);

                // Asegurarse de que el formulario Estadísticas esté en el frente
                estadisticas.BringToFront();

                EstadisticaForm = true;

                // Manejar el evento de cierre del formulario Estadísticas para actualizar la variable EstadisticaForm
                estadisticas.FormClosed += (s, args) =>
                {
                    EstadisticaForm = false;
                    CitasTableAdapter citas = new CitasTableAdapter();
                    dataGridView1.DataSource = null;
                    dataGridView1.Refresh();
                    citasBindingSource.DataSource = citas.GetData();
                    dataGridView1.DataSource = citasBindingSource;
                };

                estadisticas.Show();
            }
            else
            {
                // Si el formulario ya está abierto, enfócalo en lugar de abrir una nueva instancia
                estadisticas.Focus();
            }
        }

        // Evento Click del botón "Recargar Datos"
        private void Principal_Click(object sender, EventArgs e)
        {
            // Actualiza los datos en el DataGridView al hacer clic en el formulario principal
            dataGridView1.DataSource = null;
            CitasTableAdapter citas = new CitasTableAdapter();
            dataGridView1.Refresh();
            citasBindingSource.DataSource = citas.GetData();
            dataGridView1.DataSource = citasBindingSource;
        }

        // Evento Click del botón "Cerrar Sesión"
        private void button7_Click(object sender, EventArgs e)
        {
            // Cerrar sesión: ocultar formularios abiertos y recargar datos en el DataGridView
            List<Form> formulariosACerrar = new List<Form>();

            dataGridView1.DataSource = null;
            CitasTableAdapter citas = new CitasTableAdapter();
            dataGridView1.Refresh();
            citasBindingSource.DataSource = citas.GetData();
            dataGridView1.DataSource = citasBindingSource;

            // Recorrer todos los formularios abiertos excepto el formulario principal
            foreach (Form form in Application.OpenForms)
            {
                if (form != this) // Excluye el formulario principal
                {
                    formulariosACerrar.Add(form); // Agrega el formulario a la lista temporal
                }
            }

            // Cerrar los formularios almacenados en la lista temporal
            foreach (Form form in formulariosACerrar)
            {
                form.Hide();
                CerrarForms(form);
            }
        }

        // Evento FormClosing del formulario Principal
        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Manejar el evento de cierre del formulario Principal y asegurarse de que se cierre toda la aplicación al hacer clic en la "x".
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // El cierre fue solicitado por el usuario, no por otro motivo (por ejemplo, una excepción).
                Application.Exit(); // Cierra la aplicación por completo.
            }
        }

        // Evento Click del botón "Cerrar Sesión" en la barra de menú
        private void button8_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario principal y mostrar el formulario de inicio de sesión
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
/*Este código controla la apertura y cierre de diferentes formularios secundarios en la aplicación principal. 
 Cuando se hace clic en un botón (como "Paciente", "Calendario", "Modificar Citas", etc.), verifica si el formulario correspondiente ya está abierto y lo muestra o lo crea y lo muestra. 
 También se encarga de cerrar los formularios secundarios cuando se hace clic en el botón "Cerrar Sesión" y de actualizar los datos en el DataGridView al hacer clic en el formulario principal. 
 Además, maneja el evento de cierre del formulario principal para asegurarse de que se cierre toda la aplicación correctamente.

*/