using Practica1.Abstracciones.ModelosUI.ReservaDetalles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Abstracciones.AccesoDatos.Reservas.ObtenerTodasReservasAd
{
    public interface IObtenerTodasReservasAd
    {

        List<ReservaDetalleDTO> ObtenerTodas();
        List<ReservaDetalleDTO> ObtenerTodas(int idHabitacion);
    }
}
