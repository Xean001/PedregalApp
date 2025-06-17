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
    public class datConteo
    {
        private static readonly datConteo _instancia = new datConteo();
        public static datConteo Instancia => _instancia;

        public bool InsertarConteo(entConteo c)
        {
            SqlCommand cmd = null;
            bool inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarConteo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_lot", c.id_lot);
                cmd.Parameters.AddWithValue("@id_emp", c.id_emp);
                cmd.Parameters.AddWithValue("@id_arb", c.id_arb);
                cmd.Parameters.AddWithValue("@can_con", c.can_con);
                cn.Open();
                inserta = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return inserta;
        }

        public List<entConteo> ListarConteo()
        {
            SqlCommand cmd = null;
            List<entConteo> lista = new List<entConteo>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarConteo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var c = new entConteo
                    {
                        id_con = Convert.ToInt32(dr["id_con"]),
                        num_lot = Convert.ToInt32(dr["num_lot"]),
                        nom_emp = dr["nom_emp"].ToString(),
                        can_con = Convert.ToInt32(dr["can_con"])
                    };
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
        public List<entLote> ListarLotes()
        {
            SqlCommand cmd = null;
            List<entLote> lista = new List<entLote>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarLotes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entLote l = new entLote();
                    l.id_lot = Convert.ToInt32(dr["id_lot"]);
                    l.num_lot = Convert.ToInt32(dr["num_lot"].ToString());
                    lista.Add(l);
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
