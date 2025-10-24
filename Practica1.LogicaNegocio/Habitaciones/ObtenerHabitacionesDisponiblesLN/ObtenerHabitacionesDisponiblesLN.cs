using Practica1.Abstracciones.AccesoDatos.Habitaciones.ListaHabitaciones;
using Practica1.Abstracciones.LogicaNegocio.Reservas.ObtenerReservasDisponibles;
using Practica1.Abstracciones.ModelosUI.Habitaciones;
using Practica1.Abstracciones.ModelosUI.Reservas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.LogicaNegocio.Habitaciones.ObtenerHabitacionesDisponiblesLN
{
    public class ObtenerHabitacionesDisponiblesLN : IObtenerHabitacionesDisponiblesLN
    {
     
        private IObtenerListaHabitacionesAD _obtenerListaAD;

        public ObtenerHabitacionesDisponiblesLN(IObtenerListaHabitacionesAD obtenerListaAD)
        {
            _obtenerListaAD = obtenerListaAD;
        }

        public List<HabitacionDTO> Obtener()
        {
            List<HabitacionDTO> habitaciones = _obtenerListaAD.obtener();
                          List<HabitacionDTO> disponibles = habitaciones.Where(h => h.Estado == true).ToList();
                      

            return disponibles;
        }


    }
}

