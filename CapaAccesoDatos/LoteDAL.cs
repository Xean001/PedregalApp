using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class LoteDAL
    {
        private static readonly LoteDAL _instancia = new LoteDAL();
        public static LoteDAL Instancia => _instancia;

        public List<Lote> ListarLotes()
        {
            List<Lote> lista = new List<Lote>();
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SELECT IdLote, Numero FROM Lotes", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Lote
                    {
                        IdLote = Convert.ToInt32(dr["IdLote"]),
                        Numero = Convert.ToInt32(dr["Numero"]),
                    });
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                    cmd.Connection.Close();
            }
            return lista;
        }
    }
}