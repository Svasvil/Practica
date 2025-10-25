using Practica1.Abstracciones.AccesoDatos.Habitaciones.ObtenerHabitacionID;
using Practica1.Abstracciones.ModelosUI.Habitaciones;
using Practica1.AccesoDat.AccesoDatos.Habitaciones.ObtenerHabitacionID_AD;
using System.Threading.Tasks;

namespace Practica1.LogicaNegocio.Habitaciones.ObtenerHabitacionID
{
    public class ObtenerHabitacionLN : IObtenerHabitacionID
    {
        private readonly IObtenerHabitacionID _obtenerHabitacionID;

        public ObtenerHabitacionLN()
        {
            _obtenerHabitacionID = new ObtenerHabitacionAD(); 
        }

        public async Task<HabitacionDTO> Obtener(int id)
        {
            return await _obtenerHabitacionID.Obtener(id);
        }
    }
}
