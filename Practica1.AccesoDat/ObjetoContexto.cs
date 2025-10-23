using Practica1.AccesoDat.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.AccesoDat
{
    public  class ObjetoContexto : DbContext
    {
        public ObjetoContexto() {
            Database.SetInitializer<ObjetoContexto>(null);
        }

        public  DbSet<HabitacionesAccesoDatos> HABITACIONES { get; set; }
        public DbSet<ReservasAccesoDatos> RESERVACIONES { get; set; }
    }
}
