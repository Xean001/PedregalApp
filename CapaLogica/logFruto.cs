using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logFruto
    {
        private static readonly logFruto _instancia = new logFruto();
        public static logFruto Instancia => _instancia;

        public bool InsertarFruto(entFruto f)
        {
            return datFruto.Instancia.InsertarFruto(f);
        }
        public List<entFruto> ListarFrutosPorArbol(int idArbol)
        {
            return datFruto.Instancia.ListarFrutosPorArbol(idArbol);
        }
        public bool InhabilitarFruto(int id_fruto)
        {
            return datFruto.Instancia.InhabilitarFruto(id_fruto);
        }

    }
}

