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
        // Crear una instancia del adaptador de tabla UsuarioTableAdapter para interactuar con la tabla de usuarios
        UsuarioTableAdapter Usuario = new UsuarioTableAdapter();

        // Método para validar el inicio de sesión
        public bool Validar(string usuario, string contraseña)
        {
            bool R = false;

            // Iterar a través de los datos de usuarios y verificar las credenciales proporcionadas
            foreach (var item in Usuario.GetData().Where(C => C.NombreUsuario.ToUpper() == usuario && C.Contraseña == contraseña))
            {
                R = true; // Las credenciales son válidas
            }

            return R;
        }
    }
}
/*A continuación, se describe lo que hace el código:

La clase Iniciar_Seccion está en el espacio de nombres Cita_Medica.Funciones.

La clase tiene una instancia del adaptador de tabla UsuarioTableAdapter que se utiliza para interactuar con la tabla de usuarios en una base de datos.

El método Validar toma dos parámetros:

usuario: El nombre de usuario proporcionado para iniciar sesión.
contraseña: La contraseña proporcionada para iniciar sesión.
Dentro del método Validar, se inicializa una variable R en false, que se utilizará para indicar si las credenciales son válidas.

El código itera a través de los datos de usuarios obtenidos de la base de datos utilizando Usuario.GetData(). 
Luego, se utiliza Where para filtrar los usuarios cuyo nombre de usuario coincida (ignorando mayúsculas y minúsculas) con el usuario proporcionado y cuya contraseña coincida con la contraseña proporcionada.

Si se encuentra un usuario que coincide con las credenciales proporcionadas, se establece R en true, lo que indica que las credenciales son válidas.

Finalmente, el método devuelve el valor de R, que será true si las credenciales son válidas y false si no lo son.

En resumen, este código valida el inicio de sesión de usuarios comparando las credenciales proporcionadas con los datos de usuarios almacenados en la base de datos. 
Si las credenciales son válidas, devuelve true; de lo contrario, devuelve false.*/