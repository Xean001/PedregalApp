using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class CortinaBLL
    {
        private CortinaDAL cortinaDAL = new CortinaDAL();

        public List<Cortina> ObtenerCortinasPorLote(int idLote)
        {
            return cortinaDAL.ListarCortinasPorLote(idLote);
        }
    }
}
