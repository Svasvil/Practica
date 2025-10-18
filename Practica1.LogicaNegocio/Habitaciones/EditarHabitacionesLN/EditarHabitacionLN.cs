using Practica1.Abstracciones.AccesoDatos.Habitaciones.AgregarHabitacion;
using Practica1.Abstracciones.AccesoDatos.Habitaciones.EditarHabitacion;
using Practica1.Abstracciones.LogicaNegocio.General.GestionFechas;
using Practica1.Abstracciones.LogicaNegocio.Habitaciones.EditarHabitaciones;
using Practica1.Abstracciones.ModelosUI.Habitaciones;
using Practica1.AccesoDat.AccesoDatos.Habitaciones.AgregarHabitacionAD;
using Practica1.AccesoDat.AccesoDatos.Habitaciones.EditarHabitacionesAD;
using Practica1.LogicaNegocio.General.GestionFechas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.LogicaNegocio.Habitaciones.EditarHabitacionesLN
{

    public class EditarHabitacionLN : IEditarHabitacionLN{


        private IEditarHabitacion _EditarHabitacionAD;
        private IFecha _fecha;


        public EditarHabitacionLN()
        {
            _EditarHabitacionAD =new EditarHabitacion();
            _fecha = new Fecha();
        }

        public async Task<int> Editar(HabitacionDTO HabitacionEditada) {

            HabitacionEditada.FechaModificacion = _fecha.ObtenerFechaActual();
            int cantidadHabitacionesEditadas = await _EditarHabitacionAD.Editar(HabitacionEditada);
            return cantidadHabitacionesEditadas;

        }

    }
}
