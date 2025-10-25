using System;
using System.ComponentModel.DataAnnotations;

namespace Practica1.Abstracciones.ModelosUI.Reservas
{
    public class ReservacionesDTO
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Nombre de la Persona")]
        [Required]
        public string NombreDeLaPersona { get; set; }

        [Display(Name = "Identificacion")]
        [Required]
        public string Identificacion { get; set; }

        [Display(Name = "Telefono")]
        [Required]
        public string Telefono { get; set; }

        [Display(Name = "Correo")]
        [Required]
        public string Correo { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Display(Name = "Direccion")]
        [Required]
        public string Direccion { get; set; }

        [Display(Name = "Monto Total")]
        public decimal MontoTotal { get; set; }

        [Display(Name = "Fecha Inicio Reserva")]
        [Required]
        public DateTime FechaInicioReserva { get; set; }

        [Display(Name = "Fecha Fin Reserva")]
        [Required]
        public DateTime FechaFinReserva { get; set; }

        public DateTime FechaDeRegistro { get; set; }

        [Display(Name = "ID Habitacion")]
        [Required]
        public int IdHabitacion { get; set; }
    }
}
