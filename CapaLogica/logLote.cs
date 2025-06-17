using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogica
{
    public class logLote
    {
        // Singleton
        private static readonly logLote _instancia = new logLote();
        public static logLote Instancia
        {
            get { return _instancia; }
        }

        // Métodos
        public List<entLote> ListarLotes()
        {
            return datConteo.Instancia.ListarLotes();
        }
    }
}
