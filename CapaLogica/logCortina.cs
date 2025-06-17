using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logCortina
    {
        private static readonly logCortina _instancia = new logCortina();
        public static logCortina Instancia => _instancia;

        public List<entCortina> ListarCortinasPorLote(int idLote)
        {
            return datCortina.Instancia.ListarCortinasPorLote(idLote);
        }
    }
}