using Practica1.Abstracciones.ModelosUI.Habitaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.AccesoDat.AccesoDatos.Habitaciones.ObtenerHabitacionID_AD
{
    public class ObtenerHabitacionID
    {

        private ObjetoContexto _ObjetoContexto;

        public ObtenerHabitacionID()
        {
            _ObjetoContexto = new ObjetoContexto(); //Declaramos un nuevo objeto contexto para poder acceder a la base de datos.
        }
        public HabitacionDTO obtener(int HabitacionID)
        {

            HabitacionDTO HabitacionesAccesoDatos = (from habitacion in _ObjetoContexto.InfoHabitaciones
                                                     where habitacion.ID == HabitacionID //Filtro para obtener la habitacion por ID que querramos 
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
                                                         Estado = habitacion.Estado,
                                                         FechaRegistro = habitacion.FechaRegistro,
                                                         FechaModificacion = habitacion.FechaModificacion
                                                     }).FirstOrDefault();

            return HabitacionesAccesoDatos;
        }

    }
}
