using Practica1.Abstracciones.ModelosUI.ReservaDetalles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Abstracciones.LogicaNegocio.Reservas.ObternerTodasReservasLN
{
    public  interface IObtenerTodasReservasLN
    {
        List<ReservaDetalleDTO> ObtenerTodas();
        List<ReservaDetalleDTO> ObtenerPorIdHabitacion(int idHabitacion);
    }
}
