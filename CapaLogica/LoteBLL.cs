using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogica
{
    public class LoteBLL
    {
        public LoteDAL loteDAL = new LoteDAL();

        public List<Lote> ObtenerLotes()
        {
            return loteDAL.ListarLotes();
        }
    }
}
