using Practica1.Abstracciones.AccesoDatos.Habitaciones.ListaHabitaciones;
using Practica1.Abstracciones.LogicaNegocio.Habitaciones.ListaDeHabitaciones;
using Practica1.Abstracciones.ModelosUI.Habitaciones;
using Practica1.AccesoDat.AccesoDatos.Habitaciones.ListaRepuestosAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.LogicaNegocio.Habitaciones.ListarHabitacionesLN
{
    public class ObtenerListaHabitacionesLN : IObtenerListaHabitacionesLN //Esta es la interfaz que implementa la logica de negocio para obtener la lista de habitaciones.
    {
        private readonly IObtenerListaHabitacionesAD _obtenerListaHabitacionesAD;



        public ObtenerListaHabitacionesLN()
        {
            _obtenerListaHabitacionesAD = new ObtenerListaHabitaciones();
        }
        //Aqui va la logica de negocio para obtener la lista de habitaciones 
        public List<HabitacionDTO> Obtener()
        {
            List<HabitacionDTO> listaHabitaciones = _obtenerListaHabitacionesAD.obtener();


            return (listaHabitaciones);
        }
    }
}
