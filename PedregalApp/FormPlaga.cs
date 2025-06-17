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
        string cadenaConexion = "Server=UTSILAB411;Database=PEDREGAL;Integrated Security=true";
        public FormPlaga()
        {
            InitializeComponent();
            CargarPlagas();
        }
        private void CargarPlagas()
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                string query = "SELECT IdPlaga, NombrePlaga, TipoPlaga, Descripcion, Habilitado FROM Plaga";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPlagas.DataSource = dt;

               
                if (dgvPlagas.Columns.Contains("Habilitado"))
                {
                    dgvPlagas.Columns["Habilitado"].ReadOnly = false;
                    dgvPlagas.Columns["Habilitado"].DefaultCellStyle.NullValue = false;

              
                    DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                    chk.DataPropertyName = "Habilitado";
                    chk.HeaderText = "Habilitado";
                    chk.Name = "Habilitado";

                    int colIndex = dgvPlagas.Columns["Habilitado"].Index;
                    dgvPlagas.Columns.Remove("Habilitado");
                    dgvPlagas.Columns.Insert(colIndex, chk);
                }

                dgvPlagas.Columns["IdPlaga"].Visible = false; 
            }
        }

        private void FormPlaga_Load(object sender, EventArgs e)
        {
  
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
            CargarPlagas();

        }

        private void dgvPlagas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvPlagas.Columns[e.ColumnIndex].Name == "Habilitado")
            {
                int id = Convert.ToInt32(dgvPlagas.Rows[e.RowIndex].Cells["IdPlaga"].Value);
                bool nuevoValor = Convert.ToBoolean(dgvPlagas.Rows[e.RowIndex].Cells["Habilitado"].Value);

                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    string query = "UPDATE Plaga SET Habilitado = @Habilitado WHERE IdPlaga = @Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Habilitado", nuevoValor);
                    cmd.Parameters.AddWithValue("@Id", id);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar checkbox: " + ex.Message);
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPlagas.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvPlagas.CurrentRow.Cells["IdPlaga"].Value);

                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    string query = "UPDATE Plaga SET NombrePlaga=@NombrePlaga, TipoPlaga=@TipoPlaga, Descripcion=@Descripcion, Habilitado=@Habilitado WHERE IdPlaga=@Id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NombrePlaga", txtNombrePlaga.Text);
                        cmd.Parameters.AddWithValue("@TipoPlaga", cmbTipoPlaga.Text);
                        cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@Habilitado", cbkHabilitado.Checked);
                        cmd.Parameters.AddWithValue("@Id", id);

                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Plaga modificada correctamente.");
                            CargarPlagas(); // Esto actualiza la grilla
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

                       
                    }
                }
            }
        }

       
        
    }
}
