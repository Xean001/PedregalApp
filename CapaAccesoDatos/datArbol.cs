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

        public List<entArbolMostrar> ListarArbolesCompleto()
        {
            SqlCommand cmd = null;
            List<entArbolMostrar> lista = new List<entArbolMostrar>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarArbolesCompleto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entArbolMostrar a = new entArbolMostrar();
                    a.id_arbol = Convert.ToInt32(dr["id_arbol"]);
                    a.codigo = dr["codigo"].ToString();
                    a.estado = dr["estado"].ToString();
                    a.nombre_lote = dr["nombre_lote"].ToString();
                    a.nombre_cortina = dr["nombre_cortina"].ToString();
                    a.nombre_linea = dr["nombre_linea"].ToString();
                    lista.Add(a);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd?.Connection.Close();
            }

            return lista;
        }
        public entArbolMostrar BuscarArbolPorCodigo(string codigo)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            entArbolMostrar arbol = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarArbolPorCodigo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cn.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    arbol = new entArbolMostrar
                    {
                        id_arbol = Convert.ToInt32(dr["id_arbol"]),
                        codigo = dr["codigo"].ToString(),
                        estado = dr["estado"].ToString(),
                        nombre_lote = dr["nombre_lote"].ToString(),
                        nombre_cortina = dr["nombre_cortina"].ToString(),
                        nombre_linea = dr["nombre_linea"].ToString()
                    };
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

            return arbol;
        }


        public int ObtenerCantidadArbolesPorLinea(int idLinea)
        {
            SqlCommand cmd = null;
            int total = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spContarArbolesPorLinea", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_linea", idLinea);
                cn.Open();
                total = (int)cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd?.Connection.Close();
            }
            return total;
        }

        public bool InsertarArbol(entArbol arbol)
        {
            SqlCommand cmd = null;
            bool inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarArbol", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_linea", arbol.id_lin);
                cmd.Parameters.AddWithValue("@codigo", arbol.codigo);
                cmd.Parameters.AddWithValue("@estado", arbol.estado);
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
        public bool InhabilitarArbol(string codigo)
        {
            SqlCommand cmd = null;
            bool actualizado = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInhabilitarArbol", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cn.Open();
                actualizado = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }

            return actualizado;
        }
        public bool ActivarArbol(string codigo)
        {
            SqlCommand cmd = null;
            bool actualizado = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spActivarArbol", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cn.Open();
                actualizado = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }

            return actualizado;
        }

    }
}