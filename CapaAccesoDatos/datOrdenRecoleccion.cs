using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class datOrdenRecoleccion
    {
        #region singleton
        private static readonly datOrdenRecoleccion _instancia = new datOrdenRecoleccion();
        public static datOrdenRecoleccion Instancia => _instancia;
        #endregion signleton
        #region metodos
        public bool InsertarOrden(entOrdenRecoleccion orden)
        {
            SqlCommand cmd = null;
            bool insertado = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarOrdenRecoleccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo_orden", orden.codigoOrden);
                cmd.Parameters.AddWithValue("@fecha_recoleccion", orden.fechaRecoleccion);
                cmd.Parameters.AddWithValue("@cantidad_estimada", orden.cantidadEstimada);
                cmd.Parameters.AddWithValue("@id_empleado", orden.idEmpleado);
                cn.Open();
                insertado = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }

            return insertado;
        }

        public List<entOrdenRecoleccion> ListarOrdenes()
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<entOrdenRecoleccion> lista = new List<entOrdenRecoleccion>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarOrdenesRecoleccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entOrdenRecoleccion o = new entOrdenRecoleccion();
                    o.idOrden = Convert.ToInt32(dr["id_orden"]);
                    o.codigoOrden = dr["codigo_orden"].ToString();
                    o.fechaRecoleccion = Convert.ToDateTime(dr["fecha_recoleccion"]);
                    o.cantidadEstimada = Convert.ToInt32(dr["cantidad_estimada"]);
                    o.idEmpleado = Convert.ToInt32(dr["id_empleado"]);
                    lista.Add(o);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dr != null) dr.Close();
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }

            return lista;
        }
        public bool AnularOrden(int idOrden)
        {
            SqlCommand cmd = null;
            bool anulado = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAnularOrdenRecoleccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_orden", idOrden);
                cn.Open();

                int filas = cmd.ExecuteNonQuery();
                if (filas > 0)
                    anulado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }

            return anulado;
        }
        public entOrdenRecoleccion BuscarOrdenPorId(int idOrden)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            entOrdenRecoleccion orden = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarOrdenPorId", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_orden", idOrden);
                cn.Open();

                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    orden = new entOrdenRecoleccion();
                    orden.idOrden = Convert.ToInt32(dr["id_orden"]);
                    orden.codigoOrden = dr["codigo_orden"].ToString();
                    orden.fechaRecoleccion = Convert.ToDateTime(dr["fecha_recoleccion"]);
                    orden.cantidadEstimada = Convert.ToInt32(dr["cantidad_estimada"]);
                    orden.idEmpleado = Convert.ToInt32(dr["id_empleado"]);
                    orden.estado = Convert.ToBoolean(dr["estado"]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dr != null) dr.Close();
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }

            return orden;
        }
        #endregion metodos
    }
}
