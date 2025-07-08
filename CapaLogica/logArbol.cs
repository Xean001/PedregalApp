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

        public int ObtenerTotalArboles(int idLinea)
        {
            return datArbol.Instancia.ObtenerCantidadArbolesPorLinea(idLinea);
        }

        public bool RegistrarArbol(entArbol a)
        {
            return datArbol.Instancia.InsertarArbol(a);
        }
        public List<entArbolMostrar> ListarArbolesCompleto()
        {
            return datArbol.Instancia.ListarArbolesCompleto();
        }
        public entArbolMostrar BuscarArbolPorCodigo(string codigo)
        {
            return datArbol.Instancia.BuscarArbolPorCodigo(codigo);
        }


    }
}