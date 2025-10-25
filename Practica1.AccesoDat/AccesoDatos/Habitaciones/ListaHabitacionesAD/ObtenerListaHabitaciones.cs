using Practica1.Abstracciones.AccesoDatos.Habitaciones.ListaHabitaciones;
using Practica1.Abstracciones.ModelosUI.Habitaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.AccesoDat.AccesoDatos.Habitaciones.ListaRepuestosAD
{
    public class ObtenerListaHabitaciones : IObtenerListaHabitacionesAD
    {
        private ObjetoContexto objContexto;

        public ObtenerListaHabitaciones()
        {
            objContexto = new ObjetoContexto();
        }

        public List<HabitacionDTO> obtener()
        {
            List<HabitacionDTO> listaHabitaciones = (from habitacion in objContexto.HABITACIONES
                                                     select new HabitacionDTO
                                                     {
                                                         ID = habitacion.ID,
                                                         Codigo = habitacion.Codigo,
                                                         Nombre = habitacion.Nombre,
                                                         Ubicacion = habitacion.Ubicacion,
                                                         CantidadHuespedesAdmitidos = habitacion.CantidadHuespedesAdmitidos,
                                                         CantidadCamas = habitacion.CantidadCamas,
                                                         CantidadBanos = habitacion.CantidadBanos,
                                                         ResponsableLimpieza = habitacion.ResponsableLimpieza,
                                                         CostoLimpieza = habitacion.CostoLimpieza,
                                                         CostoReserva = habitacion.CostoReserva,
                                                         TipoHabitacion = habitacion.TipoHabitacion,
                                                         Estado = habitacion.Estado, // bool directo
                                                         FechaRegistro = habitacion.FechaRegistro,
                                                         FechaModificacion = habitacion.FechaModificacion
                                                     }).ToList();

            return listaHabitaciones;
        }
    }
}
