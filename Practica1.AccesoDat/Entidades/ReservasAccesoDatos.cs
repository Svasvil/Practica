using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica1.AccesoDat.Entidades
{
    [Table("RESERVACIONES")]
    public class ReservasAccesoDatos
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("NombreDeLaPersona")]
        [Required]
     
        public string NombreDeLaPersona { get; set; }

        [Column("Identificacion")]
        [Required]
       
        public string Identificacion { get; set; }

        [Column("Telefono")]
        [Required]
       
        public string Telefono { get; set; }

        [Column("Correo")]
        [Required]
      
        public string Correo { get; set; }

        [Column("FechaNacimiento")]
        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Column("Direccion")]
        [Required]
       
        public string Direccion { get; set; }

        [Column("MontoTotal")]
        [Required]
        public decimal MontoTotal { get; set; }

        [Column("FechaInicioReserva")]
        [Required]
        public DateTime FechaInicioReserva { get; set; }

        [Column("FechaFinReserva")]
        [Required]
        public DateTime FechaFinReserva { get; set; }

        [Column("FechaDeRegistro")]
        [Required]
        public DateTime FechaDeRegistro { get; set; }

        [Column("IdHabitacion")]
        [Required]
        public int IdHabitacion { get; set; }
    }
}
