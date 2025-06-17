using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class datBin
    {
        #region singleton
        private static readonly datBin _instance = new datBin();
        public static datBin Instancia
        {
            get { return _instance; }
        }
        #endregion singleton

        #region metodos
        public List<entBin> ListarBin()
        {
            SqlCommand cmd = null;
            List<entBin> lista = new List<entBin>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaBin", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entBin Bin = new entBin();
                    Bin.codigoBin = dr["codigoBin"].ToString();
                    Bin.fecRegBin = Convert.ToDateTime(dr["fecRegBin"]);
                    Bin.pesoKg = Convert.ToInt32(dr["pesoKg"]);
                    Bin.estadoBin = Convert.ToBoolean(dr["estadoBin"]);
                    Bin.usoBin = Convert.ToBoolean(dr["usoBin"]);
                    lista.Add(Bin);
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
        public Boolean InsertarBin(entBin Bin)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaBin", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigoBin", Bin.codigoBin);
                cmd.Parameters.AddWithValue("@pesoKg", Bin.pesoKg);
                cmd.Parameters.AddWithValue("@fecRegBin", Bin.fecRegBin);
                cmd.Parameters.AddWithValue("@estadoBin", Bin.estadoBin);
                cmd.Parameters.AddWithValue("@usoBin", Bin.usoBin);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }
        public Boolean EditarBin(entBin Bin)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaBin", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigoBin", Bin.codigoBin);
                cmd.Parameters.AddWithValue("@pesoKg", Bin.pesoKg);
                cmd.Parameters.AddWithValue("@fecRegBin", Bin.fecRegBin);
                cmd.Parameters.AddWithValue("@estadoBin", Bin.estadoBin);
                cmd.Parameters.AddWithValue("@usoBin", Bin.usoBin);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;

        }
        public Boolean DeshabilitarBin(entBin Bin)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaBin", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigoBin", Bin.codigoBin);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }
        public bool BuscarBin(entBin Bin)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            bool encontrado = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarBin", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigoBin", Bin.codigoBin);
                cn.Open();

                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Bin.fecRegBin = Convert.ToDateTime(dr["fecRegBin"]);
                    Bin.pesoKg = Convert.ToDecimal(dr["pesoKg"]);
                    Bin.estadoBin = Convert.ToBoolean(dr["estadoBin"]);
                    Bin.usoBin = Convert.ToBoolean(dr["usoBin"]);
                    encontrado = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (dr != null) dr.Close();
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }

            return encontrado;
        }
        #endregion metodos
    }

}
