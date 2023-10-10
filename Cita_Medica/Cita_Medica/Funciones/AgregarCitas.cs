using System;
using Cita_Medica.ClinicaSetTableAdapters;

namespace Cita_Medica.Funciones
{
    internal class AgregarCitas
    {
        // Variable para almacenar mensajes de error o información de estado
        public string Error = string.Empty;

        // Método para agregar citas médicas
        public bool Agregar(int IdPaciente, int IdMedico, DateTime fecha)
        {
            // Crear una instancia del adaptador de tabla CitaTableAdapter
            CitaTableAdapter cita = new CitaTableAdapter();

            // Variable para almacenar el resultado de la inserción
            bool R;

            // Intentar insertar una cita utilizando el adaptador
            var insertar = cita.InsertCita(IdPaciente, IdMedico, fecha);

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
                    R = false; // La inserción falló debido a un choque de horario
                    Error = "Choque de Horario"; // Establecer un mensaje de error
                }
            }
            catch (Exception ex)
            {
                R = false; // La inserción falló debido a una excepción
                Error = ex.Message; // Capturar el mensaje de error de la excepción
            }

            // Devolver el resultado (true si se agregó la cita, false si no)
            return R;
        }
    }
}

/*Aquí hay una descripción de lo que hace el código:

La clase AgregarCitas está en el espacio de nombres Cita_Medica.Funciones.

La clase tiene una variable pública llamada Error que se utiliza para almacenar mensajes de error o información de estado relacionada con la adición de citas.

El método Agregar toma tres parámetros:

IdPaciente: El ID del paciente asociado a la cita.
IdMedico: El ID del médico asociado a la cita.
fecha: La fecha de la cita.
Dentro del método Agregar, se crea una instancia del adaptador de tabla CitaTableAdapter para interactuar con la tabla de citas.

Luego, el código intenta insertar una cita utilizando el adaptador y los parámetros proporcionados.

Se verifica si la inserción fue exitosa. Si es así, se establece la variable Error en una cadena vacía y se devuelve true. 
Si la inserción falla debido a un choque de horario, se establece la variable Error en "Choque de Horario" y se devuelve false.

Si ocurre alguna excepción durante la inserción, se captura el mensaje de error de la excepción en la variable Error y se devuelve false.

En resumen, este código maneja la inserción de citas médicas en una base de datos y proporciona información de estado a través de la variable Error. 
Si se agrega la cita con éxito, devuelve true; de lo contrario, devuelve false.

*/