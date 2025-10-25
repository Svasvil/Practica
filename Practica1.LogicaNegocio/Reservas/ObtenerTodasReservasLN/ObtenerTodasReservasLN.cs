using Practica1.Abstracciones.LogicaNegocio.Reservas.ObternerTodasReservasLN;
using Practica1.Abstracciones.ModelosUI.ReservaDetalles;
using Practica1.Abstracciones.AccesoDatos.Reservas.ObtenerTodasReservasAd;
using System.Collections.Generic;

namespace Practica1.LogicaNegocio.Reservas.ObtenerTodasReservasLN
{
    public class ObtenerTodasReservasLN : IObtenerTodasReservasLN
    {
        private readonly IObtenerTodasReservasAd _ObtenerTodasReservasAd;

        public ObtenerTodasReservasLN(IObtenerTodasReservasAd obtenerTodasReservasAd)
        {
            _ObtenerTodasReservasAd = obtenerTodasReservasAd;
        }

        public List<ReservaDetalleDTO> ObtenerTodas()
        {
            return _ObtenerTodasReservasAd.ObtenerTodas();
        }

        public List<ReservaDetalleDTO> ObtenerPorIdHabitacion(int idHabitacion)
        {
            return _ObtenerTodasReservasAd.ObtenerTodas(idHabitacion);
        }
    }
}