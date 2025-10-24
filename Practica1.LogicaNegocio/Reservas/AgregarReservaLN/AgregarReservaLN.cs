using Practica1.Abstracciones.AccesoDatos.Habitaciones.ListaHabitaciones;
using Practica1.Abstracciones.AccesoDatos.Reservas.AgregarReserva;
using Practica1.Abstracciones.ModelosUI.Habitaciones;
using Practica1.Abstracciones.ModelosUI.Reservas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.LogicaNegocio.Reservas.AgregarReservaLN
{
    public class AgregarReservaLN
    {
        private IAgregarReservaAD _agregarReservaAD;
        private IObtenerListaHabitacionesAD _obtenerListaHabitacionesAD;
    

     public AgregarReservaLN(IAgregarReservaAD agregarReservaAD, IObtenerListaHabitacionesAD obtenerListaHabitacionesAD)
        {
            _agregarReservaAD = agregarReservaAD;
            _obtenerListaHabitacionesAD = obtenerListaHabitacionesAD;
        }

        public async Task<int> Ejecutar(ReservacionesDTO reserva)
        {
                  List<HabitacionDTO> habitaciones = _obtenerListaHabitacionesAD.obtener();
            HabitacionDTO habitacion = habitaciones.FirstOrDefault(h => h.ID == reserva.IdHabitacion); // mandamos a buscar la habitacion por id  para poder ver si esta disponible o nonas 

            // costo dias
            int cantidadDiasReserva = (reserva.FechaFinReserva.Date - reserva.FechaInicioReserva.Date).Days;
            reserva.MontoTotal = (cantidadDiasReserva * habitacion.CostoReserva) + habitacion.CostoLimpieza;

           
            reserva.FechaDeRegistro = DateTime.Now;
            int idReservaGenerada = await _agregarReservaAD.Agregar(reserva);

            return idReservaGenerada;
        }


    }

}
