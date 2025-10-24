using System;
using System.ComponentModel.DataAnnotations;

namespace Practica1.Abstracciones.ModelosUI.ReservaDetalles
{
    public class ReservaDetalleDTO
    {
       
        [Display(Name = "ID Reservación")]
        public int Id { get; set; }

        [Display(Name = "Nombre de la Persona")]
        public string NombreDeLaPersona { get; set; }

        [Display(Name = "Identificación")]
        public string Identificacion { get; set; }

        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        [Display(Name = "Correo Electrónico")]
        public string Correo { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
       
        public DateTime FechaNacimiento { get; set; }

        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        [Display(Name = "Monto Total")]
  
        public decimal MontoTotal { get; set; }

        [Display(Name = "Fecha de Inicio de Reserva")]
       
        public DateTime FechaInicioReserva { get; set; }

        [Display(Name = "Fecha de Fin de Reserva")]

        public DateTime FechaFinReserva { get; set; }

        [Display(Name = "Fecha de Reservación")]
   
        public DateTime FechaDeRegistro { get; set; }

        [Display(Name = "ID Habitación")]
        public int IdHabitacion { get; set; }

        [Display(Name = "Código de Habitación")]
        public string CodigoDeHabitacion { get; set; }

        [Display(Name = "Nombre de Habitación")]
        public string NombreDeHabitacion { get; set; }

        [Display(Name = "Cantidad de Huéspedes")]
        public int CantidadDeHuespedesPermitidos { get; set; }

        [Display(Name = "Ubicación")]
        public string Ubicacion { get; set; }

        [Display(Name = "Tipo de Habitación")]
        public int TipoDeHabitacion { get; set; }

        [Display(Name = "Tipo de Habitación")]
        public string TipoDeHabitacionTexto { get; set; }

        [Display(Name = "Costo de Reserva")]
  
        public decimal CostoDeReserva { get; set; }
    }
}