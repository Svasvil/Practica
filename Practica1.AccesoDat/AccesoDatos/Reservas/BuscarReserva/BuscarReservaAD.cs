using Practica1.Abstracciones.AccesoDatos.Reservas.BuscarReserva;
using Practica1.Abstracciones.ModelosUI.ReservaDetalles;
using Practica1.Abstracciones.ModelosUI.Reservas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.AccesoDat.AccesoDatos.Reservas.BuscarReserva
{
    public class BuscarReservaAD : IBuscarReservaAD
    {
        private ObjetoContexto objContexto;

        public BuscarReservaAD()
        {
            objContexto = new ObjetoContexto();
        }

        public ReservaDetalleDTO BuscarPorIdReserva(int IdReserva)
        {
            ReservaDetalleDTO reservaDetalle = (from r in objContexto.RESERVACIONES
                                                join h in objContexto.HABITACIONES on r.IdHabitacion equals h.ID
                                                where r.IdHabitacion == IdReserva
                                                select new ReservaDetalleDTO
                                                {
                                                    Id = r.Id,
                                                    NombreDeLaPersona = r.NombreDeLaPersona,
                                                    Identificacion = r.Identificacion,
                                                    Telefono = r.Telefono,
                                                    Correo = r.Correo,
                                                    FechaNacimiento = r.FechaNacimiento,
                                                    Direccion = r.Direccion,
                                                    MontoTotal = r.MontoTotal,
                                                    FechaInicioReserva = r.FechaInicioReserva,
                                                    FechaFinReserva = r.FechaFinReserva,
                                                    FechaDeRegistro = r.FechaDeRegistro,
                                                    IdHabitacion = r.IdHabitacion,
                                                    CodigoDeHabitacion = h.Codigo,
                                                    NombreDeHabitacion = h.Nombre,
                                                    CantidadDeHuespedesPermitidos = h.CantidadHuespedesAdmitidos,
                                                    Ubicacion = h.Ubicacion,
                                                    TipoDeHabitacion = h.TipoHabitacion,
                                                    CostoDeReserva = h.CostoReserva
                                                }).FirstOrDefault();

            return reservaDetalle;
        }
        

  
      
    }
}