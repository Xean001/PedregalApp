using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class ConteoFrutaBLL
    {
        private ConteoFrutaDAL conteoDAL = new ConteoFrutaDAL();

        public bool RegistrarConteo(ConteoFruta conteo)
        {
            return conteoDAL.InsertarConteoFruta(conteo);
        }

        public List<ConteoFruta> ObtenerConteos()
        {
            return conteoDAL.ListarConteos();
        }
    }
}