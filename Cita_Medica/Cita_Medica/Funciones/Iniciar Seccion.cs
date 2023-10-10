using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cita_Medica.ClinicaSetTableAdapters;

namespace Cita_Medica.Funciones
{
    internal class Iniciar_Seccion
    {
        UsuarioTableAdapter Usuario = new UsuarioTableAdapter();
        public bool Validar(string usuario, string contraseña)
        {
            bool R = false;
           foreach(var item in Usuario.GetData().Where(C=> C.NombreUsuario.ToUpper() == usuario && C.Contraseña == contraseña))
            {
                R= true; 
            }

            return R;
   
        }
    }
}
