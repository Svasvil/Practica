using Practica1.AccesoDat.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.AccesoDat.AccesoDatos.Habitaciones.EliminarHabitacionAD
{
    public  class EliminarHabitacion
    {
        private ObjetoContexto _ObjetoContexto;

        public EliminarHabitacion() { 
            _ObjetoContexto = new ObjetoContexto();
        }
        public int Eliminar(int IDHabitacionEliminar) {
            int cantidadRegistrosAfectados = 0;
            HabitacionesAccesoDatos habitacionEliminar = _ObjetoContexto.HABITACIONES //bUSCAMOS LA HABITACION A ELIMINAR 
                .Where(HabitacionBuscar => HabitacionBuscar.ID == IDHabitacionEliminar)
                .FirstOrDefault();

            if (habitacionEliminar != null) //Verificamos si la habitacion existe
            { 
                _ObjetoContexto.HABITACIONES.Remove(habitacionEliminar);
                cantidadRegistrosAfectados = _ObjetoContexto.SaveChanges();
            }
            return cantidadRegistrosAfectados;
        }
    }
}
