using Cita_Medica.ClinicaSetTableAdapters;
using Cita_Medica.Funciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Cita_Medica.Modelos
{
    internal class CitasFecha 
    {
        
        
        internal List<string> Actualizar()
        {
            CitasTableAdapter citas = new CitasTableAdapter();
            List<string> lista = citas.GetData().Select(c => c.Fecha.ToShortDateString()).ToList();
            return lista;
        }
    }
}
