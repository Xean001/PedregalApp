using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entOrdenRecoleccion
    {
        public int idOrden { get; set; }
        public string codigoOrden { get; set; }
        public DateTime fechaRecoleccion { get; set; }
        public int cantidadEstimada { get; set; }
        public int idEmpleado { get; set; }
        public bool estado { get; set; }
    }
}
