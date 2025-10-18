using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.LogicaNegocio.General.GestionFechas
{
    public  class Fecha :IFecha
    {
        public DateTime ObtenerFechaActual()
        {
            int ZonaHoraria = int.Parse( ConfigurationManager.AppSettings["ZonaHoraria"]); //Obtenemos la zona horaria desde el archivo de configuracion
            return DateTime.UtcNow;
        }

      
    }
}
