using Cita_Medica.ClinicaSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cita_Medica.Funciones
{
    internal class ActualizarCitas
    {
        public string Error = string.Empty;
        public void Actualizar(int Idmedico,int idpaciente,DateTime FechaNueva,DateTime FechaAnterior,bool accion)
        {
            CitaTableAdapter cita   = new CitaTableAdapter();   

            try
            {
                cita.ActualizarCitas(Idmedico,idpaciente,FechaNueva,FechaAnterior,accion);
                Error = "Cita Modificada";
            }
            catch  (Exception e)
            {
                Error = e.Message;
            }

        }
    }
}
