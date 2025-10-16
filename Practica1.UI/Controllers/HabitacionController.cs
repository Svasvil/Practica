using Practica1.Abstracciones.ModelosUI.Habitaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica1.UI.Controllers
{
    public class HabitacionController : Controller
    {

        ///Lista de Habitaciones 
        // GET: Habitacion
        public ActionResult Lista_de_Habitaciones()
        {
            List<HabitacionDTO> listaHabitaciones = new List<HabitacionDTO>(); //Creamos una lista de habitaciones 
            listaHabitaciones.Add(new HabitacionDTO //Le agregamos datos a la habitacion
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
         
            });
            return View(listaHabitaciones); //Le pasamos la lista a la vista y le decimos que muestre la lista que creamos 
        }


        // GET: Habitacion/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        //Crear 

        // GET: Habitacion/Create
        public ActionResult Create()
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
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Habitacion/Delete/5
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
