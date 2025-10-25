using Practica1.Abstracciones.AccesoDatos.Habitaciones.ListaHabitaciones;
using Practica1.Abstracciones.AccesoDatos.Reservas.AgregarReserva;
using Practica1.Abstracciones.AccesoDatos.Reservas.BuscarReserva;
using Practica1.Abstracciones.AccesoDatos.Reservas.ObtenerTodasReservasAd;
using Practica1.Abstracciones.LogicaNegocio.Reservas.AgregarReservas;
using Practica1.Abstracciones.LogicaNegocio.Reservas.BuscarReserva;
using Practica1.Abstracciones.LogicaNegocio.Reservas.ObtenerReservas;
using Practica1.Abstracciones.LogicaNegocio.Reservas.ObtenerReservasDisponibles;
using Practica1.Abstracciones.LogicaNegocio.Reservas.ObternerTodasReservasLN;
using Practica1.Abstracciones.ModelosUI.Habitaciones;
using Practica1.Abstracciones.ModelosUI.ReservaDetalles;
using Practica1.Abstracciones.AccesoDatos.Reservas.ObtenerTodasReservasAd;
using Practica1.AccesoDat.AccesoDatos.Reservas;
using Practica1.Abstracciones.ModelosUI.Reservas;
using Practica1.AccesoDat.AccesoDatos.Habitaciones.ListaRepuestosAD;
using Practica1.AccesoDat.AccesoDatos.Reservas;
using Practica1.AccesoDat.AccesoDatos.Reservas.AgregarReserva;
using Practica1.AccesoDat.AccesoDatos.Reservas.BuscarReserva;
using Practica1.LogicaNegocio.Habitaciones.ListarHabitacionesLN;
using Practica1.LogicaNegocio.Habitaciones.ObtenerHabitacionesDisponiblesLN;
using Practica1.LogicaNegocio.Reservas.AgregarReservaLN;
using Practica1.LogicaNegocio.Reservas.AgregarReservaLN;
using Practica1.LogicaNegocio.Reservas.BuscarReservaLN;
using Practica1.LogicaNegocio.Reservas.ObtenerReserva;
using Practica1.LogicaNegocio.Reservas.ObtenerTodasReservasLN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Practica1.UI.Controllers
{
    public class ReservasController : Controller
    {
        private readonly IObtenerReservaLN _ObtenerReservaLN;
        private readonly IObtenerHabitacionesDisponiblesLN _ObtenerHabitacionesLN;
        private readonly IBuscarReservaLN _BuscarReservaLN;
        private readonly IAgregarReservaLN _AgregarReservaLN;
        private readonly IBuscarReservaLN _buscarReservaLN;
        private readonly IObtenerTodasReservasLN _reservasLN;

        public ReservasController()
        {
            ObtenerListaHabitaciones habitacionesAD = new ObtenerListaHabitaciones();
            _ObtenerReservaLN = new ObtenerReservasLN();
            IBuscarReservaAD buscarReservaAD = new BuscarReservaAD();
            _BuscarReservaLN = new BuscarReservaLN(buscarReservaAD);
            _ObtenerHabitacionesLN = new ObtenerHabitacionesDisponiblesLN(habitacionesAD);
            IAgregarReservaAD agregarReservaAD = new AgregarReservaAD();
            _AgregarReservaLN = new AgregarReservaLN(agregarReservaAD, habitacionesAD);
            _buscarReservaLN = new BuscarReservaLN(new BuscarReservaAD());
            //IObtenerTodasReservasAd reservasAd = new ObtenerTodasReservasAD();
            //_reservasLN = new ObtenerTodasReservasLN(reservasAd);
        }


        // GET: Reservas
        public ActionResult Index()
        {
            return View();
        }

        // GET: Reservas/ListaReservasHabitacion/5
        public ActionResult ListaReservasHabitacion(int? idHabitacion)
        {
            List<ReservaDetalleDTO> lista;

            if (idHabitacion.HasValue)
            {
                lista = _reservasLN.ObtenerPorIdHabitacion(idHabitacion.Value);
            }
            else
            {
                lista = _reservasLN.ObtenerTodas();
            }

            return View(lista);
        }
    

        // GET: Reservas/Listar
        [HttpGet]
        public ActionResult Listar()
        {
            List<HabitacionDTO> habitaciones = _ObtenerHabitacionesLN.Obtener();
            return View(habitaciones);
        }

        // POST: Reservas/BuscarReserva
        [HttpPost]
        public ActionResult BuscarReserva(int idReservacion)
        {
            ReservaDetalleDTO reserva = _BuscarReservaLN.BuscarPorIdHabitacion(idReservacion);
            return RedirectToAction("Detalles", new { idReservacion = idReservacion });
        }

        // GET: Reservas/Detalles/5
        public ActionResult Detalles(int id)
        {
            ReservaDetalleDTO reservaDetalle = _buscarReservaLN.BuscarPorIdHabitacion(id);

            if (reservaDetalle == null)
            {
               
                return RedirectToAction("ListaReservasHabitacion");
            }

            return View(reservaDetalle);
        }



        // POST: Reservas/Reservar
        [HttpGet]
        public ActionResult Reservar()
        {
            ReservacionesDTO modelo = new ReservacionesDTO();
            List<HabitacionDTO> habitaciones = _ObtenerHabitacionesLN.Obtener();
            ViewBag.Habitaciones = new SelectList(habitaciones, "ID", "Nombre");
            return View(modelo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Reservar(ReservacionesDTO reservaNueva)
        {
            if (!ModelState.IsValid)
            {
                List<HabitacionDTO> habitaciones = _ObtenerHabitacionesLN.Obtener();
                ViewBag.Habitaciones = new SelectList(habitaciones, "ID", "Nombre");
                return View(reservaNueva);
            }
                        try
            {
                int idReservaGenerada = await _AgregarReservaLN.Ejecutar(reservaNueva);
                              ;

                return RedirectToAction("ListaReservasHabitacion", new { idHabitacion = reservaNueva.IdHabitacion });
            }
            catch (Exception ex)
            {
                List<HabitacionDTO> habitaciones = _ObtenerHabitacionesLN.Obtener();
                ViewBag.Habitaciones = new SelectList(habitaciones, "ID", "Nombre");
                return View(reservaNueva);
            }
        }
    }
}