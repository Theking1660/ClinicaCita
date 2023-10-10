using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cita_Medica.ClinicaSetTableAdapters;

namespace Cita_Medica.Funciones
{
    internal class AgregarMedico
    {
        public string Error = string.Empty;
        public bool Agregar(string Nombre, string Especialidad, string Contraseña)
        {
            MedicoTableAdapter medico = new MedicoTableAdapter();
            bool R;
            Nombre = "Dr " + Nombre;
            try
            {
               
                medico.InsertMedico(Nombre, Especialidad, Contraseña);
                R = true;
                Error = string.Empty;
                
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
