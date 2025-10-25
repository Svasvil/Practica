using Practica1.Abstracciones.AccesoDatos.Reservas.AgregarReserva;
using Practica1.Abstracciones.ModelosUI.Reservas;
using Practica1.AccesoDat.Entidades;
using System;
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
            
           
                      
            ReservasAccesoDatos reservaEntidad = ConvertirObjEntidad(reserva);
            _ObjetoContexto.RESERVACIONES.Add(reservaEntidad);
            await _ObjetoContexto.SaveChangesAsync();

            return reservaEntidad.Id;
        }

        // aux
        private ReservasAccesoDatos ConvertirObjEntidad(ReservacionesDTO reserva)
        {
            return new ReservasAccesoDatos
            {
                
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