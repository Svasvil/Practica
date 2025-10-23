using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.AccesoDat.Entidades
{
    [Table("HABITACIONES")]
    public class HabitacionesAccesoDatos
    {
        [Column("Id")]
        public int ID { get; set; }
        [Column("CodigoDeHabitacion")]
        public string Codigo { get; set; }
        [Column("NombreDeHabitacion")]
        public string Nombre { get; set; }
        [Column("Ubicacion")]
        public string Ubicacion { get; set; }
        [Column("CantidadDeHuespedesPermitidos")]
        public int CantidadHuespedesAdmitidos { get; set; }
        [Column("CantidadDeCamas")]
        public int CantidadCamas { get; set; }
        [Column("CantidadDeBanos")]
        public int CantidadBanos { get; set; }
        [Column("EncargadoDeLimpieza")]
        public string ResponsableLimpieza { get; set; }
        [Column("CostoDeLimpieza")]
        public decimal CostoLimpieza { get; set; } 
        [Column("CostoDeReserva")]
        public decimal CostoReserva { get; set; }   
        [Column("TipoDeHabitacion")]
        public int TipoHabitacion { get; set; }
        [Column("ESTADO")]
        public bool Estado { get; set; }
        [Column("FechaDeRegistro")]
        public DateTime FechaRegistro { get; set; }
        [Column("FechaDeModificacion")]
        public DateTime? FechaModificacion { get; set; }
    }
}
