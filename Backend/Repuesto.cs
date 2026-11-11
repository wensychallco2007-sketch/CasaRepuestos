using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Repuesto
    {
        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public int Stock { get; set; }

        public decimal Precio { get; set; }
    }
}