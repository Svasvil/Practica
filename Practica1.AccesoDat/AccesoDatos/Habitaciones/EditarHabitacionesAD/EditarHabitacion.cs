using Practica1.Abstracciones.AccesoDatos.Habitaciones.AgregarHabitacion;
using Practica1.Abstracciones.AccesoDatos.Habitaciones.EditarHabitacion;
using Practica1.Abstracciones.ModelosUI.Habitaciones;
using Practica1.AccesoDat.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.AccesoDat.AccesoDatos.Habitaciones.EditarHabitacionesAD
{
    public class EditarHabitacion : IEditarHabitacion
    {

        private ObjetoContexto _ObjetoContexto;
        public EditarHabitacion( )
        {
            _ObjetoContexto = new ObjetoContexto(); //Declaramos un nuevo objeto contexto para poder acceder a la base de datos.
        }
        //Creamos el metodo para editar una habitacion y que recibe como parametro un objeto de tipo HabitacionDTO , ademas lo que hacemos es un where de la habitacion que queremos editar meditante el ID
        // y lo guardamos en una variable de tipo HabitacionesAccesoDatos, 
        public async Task<int> Editar(HabitacionDTO HabitacionGuardar) { 
            int cantidadRegistrosAfectados = 0; 

            HabitacionesAccesoDatos habitacionEditar = _ObjetoContexto.InfoHabitaciones
                .Where(HabitacionBuscar => HabitacionBuscar.ID == HabitacionGuardar.ID)
                .FirstOrDefault();
            //Esto lo que hace es verificar si la habitacion que queremos editar existe , si es asi , se procede a editar cada uno de los campos de la habitacion con los valores del objeto HabitacionGuardar
            if (habitacionEditar != null) {
                habitacionEditar.TipoHabitacion = HabitacionGuardar.TipoHabitacion;
                habitacionEditar.CantidadCamas = HabitacionGuardar.CantidadCamas;
                habitacionEditar.CantidadBanos = HabitacionGuardar.CantidadBanos;
                habitacionEditar.CantidadHuespedesAdmitidos = HabitacionGuardar.CantidadHuespedesAdmitidos;
                habitacionEditar.Codigo = HabitacionGuardar.Codigo;
                habitacionEditar.CostoLimpieza = (int)HabitacionGuardar.CostoLimpieza;
                habitacionEditar.CostoReserva = (int)HabitacionGuardar.CostoReserva;
                habitacionEditar.Estado = HabitacionGuardar.Estado;
                habitacionEditar.Nombre = HabitacionGuardar.Nombre;
                habitacionEditar.ResponsableLimpieza = HabitacionGuardar.ResponsableLimpieza;
                habitacionEditar.Ubicacion = HabitacionGuardar.Ubicacion;
                habitacionEditar.FechaModificacion = DateTime.Now;
                cantidadRegistrosAfectados = _ObjetoContexto.SaveChanges();

         
            }
        return cantidadRegistrosAfectados; //Retornamos la cantidad de registros afectados por la operacion de edicion. 
        }
        
    }
}
