using System;
using Cita_Medica.ClinicaSetTableAdapters;

namespace Cita_Medica.Funciones
{
    internal class AgregarMedico
    {
        // Variable para almacenar mensajes de error o información de estado
        public string Error = string.Empty;

        // Método para agregar un nuevo médico
        public bool Agregar(string Nombre, string Especialidad, string Contraseña)
        {
            // Crear una instancia del adaptador de tabla MedicoTableAdapter
            MedicoTableAdapter medico = new MedicoTableAdapter();

            // Variable para almacenar el resultado de la inserción
            bool R;

            // Modificar el nombre para incluir el título "Dr"
            Nombre = "Dr " + Nombre;

            try
            {
                // Intentar insertar un nuevo médico utilizando el adaptador
                medico.InsertMedico(Nombre, Especialidad, Contraseña);

                // Si la inserción es exitosa, establecer R en true y limpiar el mensaje de error
                R = true;
                Error = string.Empty;
            }
            catch (Exception e)
            {
                // Si ocurre una excepción durante la inserción, establecer R en false
                // y capturar el mensaje de error de la excepción
                R = false;
                Error = e.Message;
            }

            // Devolver R, que indica si la inserción fue exitosa (true) o no (false)
            return R;
        }
    }
}
/*A continuación, se describe lo que hace el código:

La clase AgregarMedico está en el espacio de nombres Cita_Medica.Funciones.

La clase tiene una variable pública llamada Error que se utiliza para almacenar mensajes de error o información de estado relacionada con la adición de médicos.

El método Agregar toma tres parámetros:

Nombre: El nombre del médico.
Especialidad: La especialidad del médico.
Contraseña: La contraseña del médico (probablemente se use para el inicio de sesión).
Dentro del método Agregar, se crea una instancia del adaptador de tabla MedicoTableAdapter para interactuar con la tabla de médicos.

El código modifica el nombre del médico para incluir el título "Dr" antes del nombre.

Luego, el código intenta insertar un nuevo médico utilizando el adaptador y los parámetros proporcionados.

Si la inserción es exitosa, se establece la variable Error en una cadena vacía y se devuelve true.

Si ocurre alguna excepción durante la inserción, se captura el mensaje de error de la excepción en la variable Error y se devuelve false.

En resumen, este código maneja la inserción de nuevos médicos en una base de datos y proporciona información de estado a través de la variable Error. 
Si se agrega un médico con éxito, devuelve true; de lo contrario, devuelve false.*/