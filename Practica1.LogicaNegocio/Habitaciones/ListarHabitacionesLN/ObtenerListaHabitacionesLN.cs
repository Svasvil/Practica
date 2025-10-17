using Practica1.Abstracciones.LogicaNegocio.Habitaciones.ListaDeHabitaciones;
using Practica1.Abstracciones.ModelosUI.Habitaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.LogicaNegocio.Habitaciones.ListarHabitacionesLN
{
    public class ObtenerListaHabitacionesLN : IObtenerListaHabitacionesLN //Esta es la interfaz que implementa la logica de negocio para obtener la lista de habitaciones.
    {
        //Aqui va la logica de negocio para obtener la lista de habitaciones 
        public List<HabitacionDTO> Obtener()
        {
            List<HabitacionDTO> listaHabitaciones = new List<HabitacionDTO>();
            listaHabitaciones.Add(new HabitacionDTO
            {
                Codigo = 1,
                Nombre = "Habitacion Sencilla",
                Ubicacion = "Primer Piso",
                CantidadHuespedesAdmitidos = 2,
                CantidadCamas = 1,
                CantidadBanos = 1,
                ResponsableLimpieza = "Juan Perez",
                CostoLimpieza = 50,
                CostoReserva = 100,
                TipoHabitacion = 1,
                Estado = 1,

            });
            return (listaHabitaciones);
        }
    }
}
