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
    public class datLinea
    {
        private static readonly datLinea _instancia = new datLinea();
        public static datLinea Instancia => _instancia;

        public List<entLinea> ListarLineasPorCortina(int idCortina)
        {
            SqlCommand cmd = null;
            List<entLinea> lista = new List<entLinea>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarLineaPorCortina", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cor", idCortina);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entLinea l = new entLinea();
                    l.id_lin = Convert.ToInt32(dr["id_lin"]);
                    l.id_cor = Convert.ToInt32(dr["id_cor"]);
                    l.num_lin = Convert.ToInt32(dr["num_lin"]);
                    lista.Add(l);
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
