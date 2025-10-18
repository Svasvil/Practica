using Practica1.Abstracciones.AccesoDatos.Habitaciones.AgregarHabitacion;
using Practica1.Abstracciones.ModelosUI.Habitaciones;
using Practica1.AccesoDat.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.AccesoDat.AccesoDatos.Habitaciones.AgregarHabitacionAD
{
    public class AgregarHabitacion : IAgregarHabitacion
    {
        private ObjetoContexto _ObjetoContexto;


        public AgregarHabitacion()
        {
            _ObjetoContexto = new ObjetoContexto();
        }

        public async Task <int> Agregar(HabitacionDTO HabitacionNueva) //Tenemos que hacer el metodo asincrono para q no bloquee la aplicacion
        {
          // aca pasamos el objeto  a entidad lo q hicmos en el metodo ConvertirObjEntidad
            HabitacionesAccesoDatos habitacionEnEntidad = ConvertirObjEntidad(HabitacionNueva);

            int cantidadHabitacionAgregada = 0;
            _ObjetoContexto.InfoHabitaciones.Add(habitacionEnEntidad);//
            cantidadHabitacionAgregada =await _ObjetoContexto.SaveChangesAsync(); //Le decimos que lo espere ya que es Async 
            return cantidadHabitacionAgregada;
        }

        //Metodo auxiliar 
        private HabitacionesAccesoDatos /* <- este es el nombre de la entidad , no poner DTO */ ConvertirObjEntidad(HabitacionDTO HabitacionNueva)
        {
            return new HabitacionesAccesoDatos
            { 
                ID = HabitacionNueva.ID,
                Codigo = HabitacionNueva.Codigo,
                Nombre = HabitacionNueva.Nombre,
                Ubicacion = HabitacionNueva.Ubicacion,
                CantidadHuespedesAdmitidos = HabitacionNueva.CantidadHuespedesAdmitidos,
                CantidadCamas = HabitacionNueva.CantidadCamas,
                CantidadBanos = HabitacionNueva.CantidadBanos,
                ResponsableLimpieza = HabitacionNueva.ResponsableLimpieza,
                CostoLimpieza = (int)HabitacionNueva.CostoLimpieza,
                CostoReserva = (int)HabitacionNueva.CostoReserva,
                TipoHabitacion = HabitacionNueva.TipoHabitacion,
                Estado = HabitacionNueva.Estado,
                FechaRegistro = HabitacionNueva.FechaRegistro,
                FechaModificacion = HabitacionNueva.FechaModificacion
            };
        }
    }
}
