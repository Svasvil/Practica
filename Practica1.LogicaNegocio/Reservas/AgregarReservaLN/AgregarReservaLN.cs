using Practica1.Abstracciones.AccesoDatos.Habitaciones.ListaHabitaciones;
using Practica1.Abstracciones.AccesoDatos.Reservas.AgregarReserva;
using Practica1.Abstracciones.LogicaNegocio.Reservas.AgregarReservas;
using Practica1.Abstracciones.ModelosUI.Habitaciones;
using Practica1.Abstracciones.ModelosUI.Reservas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.LogicaNegocio.Reservas.AgregarReservaLN
{
    public class AgregarReservaLN : IAgregarReservaLN
    {
        private readonly IAgregarReservaAD _agregarReservaAD;
        private readonly IObtenerListaHabitacionesAD _obtenerListaHabitacionesAD;

        public AgregarReservaLN(IAgregarReservaAD agregarReservaAD, IObtenerListaHabitacionesAD obtenerListaHabitacionesAD)
        {
            _agregarReservaAD = agregarReservaAD;
            _obtenerListaHabitacionesAD = obtenerListaHabitacionesAD;
        }

        public async Task<int> Ejecutar(ReservacionesDTO reserva)
        {
            List<HabitacionDTO> habitaciones = _obtenerListaHabitacionesAD.obtener();
            HabitacionDTO habitacion = habitaciones.FirstOrDefault(h => h.ID == reserva.IdHabitacion && h.Estado);

            if (habitacion == null)
            {
                throw new Exception("La habitación seleccionada no existe o no está disponible.");
            }

            int cantidadDiasReserva = (reserva.FechaFinReserva.Date - reserva.FechaInicioReserva.Date).Days;
            reserva.MontoTotal = (cantidadDiasReserva * habitacion.CostoReserva) + habitacion.CostoLimpieza;
            reserva.FechaDeRegistro = DateTime.Now;

            return await _agregarReservaAD.Agregar(reserva);
        }
    }
}
