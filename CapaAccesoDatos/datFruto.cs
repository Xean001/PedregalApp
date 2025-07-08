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
    public class datFruto

    {
        private static readonly datFruto _instancia = new datFruto();
        public static datFruto Instancia => _instancia;

        public bool InsertarFruto(entFruto f)
        {
            SqlCommand cmd = null;
            bool exito = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarFruto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_arbol", f.id_arbol);
                cmd.Parameters.AddWithValue("@id_empleado", f.id_empleado);
                cmd.Parameters.AddWithValue("@peso", f.peso);
                cmd.Parameters.AddWithValue("@clasificacion", f.clasificacion);
                cmd.Parameters.AddWithValue("@cantidad", f.cantidad);
                cn.Open();
                exito = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return exito;
        }
        public bool InhabilitarFruto(int id_fruto)
        {
            SqlCommand cmd = null;
            bool exito = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInhabilitarFruto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_fruto", id_fruto);
                cn.Open();
                exito = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }
            return exito;
        }

        public List<entFruto> ListarFrutosPorArbol(int idArbol)
        {
            List<entFruto> lista = new List<entFruto>();
            SqlCommand cmd = null;
            SqlDataReader dr = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarFrutosPorArbol", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_arbol", idArbol);
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entFruto f = new entFruto
                    {
                        peso = Convert.ToDecimal(dr["peso"]),
                        clasificacion = dr["clasificacion"].ToString(),
                        calibre = dr["calibre"].ToString(),
                        cantidad = Convert.ToInt32(dr["cantidad"]),
                        empleado = dr["empleado"].ToString()
                    };
                    lista.Add(f);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dr != null) dr.Close();
                cmd.Connection.Close();
            }

            return lista;
        }

    }

}


    

