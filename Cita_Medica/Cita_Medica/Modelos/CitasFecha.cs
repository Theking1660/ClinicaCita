using Cita_Medica.ClinicaSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using Cita_Medica.Funciones;

namespace Cita_Medica.Modelos
{
    internal class CitasFecha
    {
        // Método interno para actualizar la lista de fechas de citas
        internal List<string> Actualizar()
        {
            // Crear una instancia del adaptador de tabla CitasTableAdapter para interactuar con la tabla de citas
            CitasTableAdapter citas = new CitasTableAdapter();

            // Obtener una lista de fechas de citas en formato de cadena corta (short date string)
            List<string> lista = citas.GetData().Select(c => c.Fecha.ToShortDateString()).ToList();

            // Devolver la lista de fechas
            return lista;
        }
    }
}

/*A continuación, se describe lo que hace el código:

La clase CitasFecha está en el espacio de nombres Cita_Medica.Modelos.

La clase tiene un método interno llamado Actualizar.

Dentro del método Actualizar, se crea una instancia del adaptador de tabla CitasTableAdapter para interactuar con la tabla de citas en la base de datos.

Luego, se utiliza LINQ para obtener una lista de fechas de citas en formato de cadena corta (ToShortDateString()) a partir de los datos de citas almacenados en la base de datos.

La lista resultante se almacena en la variable lista.

Finalmente, el método devuelve la lista de fechas.

En resumen, este código proporciona una funcionalidad para obtener y actualizar la lista de fechas de citas médicas a partir de la base de datos.*/