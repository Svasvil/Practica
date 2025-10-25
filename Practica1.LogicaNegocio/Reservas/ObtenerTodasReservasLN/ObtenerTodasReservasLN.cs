using Practica1.Abstracciones.AccesoDatos.Reservas.ObtenerTodasReservasAd;
using Practica1.Abstracciones.LogicaNegocio.Reservas.ObternerTodasReservasLN;
using Practica1.Abstracciones.ModelosUI.ReservaDetalles;
using Practica1.AccesoDat.AccesoDatos.Reservas.ObtenerTodasReservas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.LogicaNegocio.Reservas.ObtenerTodasReservasLN
{
    public  class ObtenerTodasReservasLN : IObtenerTodasReservasLN
    {
        private readonly IObtenerTodasReservasAd _ObtenerTodasReservasAd;

        public ObtenerTodasReservasLN()
        {
            _ObtenerTodasReservasAd = new ObtenerTodasReservasAD();
        }
        public List<ReservaDetalleDTO> ObtenerTodas()
        {
return _ObtenerTodasReservasAd.ObtenerTodas();        }

        public List<ReservaDetalleDTO> ObtenerPorIdHabitacion(int idHabitacion)
        {
            return _ObtenerTodasReservasAd.ObtenerTodas(idHabitacion);
        }


    }

}
