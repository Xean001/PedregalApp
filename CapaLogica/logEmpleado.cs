using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logEmpleado
    {
        private static readonly logEmpleado _instancia = new logEmpleado();
        public static logEmpleado Instancia => _instancia;

        public List<entEmpleado> ListarEmpleados()
        {
            return datEmpleado.Instancia.ListarEmpleados();
        }
    }
}