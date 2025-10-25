using Practica1.Abstracciones.AccesoDatos.Reservas.ObtenerTodasReservasAd;
using Practica1.Abstracciones.ModelosUI.ReservaDetalles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.AccesoDat.AccesoDatos.Reservas
{
    public  class ObtenerTodasReservasAD : IObtenerTodasReservasAd
    {
        private readonly ObjetoContexto _ObjetoContexto;
        public ObtenerTodasReservasAD()
        {
            _ObjetoContexto = new ObjetoContexto();
        }



        //obtenemos una con el join para sacar el ID de la habitacion
        public List<ReservaDetalleDTO> ObtenerTodas(int idHabitacion)
        {
            List<ReservaDetalleDTO> listaReservas = (from reserva in _ObjetoContexto.RESERVACIONES
                                                     join habitacion in _ObjetoContexto.HABITACIONES
                                                         on reserva.IdHabitacion equals habitacion.ID

                                                     where reserva.IdHabitacion == idHabitacion

                                                     select new ReservaDetalleDTO
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
                                                         IdHabitacion = reserva.IdHabitacion,
                                                             CodigoDeHabitacion = habitacion.Codigo, 
                                                         NombreDeHabitacion = habitacion.Nombre, 
                                                         CantidadDeHuespedesPermitidos = habitacion.CantidadHuespedesAdmitidos,
                                                         Ubicacion = habitacion.Ubicacion,
                                                         TipoDeHabitacion = habitacion.TipoHabitacion,
                                                         CostoDeReserva = habitacion.CostoReserva,
                                                     }).ToList();

            return listaReservas;
        }
        //obtenemos todas 
        public List<ReservaDetalleDTO> ObtenerTodas()
        {
            List<ReservaDetalleDTO> listaReservas = (from reserva in _ObjetoContexto.RESERVACIONES
                                                     join habitacion in _ObjetoContexto.HABITACIONES
                                                         on reserva.IdHabitacion equals habitacion.ID
                                                     select new ReservaDetalleDTO
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
                                                         IdHabitacion = reserva.IdHabitacion,
                                                         CodigoDeHabitacion = habitacion.Codigo,
                                                         NombreDeHabitacion = habitacion.Nombre,
                                                         CantidadDeHuespedesPermitidos = habitacion.CantidadHuespedesAdmitidos,
                                                         Ubicacion = habitacion.Ubicacion,
                                                         TipoDeHabitacion = habitacion.TipoHabitacion,
                                                         CostoDeReserva = habitacion.CostoReserva,
                                                         TipoDeHabitacionTexto = null
                                                     }).ToList();

            return listaReservas;
        }
    }

}



