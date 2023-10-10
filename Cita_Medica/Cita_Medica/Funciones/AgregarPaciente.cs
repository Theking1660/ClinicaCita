using Cita_Medica.ClinicaSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cita_Medica.Funciones
{
    internal class AgregarPaciente
    {
        public string Error = string.Empty;

        public bool Agregar(string Nombre,long Cedula,DateTime fecha,string numero)
        {
            PacienteTableAdapter paciente = new PacienteTableAdapter();
            var insertar = paciente.InsertPaciente(Nombre,Cedula,fecha,numero);
            bool R;
            try
            {
                if(insertar.ToString() == "1")
                {
                    R = true;
                    Error = string.Empty;
                }
                else
                {
                    R = false;
                    Error = "Paciente Existente";
                }
            }
            catch (Exception e)
            {
                R = false;
                Error = e.Message;
            }
            return R;
        }
    }
}
