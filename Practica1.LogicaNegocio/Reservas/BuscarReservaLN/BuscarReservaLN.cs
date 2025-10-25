using Practica1.Abstracciones.AccesoDatos.Reservas.BuscarReserva;
using Practica1.Abstracciones.LogicaNegocio.Reservas.BuscarReserva;
using Practica1.Abstracciones.ModelosUI.ReservaDetalles;
using Practica1.AccesoDat.AccesoDatos.Reservas.BuscarReserva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.LogicaNegocio.Reservas.BuscarReservaLN
{
    public class BuscarReservaLN : IBuscarReservaLN
    {
        private IBuscarReservaAD _buscarReservaAD;

        public BuscarReservaLN()
        {
        }

        public BuscarReservaLN(IBuscarReservaAD buscarReservaAD)
        {
            _buscarReservaAD = buscarReservaAD;
        }

        public ReservaDetalleDTO BuscarPorIdHabitacion(int IdHabitacion)
        {

            if (IdHabitacion <= 0) 
            {
                return null;
            }

            ReservaDetalleDTO reservaDetalle = _buscarReservaAD.BuscarPorIdReserva(IdHabitacion);
            if (reservaDetalle != null)
            {
                if (reservaDetalle.TipoDeHabitacion == 1)
                {
                    reservaDetalle.TipoDeHabitacionTexto = "Junior";
                }
                else if (reservaDetalle.TipoDeHabitacion == 2)
                {
                    reservaDetalle.TipoDeHabitacionTexto = "Superior";
                }
                else if (reservaDetalle.TipoDeHabitacion == 3)
                {
                    reservaDetalle.TipoDeHabitacionTexto = "Suite";
                }

            }

            return reservaDetalle; //Le pasamos la reserva en caso que haya dentro de una lista , ya que la interfaz pide una lista 
        }

      
    }

}
