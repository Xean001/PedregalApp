using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class LineaBLL
    {
        private LineaDAL lineaDAL = new LineaDAL();

        public List<Lineas> ObtenerLineasPorCortina(int idCortina)
        {
            return lineaDAL.ListarLineasPorCortina(idCortina);
        }
    }
}
