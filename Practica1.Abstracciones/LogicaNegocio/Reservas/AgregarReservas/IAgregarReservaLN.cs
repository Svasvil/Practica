using Practica1.Abstracciones.ModelosUI.Reservas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Abstracciones.LogicaNegocio.Reservas.AgregarReservas
{
    public  interface IAgregarReservaLN
    {
        Task<int> Ejecutar(ReservacionesDTO reserva);
        
    }
}
