using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logArbol
    {
        private static readonly logArbol _instancia = new logArbol();
        public static logArbol Instancia => _instancia;

        public List<entArbol> ListarArbolesPorLinea(int idLinea)
        {
            return datArbol.Instancia.ListarArbolesPorLinea(idLinea);
        }
    }
}