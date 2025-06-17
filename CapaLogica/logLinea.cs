using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logLinea
    {
        private static readonly logLinea _instancia = new logLinea();
        public static logLinea Instancia => _instancia;

        public List<entLinea> ListarLineasPorCortina(int idCortina)
        {
            return datLinea.Instancia.ListarLineasPorCortina(idCortina);
        }
    }
}
