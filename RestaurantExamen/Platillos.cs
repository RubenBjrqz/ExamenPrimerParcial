using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantExamen
{
    class Platillos
    {
        public string Plato { get; set; }
        public string IdentificadorPlato { get; set; }
        public float Precio { get; set; }

        List<Ingredientes> Ingredientes1 { get; set; } 
        public Menús Menús1 { get; set; }

        public Platillos()
        {
            Ingredientes1 = new List<Ingredientes>();
        }

    }
}
