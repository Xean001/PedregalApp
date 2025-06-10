using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class TrabajadorBLL
    {
        private TrabajadorDAL trabajadorDAL = new TrabajadorDAL();

        public List<Trabajador> ObtenerTrabajadores()
        {
            return trabajadorDAL.ListarTrabajadores();
        }
    }
}
