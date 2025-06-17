using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entConteo
    {
        public int id_con { get; set; }
        public int id_lot { get; set; }
        public int id_emp { get; set; }
        public int can_con { get; set; }

        // Propiedades adicionales para mostrar en listas
        public string nom_emp { get; set; }
        public int num_lot { get; set; }
    }
}




