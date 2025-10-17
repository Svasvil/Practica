using Practica1.Abstracciones.ModelosUI.Habitaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Abstracciones.LogicaNegocio.Habitaciones.ListaDeHabitaciones
{
    public  interface IObtenerListaHabitacionesLN
    {

        List<HabitacionDTO> Obtener();   //este es el metodo que devuelve la lista de habitaciones , el mismo nombre del metodo de"ObtenerListaHabitacionesLN"
        
        
        
        }

}
