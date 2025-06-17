using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedregalApp
{
    public partial class FormPlaga : Form
    {
        string cadenaConexion = "Server=DESKTOP-QV8AA6N;Database=Pedregal;Integrated Security=true";
        public FormPlaga()
        {
            InitializeComponent();
            CargarPlagas();
        }
        private void CargarPlagas()
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                string query = "SELECT * FROM Plaga";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPlagas.DataSource = dt;
            }
        }

        private void FormPlaga_Load(object sender, EventArgs e)
        {
            string cadenaConexion = "Server=DESKTOP-QV8AA6N;Database=Pedregal;Integrated Security=true";
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                try
                {
                    con.Open();
                    MessageBox.Show("Conexión exitosa");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            CargarPlagas();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                string query = "INSERT INTO Plaga (NombrePlaga, TipoPlaga, Descripcion, Habilitado) VALUES (@NombrePlaga, @TipoPlaga, @Descripcion, @Habilitado)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@NombrePlaga", txtNombrePlaga.Text);
                    cmd.Parameters.AddWithValue("@TipoPlaga", cmbTipoPlaga.Text);
                    cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                    cmd.Parameters.AddWithValue("@Habilitado", cbkHabilitado.Checked);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Plaga registrada correctamente.");
                        CargarPlagas();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al registrar: " + ex.Message);
                    }
                }
            }
        }

        private void dgvPlagas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvPlagas.Rows[e.RowIndex];
                txtNombrePlaga.Text = fila.Cells["Nombre"].Value.ToString();
                cmbTipoPlaga.Text = fila.Cells["Tipo"].Value.ToString();
                txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
                cbkHabilitado.Checked = Convert.ToBoolean(fila.Cells["Habilitado"].Value);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPlagas.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvPlagas.CurrentRow.Cells["IdPlaga"].Value);
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    string query = "UPDATE Plaga SET Nombre=@NombrePlaga, Tipo=@TipoPlaga, Descripcion=@Descripcion, Habilitado=@Habilitado WHERE IdPlaga=@Id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", txtNombrePlaga.Text);
                        cmd.Parameters.AddWithValue("@Tipo", cmbTipoPlaga.Text);
                        cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@Habilitado", cbkHabilitado.Checked);
                        cmd.Parameters.AddWithValue("@Id", id);

                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Plaga modificada correctamente.");
                            CargarPlagas();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al modificar: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void cbkHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            if (dgvPlagas.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvPlagas.CurrentRow.Cells["IdPlaga"].Value);
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    string query = "UPDATE Plaga SET Habilitado = 0 WHERE IdPlaga = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);

                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Plaga inhabilitada.");
                            CargarPlagas();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al inhabilitar: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                string query = "SELECT * FROM Plaga WHERE Nombre LIKE @Nombre";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@Nombre", "%" + txtBuscarPlaga.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPlagas.DataSource = dt;
            }
        }
    }
}
