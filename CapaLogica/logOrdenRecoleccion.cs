using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logOrdenRecoleccion
    {
        #region singleton
        private static readonly logOrdenRecoleccion _instancia = new logOrdenRecoleccion();
        public static logOrdenRecoleccion Instancia => _instancia;
        #endregion singleton
        #region metodos
        public bool InsertarOrden(entOrdenRecoleccion orden)
        {
            return datOrdenRecoleccion.Instancia.InsertarOrden(orden);
        }

        public List<entOrdenRecoleccion> ListarOrdenes()
        {
            return datOrdenRecoleccion.Instancia.ListarOrdenes();
        }
        public entOrdenRecoleccion BuscarOrdenPorId(int idOrden)
        {
            return datOrdenRecoleccion.Instancia.BuscarOrdenPorId(idOrden);
        }
        public bool AnularOrden(int idOrden)
        {
            return datOrdenRecoleccion.Instancia.AnularOrden(idOrden);
        }
        #endregion metodo
    }
}
