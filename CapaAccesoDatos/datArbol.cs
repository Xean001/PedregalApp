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
    public class datArbol
    {
        private static readonly datArbol _instancia = new datArbol();
        public static datArbol Instancia => _instancia;

        public List<entArbol> ListarArbolesPorLinea(int idLinea)
        {
            SqlCommand cmd = null;
            List<entArbol> lista = new List<entArbol>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarArbolPorLinea", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_lin", idLinea);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entArbol a = new entArbol();
                    a.id_arb = Convert.ToInt32(dr["id_arb"]);
                    a.id_lin = Convert.ToInt32(dr["id_lin"]);
                    a.num_arb = Convert.ToInt32(dr["num_arb"]);
                    lista.Add(a);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd?.Connection.Close();
            }

            return lista;
        }
    }
}