using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cita_Medica.Modelos
{
    internal class MCitas
    {
      
        
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Numero { get; set; }
            public long Cedula { get; set; }
            public string Doctor { get; set; }
            public string Area { get; set; }
            public DateTime Fecha { get; set; }
            public bool Estado { get; set; }
        

    }
}
