using Practica1.Abstracciones.ModelosUI.Habitaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Abstracciones.LogicaNegocio.Habitaciones.EditarHabitaciones
{
    public interface IEditarHabitacionLN
    {
        Task<int> Editar(HabitacionDTO HabitacionEditada);
    }
}
