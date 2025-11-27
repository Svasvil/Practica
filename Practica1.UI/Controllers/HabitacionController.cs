using Practica1.Abstracciones.AccesoDatos.Habitaciones.ObtenerHabitacionID;
using Practica1.Abstracciones.LogicaNegocio.Habitaciones.AgregarHabitaciones;
using Practica1.Abstracciones.LogicaNegocio.Habitaciones.EditarHabitaciones;
using Practica1.Abstracciones.LogicaNegocio.Habitaciones.ListaDeHabitaciones;
using Practica1.Abstracciones.LogicaNegocio.Reservas.BuscarReserva;
using Practica1.Abstracciones.ModelosUI.Habitaciones;
using Practica1.Abstracciones.ModelosUI.ReservaDetalles;
using Practica1.AccesoDat.AccesoDatos.Habitaciones.ObtenerHabitacionID_AD;
using Practica1.LogicaNegocio.Habitaciones.AgregarHabitacionesLN;
using Practica1.LogicaNegocio.Habitaciones.EditarHabitacionesLN;
using Practica1.LogicaNegocio.Habitaciones.ListarHabitacionesLN;
using Practica1.LogicaNegocio.Habitaciones.ObtenerHabitacionID;
using Practica1.LogicaNegocio.Reservas.BuscarReservaLN;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Practica1.UI.Controllers
{
    public class HabitacionController : Controller
    {
        private readonly IObtenerListaHabitacionesLN _ObtenerListaHabitacionesLN;
        private readonly IAgregarHabitacionesLN _AgregarHabitacionesLN;
        private readonly IEditarHabitacionLN _EditarHabitacionLN;
        private readonly ObtenerHabitacionLN _ObtenerHabitacionLN;
        private readonly IBuscarReservaLN _BuscarReservaLN;

        public HabitacionController()
        {
            _ObtenerListaHabitacionesLN = new ObtenerListaHabitacionesLN();
            _AgregarHabitacionesLN = new AgregarHabitacionesLN();
            _EditarHabitacionLN = new EditarHabitacionLN();
            //_ObtenerHabitacionLN = new ObtenerHabitacionLN();
            _BuscarReservaLN = new BuscarReservaLN(); 
        }

        public ActionResult Lista_de_Habitaciones()
        {
            List<HabitacionDTO> listaHabitaciones = _ObtenerListaHabitacionesLN.Obtener();
            return View(listaHabitaciones);
        }


        //Vista parcial.
        public ActionResult ObtenerListaHabitacionesParcial(int id)
        {
            List<HabitacionDTO> listaHabitaciones = _ObtenerListaHabitacionesLN.Obtener();
            return PartialView("_ListaParcialHabitaciones",listaHabitaciones);
        }

        public ActionResult Detalles(int id)
        {
            ReservaDetalleDTO reservaDetalle = _BuscarReservaLN.BuscarPorIdHabitacion(id);

            if (reservaDetalle == null)
            {
                return RedirectToAction("ListaReservasHabitacion");
            }

            return View(reservaDetalle);
        }

        public ActionResult Crear_Habitacion()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Crear_Habitacion(HabitacionDTO NuevaHabitacion)
        {
          
            try
            {
                NuevaHabitacion.Estado = true;
                int CantidadHabitacionAgregada = await _AgregarHabitacionesLN.Agregar(NuevaHabitacion);
                return RedirectToAction("Lista_de_Habitaciones", "Habitacion");
            }
            catch
            {
                return View();
            }
        }

        public async Task<ActionResult> Editar_Habitacion(int id)
        {
            HabitacionDTO habitacion = await _ObtenerHabitacionLN.Obtener(id);
            habitacion.ID = id;
            return View(habitacion);
        }

        [HttpPost]
        public async Task<ActionResult> Editar_Habitacion(HabitacionDTO HabitacionEditada)
        {
            try
            {
                int CantidadHabitacionEditada = await _EditarHabitacionLN.Editar(HabitacionEditada);
                return RedirectToAction("Lista_de_Habitaciones", "Habitacion");
            }
            catch
            {
                return View(HabitacionEditada);
            }
        }
    }
}