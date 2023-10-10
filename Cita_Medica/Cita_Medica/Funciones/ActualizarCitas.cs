using Cita_Medica.ClinicaSetTableAdapters;
using System;

namespace Cita_Medica.Funciones
{
    internal class ActualizarCitas
    {
        // Variable para almacenar mensajes de error o información de estado
        public string Error = string.Empty;

        // Método para actualizar citas médicas
        public void Actualizar(int Idmedico, int idpaciente, DateTime FechaNueva, DateTime FechaAnterior, bool accion)
        {
            // Crear una instancia del adaptador de tabla CitaTableAdapter
            CitaTableAdapter cita = new CitaTableAdapter();

            try
            {
                // Intentar actualizar la cita utilizando el adaptador
                cita.ActualizarCitas(Idmedico, idpaciente, FechaNueva, FechaAnterior, accion);

                // Si la actualización se realiza con éxito, establecer el mensaje de éxito
                Error = "Cita Modificada";
            }
            catch (Exception e)
            {
                // Si ocurre una excepción durante la actualización, capturar el mensaje de error
                Error = e.Message;
            }
        }
    }
}

/*Aquí está una descripción de lo que hace el código:

1. La clase `ActualizarCitas` está en el espacio de nombres `Cita_Medica.Funciones`.

2. La clase tiene una variable pública llamada `Error` que se utiliza para almacenar mensajes de error o información de estado relacionada con la actualización de citas.

3. El método `Actualizar` toma varios parámetros:
   - `Idmedico`: El ID del médico asociado a la cita.
   - `idpaciente`: El ID del paciente asociado a la cita.
   - `FechaNueva`: La nueva fecha de la cita.
   - `FechaAnterior`: La fecha anterior de la cita que se está modificando.
   - `accion`: Un booleano que parece indicar si se está realizando alguna acción específica.

4. Dentro del método `Actualizar`, se crea una instancia del adaptador de tabla `CitaTableAdapter` para interactuar con la tabla de citas.

5. Luego, el código intenta llamar al método `ActualizarCitas` del adaptador de tabla `CitaTableAdapter` con los parámetros proporcionados para realizar la actualización de la cita.

6. Si la actualización se realiza con éxito, se establece la variable `Error` en "Cita Modificada".

7. Si ocurre alguna excepción durante la actualización, se captura la excepción y se almacena su mensaje en la variable `Error`.

Este código parece estar diseñado para manejar la actualización de citas médicas en una base de datos. La variable `Error` se utiliza para proporcionar información sobre el estado de la actualización. 
Si no se produce ninguna excepción, se establecerá en "Cita Modificada", de lo contrario, contendrá el mensaje de error correspondiente.*/