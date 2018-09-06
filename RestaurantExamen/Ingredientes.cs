using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantExamen
{
    class Ingredientes
    {
        public string Ingrediente { get; set; } 
        public string Identificador { get; set; }

        public Ingredientes()
        {
            Ingrediente = "Nuevo ingrediente";
            Identificador = "0";
        }

        public Ingredientes(string ingrediente, string identificador)
        {
            Ingrediente = ingrediente;
            Identificador = identificador;
        }
    }
}
