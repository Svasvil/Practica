using Practica1.Abstracciones.ModelosUI.Reservas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Abstracciones.AccesoDatos.Reservas.ObtenerHabitaciones
{
    public interface IObternerReservasAD {

        List<ReservacionesDTO> ObtenerTodas();


        List<ReservacionesDTO> ObtenerUnaHabitacion(int IdHabitacion);

    }


    
    
}
