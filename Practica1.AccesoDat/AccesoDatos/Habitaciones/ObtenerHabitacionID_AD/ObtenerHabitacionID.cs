using Practica1.Abstracciones.AccesoDatos.Habitaciones.ObtenerHabitacionID;
using Practica1.Abstracciones.ModelosUI.Habitaciones;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.AccesoDat.AccesoDatos.Habitaciones.ObtenerHabitacionID_AD
{
    public class ObtenerHabitacionPorId : IObtenerHabitacionID
    {
        private ObjetoContexto _contexto;

        public ObtenerHabitacionPorId()
        {
            _contexto = new ObjetoContexto();
        }

        public async Task<HabitacionDTO> Obtener(int id)
        {
            var habitacion = await _contexto.HABITACIONES
                .Where(h => h.ID == id)
                .FirstOrDefaultAsync();


            return new HabitacionDTO
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
            };
        }
    }

}