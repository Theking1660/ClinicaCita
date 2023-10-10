using Cita_Medica.ClinicaSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Cita_Medica
{
    public partial class Principal : Form
    {
        private bool pacienteFormAbierto = false;
        private Paciente formularioPaciente = new Paciente();
        private bool calendarioForm = false;
        private Calendario calendario = new Calendario();
        private bool CitasForm = false;
        private Citas citas = new Citas();
        private bool MedicoForm = false;
        private Medico medico = new Medico();
        private bool ModificarcitasForm = false;
        private ModificarCitas modificar = new ModificarCitas();
        private bool EstadisticaForm = false;
        private Estadisticas estadisticas = new Estadisticas();

        public Principal()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clinicaSet.Citas' Puede moverla o quitarla según sea necesario.
            this.citasTableAdapter.Fill(this.clinicaSet.Citas);


        }


        private void CerrarForms(Form form)
        {

            if (form is Paciente)
            {
                pacienteFormAbierto = false;
            }
            else if (form is Medico)
            {
                MedicoForm = false;
            }
            else if (form is Estadisticas)
            {
                EstadisticaForm = false;
            }
            else if (form is Citas)
            {
                CitasForm = false;
            }
            else if (form is ModificarCitas)
            {
                ModificarcitasForm = false;
            }
            else if (form is Calendario)
            {
                calendarioForm = false;
            }
        }


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

                // Asegurarse de que el formulario Paciente esté en el frente (por encima del DataGridView)
                calendario.BringToFront();

                calendarioForm = true;

                // Manejar el evento de cierre del formulario Paciente para actualizar la variable pacienteFormAbierto
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

                // Asegurarse de que el formulario Paciente esté en el frente (por encima del DataGridView)
                modificar.BringToFront();

                ModificarcitasForm = true;

                // Manejar el evento de cierre del formulario Paciente para actualizar la variable pacienteFormAbierto
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

                // Asegurarse de que el formulario Paciente esté en el frente (por encima del DataGridView)
                citas.BringToFront();

                CitasForm = true;

                // Manejar el evento de cierre del formulario Paciente para actualizar la variable pacienteFormAbierto
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

        private void button1_Click(object sender, EventArgs e)
        {

            if (!MedicoForm)
            {
                medico = new Medico();
                // Crear una lista temporal para almacenar formularios a cerrar
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

                // Asegurarse de que el formulario Paciente esté en el frente (por encima del DataGridView)
                medico.BringToFront();

                MedicoForm = true;

                // Manejar el evento de cierre del formulario Paciente para actualizar la variable pacienteFormAbierto
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

                // Asegurarse de que el formulario Paciente esté en el frente (por encima del DataGridView)
                estadisticas.BringToFront();

                EstadisticaForm = true;

                // Manejar el evento de cierre del formulario Paciente para actualizar la variable pacienteFormAbierto
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

        private void Principal_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            CitasTableAdapter citas = new CitasTableAdapter();
            dataGridView1.Refresh();
            citasBindingSource.DataSource = citas.GetData();
            dataGridView1.DataSource = citasBindingSource;

        }
    }
}
