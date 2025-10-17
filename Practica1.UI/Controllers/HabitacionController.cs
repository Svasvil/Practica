using Practica1.Abstracciones.LogicaNegocio.Habitaciones.ListaDeHabitaciones;
using Practica1.Abstracciones.ModelosUI.Habitaciones;
using Practica1.LogicaNegocio.Habitaciones.ListarHabitacionesLN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica1.UI.Controllers
{
    public class HabitacionController : Controller
    {
        private readonly IObtenerListaHabitacionesLN _ObtenerListaHabitacionesLN;

        public HabitacionController() {
            _ObtenerListaHabitacionesLN = new ObtenerListaHabitacionesLN();
        }

        ///Lista de Habitaciones 
        // GET: Habitacion
        public ActionResult Lista_de_Habitaciones()
        {
            List<HabitacionDTO> listaHabitaciones = _ObtenerListaHabitacionesLN.Obtener();

            return View(listaHabitaciones);
        }


        // GET: Habitacion/Details/5
        public ActionResult Detalles_Habitacion(int id)
        {
            return View();
        }


        //Crear 

        // GET: Habitacion/Create
        public ActionResult Crear_Habitacion()
        {
            return View();
        }

        // POST: Habitacion/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Habitacion/Edit/5
        public ActionResult Editar_Habitacion(int id)
        {
            HabitacionDTO habitacion = new HabitacionDTO
            {
                Codigo = 1,
                Nombre = "Habitacion Sencilla",
                Ubicacion = "Primer Piso",
                CantidadHuespedesAdmitidos = 2,
                CantidadCamas = 1,
                CantidadBanos = 1,
                ResponsableLimpieza = "Juan Perez",
                CostoLimpieza = 50,
                CostoReserva = 100,
                TipoHabitacion = 1,
                Estado = 1,
            };
            return View(habitacion);
        }

        // POST: Habitacion/Edit/5
        [HttpPost]
        public ActionResult Editar_Habitacion(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Habitacion/Delete/5
        public ActionResult Eliminar_Habitacion(int id)
        {
            return View();
        }

        // POST: Habitacion/Delete/5
        [HttpPost]
        public ActionResult Eliminar_Habitacion(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
