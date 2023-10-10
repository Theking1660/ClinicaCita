using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cita_Medica.ClinicaSetTableAdapters;

namespace Cita_Medica.Funciones
{
    internal class AgregarCitas
    {
        public string Error = string.Empty;

        public bool Agregar(int IdPaciente, int IdMedico, DateTime fecha)
        {
            CitaTableAdapter cita = new CitaTableAdapter();

            bool R;
            var insertar = cita.InsertCita(IdPaciente, IdMedico, fecha);
            try
            {
                if (insertar.ToString()=="1")
                {
                    R = true;
                    Error = string.Empty;
                }
                else
                {
                    R = false;
                    Error = "Choque de Horario";
                }
               
            }
            catch (Exception ex)
            {
                R = false;
                Error = ex.Message;
            }
            return R;
        }
    }
}
