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
    public class datDisponibilidadPersonal
    {
        #region singleton
        private static readonly datDisponibilidadPersonal _instance = new datDisponibilidadPersonal();
        public static datDisponibilidadPersonal Instancia
        {
            get { return _instance; }
        }
        #endregion singleton

        #region metodos
        public List<entDisponibilidadPersonal> ListarDisponibilidad()
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<entDisponibilidadPersonal> lista = new List<entDisponibilidadPersonal>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarDisponibilidadPersonal", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entDisponibilidadPersonal disp = new entDisponibilidadPersonal();
                    disp.idDisponibilidad = Convert.ToInt32(dr["id_disponibilidad"]);
                    disp.idEmpleado = Convert.ToInt32(dr["id_empleado"]);
                    disp.idLote = Convert.ToInt32(dr["id_lote"]);
                    disp.horaInicio = Convert.ToDateTime(dr["hora_inicio"]);
                    disp.horaFin = Convert.ToDateTime(dr["hora_fin"]);
                    lista.Add(disp);
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

            return lista;
        }

        public bool InsertarDisponibilidad(entDisponibilidadPersonal disp)
        {
            SqlCommand cmd = null;
            bool inserta = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarDisponibilidadPersonal", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_empleado", disp.idEmpleado);
                cmd.Parameters.AddWithValue("@id_lote", disp.idLote);
                cmd.Parameters.AddWithValue("@hora_inicio", disp.horaInicio);
                cmd.Parameters.AddWithValue("@hora_fin", disp.horaFin);
                cn.Open();

                int i = cmd.ExecuteNonQuery();
                if (i > 0) inserta = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }

            return inserta;
        }

        public bool ActualizarDisponibilidad(entDisponibilidadPersonal disp)
        {
            SqlCommand cmd = null;
            bool actualizado = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spActualizarDisponibilidadPersonal", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_disponibilidad", disp.idDisponibilidad);
                cmd.Parameters.AddWithValue("@id_empleado", disp.idEmpleado);
                cmd.Parameters.AddWithValue("@id_lote", disp.idLote);
                cmd.Parameters.AddWithValue("@hora_inicio", disp.horaInicio);
                cmd.Parameters.AddWithValue("@hora_fin", disp.horaFin);
                cn.Open();

                int i = cmd.ExecuteNonQuery();
                if (i > 0) actualizado = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }

            return actualizado;
        }
        public List<entDisponibilidadPersonal> ListarDisponibilidadPorTrabajador(entDisponibilidadPersonal filtro)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<entDisponibilidadPersonal> lista = new List<entDisponibilidadPersonal>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarDisponibilidadPorTrabajador", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_empleado", filtro.idEmpleado);
                cn.Open();

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entDisponibilidadPersonal disp = new entDisponibilidadPersonal();
                    disp.idDisponibilidad = Convert.ToInt32(dr["id_disponibilidad"]);
                    disp.horaInicio = Convert.ToDateTime(dr["hora_inicio"]);
                    disp.horaFin = Convert.ToDateTime(dr["hora_fin"]);
                    disp.idLote = Convert.ToInt32(dr["id_lote"]);
                    lista.Add(disp);
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
        #endregion metodos
    }
}
