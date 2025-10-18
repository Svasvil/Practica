using Practica1.Abstracciones.LogicaNegocio.Habitaciones.AgregarHabitaciones;
using Practica1.Abstracciones.LogicaNegocio.Habitaciones.EditarHabitaciones;
using Practica1.Abstracciones.LogicaNegocio.Habitaciones.ListaDeHabitaciones;
using Practica1.Abstracciones.ModelosUI.Habitaciones;
using Practica1.LogicaNegocio.Habitaciones.AgregarHabitacionesLN;
using Practica1.LogicaNegocio.Habitaciones.EditarHabitacionesLN;
using Practica1.LogicaNegocio.Habitaciones.ListarHabitacionesLN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Practica1.UI.Controllers
{
    public class HabitacionController : Controller
    {
        private readonly IObtenerListaHabitacionesLN _ObtenerListaHabitacionesLN;
        private readonly IAgregarHabitacionesLN _AgregarHabitacionesLN;
        private readonly IEditarHabitacionLN _EditarHabitacionLN;

        public HabitacionController() {
            _ObtenerListaHabitacionesLN = new ObtenerListaHabitacionesLN();
            _AgregarHabitacionesLN = new AgregarHabitacionesLN();
            _EditarHabitacionLN = new EditarHabitacionLN();
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
        public async Task<ActionResult> Crear_Habitacion(HabitacionDTO NuevaHabitacion)
        {
            try
            {
                int CantidadHabitacionAgregada = await _AgregarHabitacionesLN.Agregar(NuevaHabitacion);

                return RedirectToAction("Lista_de_Habitaciones", "Habitacion");

            }
            catch
            {
                return View();
            }
        }

        // GET: Habitacion/Edit/5
        public ActionResult Editar_Habitacion(int id)
        {
           
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
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
