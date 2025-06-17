using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class datEmpleado
    {
        private static readonly datEmpleado _instancia = new datEmpleado();
        public static datEmpleado Instancia => _instancia;

        public List<entEmpleado> ListarEmpleados()
        {
            SqlCommand cmd = null;
            List<entEmpleado> lista = new List<entEmpleado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarEmpleados", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEmpleado e = new entEmpleado();
                    e.id_emp = Convert.ToInt32(dr["id_emp"]);
                    e.nom_emp = dr["nom_emp"].ToString();
                    lista.Add(e);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
    }
}
