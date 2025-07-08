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
    public class datCortina
    {
        private static readonly datCortina _instancia = new datCortina();
        public static datCortina Instancia => _instancia;

        public List<entCortina> ListarCortinasPorLote(int idLote)
        {
            SqlCommand cmd = null;
            List<entCortina> lista = new List<entCortina>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarCortinasPorLote", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_lote", idLote);
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCortina c = new entCortina();
                    c.id_cor = Convert.ToInt32(dr["id_cor"]);
                    c.nom_cor = dr["nom_cor"].ToString();
                    c.id_lot = Convert.ToInt32(dr["id_lot"]);
                    lista.Add(c);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }

            return lista;
        }
    }
}