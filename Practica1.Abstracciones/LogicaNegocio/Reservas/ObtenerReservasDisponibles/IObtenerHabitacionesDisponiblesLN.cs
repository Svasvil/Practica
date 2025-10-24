using Practica1.Abstracciones.ModelosUI.Habitaciones;
using Practica1.Abstracciones.ModelosUI.Reservas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Abstracciones.LogicaNegocio.Reservas.ObtenerReservasDisponibles
{
    public  interface IObtenerHabitacionesDisponiblesLN
    {
        List<HabitacionDTO> Obtener();
    }
}
