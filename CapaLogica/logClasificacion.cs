using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logClasificacion
    {
        private static readonly logClasificacion _instancia = new logClasificacion();
        public static logClasificacion Instancia => _instancia;
        public List<entClasificacion> ListarClasificaciones()
        {
            return datClasificacion.Instancia.ListarClasificaciones();
        }

    }
}
