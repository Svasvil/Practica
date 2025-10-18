using Practica1.Abstracciones.AccesoDatos.Habitaciones.AgregarHabitacion;
using Practica1.Abstracciones.LogicaNegocio.General.GestionFechas;
using Practica1.Abstracciones.LogicaNegocio.Habitaciones.AgregarHabitaciones;
using Practica1.Abstracciones.ModelosUI.Habitaciones;
using Practica1.AccesoDat.AccesoDatos.Habitaciones.AgregarHabitacionAD;
using Practica1.AccesoDat.Entidades;
using Practica1.LogicaNegocio.General.GestionFechas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.LogicaNegocio.Habitaciones.AgregarHabitacionesLN
{
    public class AgregarHabitacionesLN : IAgregarHabitacionesLN
    {
        private IAgregarHabitacion _AgregarHabitacionAD;
        private IFecha  _fecha;


        public AgregarHabitacionesLN()
        {
            _AgregarHabitacionAD = new AgregarHabitacion(); //Este nombre es el mismo que el de la linea 14 
            _fecha = new Fecha(); 
        }

        public async Task<int> Agregar(HabitacionDTO HabitacionNueva)
        {
            HabitacionNueva.FechaRegistro= _fecha.ObtenerFechaActual();
            HabitacionNueva.FechaModificacion= null; //Al agregar una habitacion nueva la fecha de modificacion es nula
            int cantidadHabitacionAgregada = await _AgregarHabitacionAD.Agregar(HabitacionNueva);
            return cantidadHabitacionAgregada;
        }
    }
}
