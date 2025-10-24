using Practica1.Abstracciones.AccesoDatos.Reservas.AgregarReserva;
using Practica1.Abstracciones.ModelosUI.Reservas;
using Practica1.AccesoDat.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.AccesoDat.AccesoDatos.Reservas.AgregarReserva
{
    public class AgregarReservaAD : IAgregarReservaAD
    {
        private ObjetoContexto _ObjetoContexto;

        public AgregarReservaAD()
        {
            _ObjetoContexto = new ObjetoContexto();
        }

 

        public async Task<int> Agregar(ReservacionesDTO reserva)
        {
            // Pasamos el objeto DTO a entidad lo que hacemos en el metodo ConvertirObjEntidad
            ReservasAccesoDatos reservaEnEntidad = ConvertirObjEntidad(reserva);
            int idReservaGenerada = 0;

            _ObjetoContexto.RESERVACIONES.Add(reservaEnEntidad);
            await _ObjetoContexto.SaveChangesAsync(); // Le decimos que lo espere ya que es Async

            idReservaGenerada = reservaEnEntidad.Id; // Obtenemos el ID generado

            return idReservaGenerada;
        }

        // Metodo auxiliar
        private ReservasAccesoDatos ConvertirObjEntidad(ReservacionesDTO reserva)
        {
            return new ReservasAccesoDatos
            {
                Id = reserva.Id,
                NombreDeLaPersona = reserva.NombreDeLaPersona,
                Identificacion = reserva.Identificacion,
                Telefono = reserva.Telefono,
                Correo = reserva.Correo,
                FechaNacimiento = reserva.FechaNacimiento,
                Direccion = reserva.Direccion,
                MontoTotal = reserva.MontoTotal,
                FechaInicioReserva = reserva.FechaInicioReserva,
                FechaFinReserva = reserva.FechaFinReserva,
                FechaDeRegistro = reserva.FechaDeRegistro,
                IdHabitacion = reserva.IdHabitacion
            };
        }
    }
}