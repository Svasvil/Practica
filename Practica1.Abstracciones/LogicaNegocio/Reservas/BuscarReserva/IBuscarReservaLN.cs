using Practica1.Abstracciones.ModelosUI.ReservaDetalles;
using Practica1.Abstracciones.ModelosUI.Reservas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Abstracciones.LogicaNegocio.Reservas.BuscarReserva
{
    public  interface IBuscarReservaLN
    {
        List<ReservaDetalleDTO> BuscarPorIdHabitacion(int IdHabitacion);
    }
}
