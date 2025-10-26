using Practica1.Abstracciones.AccesoDatos.Habitaciones.ObtenerHabitacionID;
using Practica1.Abstracciones.ModelosUI.Habitaciones;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.AccesoDat.AccesoDatos.Habitaciones.ObtenerHabitacionID_AD
{
    public class ObtenerHabitacionAD : IObtenerHabitacionID
    {
        private ObjetoContexto objetoContexto;

        public ObtenerHabitacionAD()
        {
            objetoContexto = new ObjetoContexto();
        }

        public Task<HabitacionDTO> Obtener(int id)
        {
            HabitacionDTO habitacion = (from h in objetoContexto.HABITACIONES
                                        where h.ID == id
                                        select new HabitacionDTO
                                        {
                                            ID = h.ID,
                                            Codigo = h.Codigo,
                                            Nombre = h.Nombre,
                                            Ubicacion = h.Ubicacion,
                                            CantidadHuespedesAdmitidos = h.CantidadHuespedesAdmitidos,
                                            CantidadCamas = h.CantidadCamas,
                                            CantidadBanos = h.CantidadBanos,
                                            ResponsableLimpieza = h.ResponsableLimpieza,
                                            CostoLimpieza = h.CostoLimpieza,
                                            CostoReserva = h.CostoReserva,
                                            TipoHabitacion = h.TipoHabitacion,
                                            Estado = h.Estado,
                                            FechaRegistro = h.FechaRegistro,
                                            FechaModificacion = h.FechaModificacion
                                        }).FirstOrDefault();

            return Task.FromResult(habitacion);
        }
    }
}