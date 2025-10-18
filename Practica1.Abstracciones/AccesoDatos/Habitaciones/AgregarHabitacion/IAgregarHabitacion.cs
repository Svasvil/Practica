using Practica1.Abstracciones.ModelosUI.Habitaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Abstracciones.AccesoDatos.Habitaciones.AgregarHabitacion
{
    public interface IAgregarHabitacion
    {
         Task<int> Agregar(HabitacionDTO HabitacionNueva);
    }
}
