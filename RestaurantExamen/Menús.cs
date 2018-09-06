using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantExamen
{
    class Menús
    {
        public string MenuNombre { get; set; }
        public string IdentificadorMenu { get; set; }
        public int HoraInicio { get; set; }
        public int HoraFin { get; set; }

        public Menús()
        {
            MenuNombre = "Nuevo menú";
            IdentificadorMenu = "0";
            HoraInicio = 0;
            HoraFin = 0;
        }

        public Menús(string menuNombre, string identificadorMenu, int horaInicio, int horaFin)
        {
            MenuNombre = menuNombre;
            IdentificadorMenu = identificadorMenu;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
        }
 
    }
}
