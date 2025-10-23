using Practica1.Abstracciones.AccesoDatos.Reservas.ObtenerHabitaciones;
using Practica1.Abstracciones.ModelosUI.Reservas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.AccesoDat.AccesoDatos.Reservas.ObtenerReserva
{
    public  class ObtenerReservasAD : IObternerReservasAD
    {

        private ObjetoContexto objetoContexto;

        public ObtenerReservasAD() { 
            objetoContexto = new ObjetoContexto();
        }
        public List<ReservacionesDTO> ObtenerTodas()
        {
           List<ReservacionesDTO> listaReservas = (from reserva in objetoContexto.RESERVACIONES
                                                   select new ReservacionesDTO
                                                   {
                                                       Id=reserva.Id,
                                                       NombreDeLaPersona = reserva.NombreDeLaPersona,
                                                       Correo = reserva.Correo,
                                                       Direccion = reserva.Direccion,
                                                       FechaDeRegistro = reserva.FechaDeRegistro,  
                                                       FechaFinReserva=reserva.FechaFinReserva,
                                                       IdHabitacion = reserva.IdHabitacion,
                                                       Telefono=reserva.Telefono,
                                                       FechaInicioReserva=reserva.FechaInicioReserva,
                                                       FechaNacimiento=reserva.FechaNacimiento,
                                                        Identificacion=reserva.Identificacion,
                                                        MontoTotal = reserva.MontoTotal
                                                   }).ToList();
            return listaReservas;
        }

        public List<ReservacionesDTO> ObtenerUnaHabitacion(int IdHabitacion)
        {
            List<ReservacionesDTO> listaReservas = (from reserva in objetoContexto.RESERVACIONES
                                                    where reserva.IdHabitacion == IdHabitacion
                                                    select new ReservacionesDTO
                                                    {
                                                        Id = reserva.Id,
                                                        NombreDeLaPersona = reserva.NombreDeLaPersona,
                                                        Correo = reserva.Correo,
                                                        Direccion = reserva.Direccion,
                                                        FechaDeRegistro = reserva.FechaDeRegistro,
                                                        FechaFinReserva = reserva.FechaFinReserva,
                                                        IdHabitacion = reserva.IdHabitacion,
                                                        Telefono = reserva.Telefono,
                                                        FechaInicioReserva = reserva.FechaInicioReserva,
                                                        FechaNacimiento = reserva.FechaNacimiento,
                                                        Identificacion = reserva.Identificacion,
                                                        MontoTotal = reserva.MontoTotal
                                                    }).ToList();
            return listaReservas;
        }

       
    }
}
