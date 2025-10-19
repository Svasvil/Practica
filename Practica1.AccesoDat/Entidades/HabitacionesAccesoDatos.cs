using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.AccesoDat.Entidades
{
    [Table("InfoHabitaciones")]
    public class HabitacionesAccesoDatos
    {
        [Column("ID")]
        public int ID { get; set; }
        [Column("CODIGO")]
        public int Codigo { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }
        [Column("UBICACION")]
        public string Ubicacion { get; set; }
        [Column("CANTIDAD_HUESPEDES_PERMITIDOS")]
        public int CantidadHuespedesAdmitidos { get; set; }
        [Column("CANTIDAD_DE_CAMAS")]
        public int CantidadCamas { get; set; }
        [Column("CANTIDAD_DE_BANIOS")]
        public int CantidadBanos { get; set; }
        [Column("RESPONSABLE_DE_LIMPIEZA")]
        public string ResponsableLimpieza { get; set; }
        [Column("COSTO_DE_LIMPIEZA")]
        public int CostoLimpieza { get; set; } 
        [Column("COSTO_DE_RESERVA")]
        public int CostoReserva { get; set; }   
        [Column("TIPO_DE_HABITACION")]
        public int TipoHabitacion { get; set; }
        [Column("ESTADO")]
        public int Estado { get; set; }
        [Column("FECHA_DE_REGISTRO")]
        public DateTime FechaRegistro { get; set; }
        [Column("FECHA_DE_MODIFICACION")]
        public DateTime? FechaModificacion { get; set; }
    }
}
