using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class Conexion
    {
        //patron de Diseño Singleton
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }
        public SqlConnection Conectar()

        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DESKTOP-62V8LFN;Initial Catalog=Pedregal;Integrated Security=true";
            return cn;
           
        }

    }
}
