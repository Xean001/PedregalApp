using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class ArbolBLL
    {
        private ArbolDAL arbolDAL = new ArbolDAL();

        public List<Arbol> ObtenerArbolesPorLinea(int idLinea)
        {
            return arbolDAL.ListarArbolesPorLinea(idLinea);
        }
    }
}