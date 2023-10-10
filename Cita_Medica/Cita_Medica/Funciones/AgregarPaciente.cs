using Cita_Medica.ClinicaSetTableAdapters;
using System;

namespace Cita_Medica.Funciones
{
    internal class AgregarPaciente
    {
        // Variable para almacenar mensajes de error o información de estado
        public string Error = string.Empty;

        // Método para agregar un nuevo paciente
        public bool Agregar(string Nombre, long Cedula, DateTime fecha, string numero)
        {
            // Crear una instancia del adaptador de tabla PacienteTableAdapter
            PacienteTableAdapter paciente = new PacienteTableAdapter();

            // Variable para almacenar el resultado de la inserción
            bool R;

            // Intentar insertar un nuevo paciente utilizando el adaptador
            var insertar = paciente.InsertPaciente(Nombre, Cedula, fecha, numero);

            try
            {
                // Comprobar si la inserción fue exitosa
                if (insertar.ToString() == "1")
                {
                    R = true; // La inserción fue exitosa
                    Error = string.Empty; // Limpiar el mensaje de error
                }
                else
                {
                    R = false; // La inserción falló debido a que ya existe un paciente con la misma cédula
                    Error = "Paciente Existente"; // Establecer un mensaje de error
                }
            }
            catch (Exception e)
            {
                // Si ocurre una excepción durante la inserción, capturar el mensaje de error de la excepción
                R = false; // La inserción falló debido a una excepción
                Error = e.Message; // Capturar el mensaje de error de la excepción
            }

            // Devolver R, que indica si la inserción fue exitosa (true) o no (false)
            return R;
        }
    }
}

/*Aquí tienes una descripción de lo que hace el código:

La clase AgregarPaciente está en el espacio de nombres Cita_Medica.Funciones.

La clase tiene una variable pública llamada Error que se utiliza para almacenar mensajes de error o información de estado relacionada con la adición de pacientes.

El método Agregar toma cuatro parámetros:

Nombre: El nombre del paciente.
Cedula: El número de cédula del paciente (se asume como tipo long).
fecha: La fecha de nacimiento del paciente.
numero: Un número de contacto o teléfono del paciente.
Dentro del método Agregar, se crea una instancia del adaptador de tabla PacienteTableAdapter para interactuar con la tabla de pacientes.

Luego, el código intenta insertar un nuevo paciente utilizando el adaptador y los parámetros proporcionados.

Se verifica si la inserción fue exitosa. Si es así, se establece la variable Error en una cadena vacía y se devuelve true. 
Si la inserción falla debido a que ya existe un paciente con la misma cédula, se establece la variable Error en "Paciente Existente" y se devuelve false.

Si ocurre alguna excepción durante la inserción, se captura el mensaje de error de la excepción en la variable Error y se devuelve false.

En resumen, este código maneja la inserción de nuevos pacientes en una base de datos y proporciona información de estado a través de la variable Error. 
Si se agrega un paciente con éxito, devuelve true; de lo contrario, devuelve false.*/
