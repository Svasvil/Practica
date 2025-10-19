using Practica1.Abstracciones.LogicaNegocio.Habitaciones.AgregarHabitaciones;
using Practica1.Abstracciones.LogicaNegocio.Habitaciones.EditarHabitaciones;
using Practica1.Abstracciones.LogicaNegocio.Habitaciones.ListaDeHabitaciones;
using Practica1.Abstracciones.ModelosUI.Habitaciones;
using Practica1.AccesoDat.AccesoDatos.Habitaciones.ObtenerHabitacionID_AD;
using Practica1.LogicaNegocio.Habitaciones.AgregarHabitacionesLN;
using Practica1.LogicaNegocio.Habitaciones.EditarHabitacionesLN;
using Practica1.LogicaNegocio.Habitaciones.ListarHabitacionesLN;
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
        private readonly ObtenerHabitacionID _ObtenerHabitacionID;

        public HabitacionController()
        {
            _ObtenerListaHabitacionesLN = new ObtenerListaHabitacionesLN();
            _AgregarHabitacionesLN = new AgregarHabitacionesLN();
            _EditarHabitacionLN = new EditarHabitacionLN();
            _ObtenerHabitacionID = new ObtenerHabitacionID();
        }
        public ActionResult Lista_de_Habitaciones()
        {
            List<HabitacionDTO> listaHabitaciones = _ObtenerListaHabitacionesLN.Obtener();
            return View(listaHabitaciones);
        }

        public ActionResult Detalles_Habitacion(int id)
        {
            return View();
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
                int CantidadHabitacionAgregada = await _AgregarHabitacionesLN.Agregar(NuevaHabitacion);
                return RedirectToAction("Lista_de_Habitaciones", "Habitacion");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Editar_Habitacion(int id)
        {
            HabitacionDTO habitacion = _ObtenerHabitacionID.obtener(id);
            return View(habitacion);
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
    }
}