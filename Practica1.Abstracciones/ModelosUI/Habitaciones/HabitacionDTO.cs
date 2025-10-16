using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Abstracciones.ModelosUI.Habitaciones
{
    public  class HabitacionDTO
    {
        //Estas son los atributos que tiene una habitacion , en este caso se usara para el CRUD.
        public int Codigo { get; set; }
        public string Nombre { get; set; }

        public string Ubicacion { get; set; }
        public  int  CantidadHuespedesAdmitidos { get; set; }

        public  int CantidadCamas { get; set; }
        public int  CantidadBanos { get; set; }
        public  string ResponsableLimpieza { get; set; }
        public int CostoLimpieza { get; set; }
        public int CostoReserva  { get; set; }
        public int  TipoHabitacion { get; set; }
        public int  Estado { get; set; }

        //Fechas 
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaModificacion { get; set; }

    }
}
