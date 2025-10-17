using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Abstracciones.ModelosUI.Habitaciones
{
    public  class HabitacionDTO
    {
        //Estas son los atributos que tiene una habitacion , en este caso se usara para el CRUD.
        [Display(Name ="Codigo Habitacion")]
        public int Codigo { get; set; }
        [Display(Name = "Nombre Habitacion ")]
        public string Nombre { get; set; }
        [Display(Name ="Ubicacion de la habitacion ")]
        
        public string Ubicacion { get; set; }

        [Display(Name = "Cantidad de Personas maxima ")]
        public  int  CantidadHuespedesAdmitidos { get; set; }
        [Display(Name = "Cantidad de Camas ")]
        public  int CantidadCamas { get; set; }
        [Display(Name = "Cantidad de Banos")]
        public int  CantidadBanos { get; set; }
        [Display(Name = "Persona encargada de limpieza")]
        public  string ResponsableLimpieza { get; set; }

        [Display(Name = "Costo por la limpieza")]
        public int CostoLimpieza { get; set; }
        [Display(Name = "Costo por la reserva")]
        public int CostoReserva  { get; set; }
        [Display(Name = "Codigo Repuesto")]
        public int  TipoHabitacion { get; set; }
        [Display(Name = "Codigo Repuesto")]
        public int  Estado { get; set; }

        //Fechas 
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaModificacion { get; set; }

    }
}
