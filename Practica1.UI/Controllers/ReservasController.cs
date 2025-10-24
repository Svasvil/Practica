using Practica1.Abstracciones.LogicaNegocio.Reservas.ObtenerReservas;
using Practica1.Abstracciones.ModelosUI.Reservas;
using Practica1.LogicaNegocio.Reservas.ObtenerReserva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica1.UI.Controllers
{
    public class ReservasController : Controller
    {
        private readonly IObtenerReservaLN _obtenerReservaLN;


        public ReservasController()
        {
            _obtenerReservaLN = new ObtenerReservasLN();
        }   
        // GET: Reservas
        public ActionResult Index()
        {
            return View();
        }

        // GET: Reservas/Details/5
        public ActionResult ListaReservasHabitacion(int? idHabitacion) 
        {
            //Aca validamos que si tiene un id , en caso de que no tenga nos manda de vuelta a la lista normal.
            if (!idHabitacion.HasValue)
            {
                return View("ListaReservasHabitacion", new List<ReservacionesDTO>());
            }

         
            List<ReservacionesDTO> lista = _obtenerReservaLN.Obtener(idHabitacion.Value);
            return View("ListaReservasHabitacion", lista);
        }

        // GET: Reservas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reservas/Create
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

        // GET: Reservas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reservas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: Reservas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reservas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
