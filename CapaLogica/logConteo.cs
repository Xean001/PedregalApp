using System;
using System.Collections.Generic;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogica
{
    public class logConteo
    {
        private static readonly logConteo _instancia = new logConteo();
        public static logConteo Instancia => _instancia;

        public bool InsertarConteo(entConteo c)
        {
            return datConteo.Instancia.InsertarConteo(c);
        }

        public List<entConteo> ListarConteo()
        {
            return datConteo.Instancia.ListarConteo();
        }
    }
}
