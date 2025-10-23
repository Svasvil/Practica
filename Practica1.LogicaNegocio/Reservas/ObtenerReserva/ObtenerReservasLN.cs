using Practica1.Abstracciones.AccesoDatos.Reservas.ObtenerHabitaciones;
using Practica1.Abstracciones.LogicaNegocio.Reservas.ObtenerReservas;
using Practica1.Abstracciones.ModelosUI.Reservas;
using Practica1.AccesoDat.AccesoDatos.Reservas.ObtenerReserva;
using System.Collections.Generic;

namespace Practica1.LogicaNegocio.Reservas.ObtenerReserva
{
    public class ObtenerReservasLN : IObtenerReservaLN
    {
        private readonly IObternerReservasAD _ObtenerReservaAD;
        public ObtenerReservasLN()
        {
            _ObtenerReservaAD = new ObtenerReservasAD();
        }
        public List<ReservacionesDTO> ObtenerTodas()
        {
            return _ObtenerReservaAD.ObtenerTodas();
        }
        public List<ReservacionesDTO> ObtenerPorHabitacion(int IdHabitacion)
        {
            return _ObtenerReservaAD.ObtenerUnaHabitacion(IdHabitacion);
        }
    }
}
