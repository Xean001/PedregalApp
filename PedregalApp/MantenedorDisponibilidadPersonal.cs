using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedregalApp
{
    public partial class MantenedorDisponibilidadPersonal : Form
    {
        public MantenedorDisponibilidadPersonal()
        {
            InitializeComponent();
        }
        public void listar()
        {
            dgvDisponibilidad.DataSource = logDisponibilidadPersonal.Instancia.ListarDisponibilidad();
        }
        private void LimpiarVariables()
        {
            txtCodEmpleado.Clear();
            txtCodLote.Clear();
            dtPickerRegInicio.Value = DateTime.Now;
            dtPickerRegFin.Value = DateTime.Now.AddHours(8);
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            btnRealizaConsulta.Visible = true;
            btnAgregar.Visible = false;
            btnModificar.Visible = false;
            txtCodEmpleado.Enabled = true;
            grupBoxDatos.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
            txtCodEmpleado.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCodEmpleado.Enabled = true;
            grupBoxDatos.Enabled = true;
            btnAgregar.Visible = true;
            LimpiarVariables();
            btnEditar.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodEmpleado.Text) || string.IsNullOrWhiteSpace(txtCodLote.Text))
            {
                MessageBox.Show("Debe ingresar el código de empleado y lote.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCodEmpleado.Text, out int idEmpleado) || !int.TryParse(txtCodLote.Text, out int idLote))
            {
                MessageBox.Show("Código de empleado y lote deben ser números válidos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                entDisponibilidadPersonal d = new entDisponibilidadPersonal();
                d.idEmpleado = idEmpleado;
                d.idLote = idLote;
                d.horaInicio = dtPickerRegInicio.Value;
                d.horaFin = dtPickerRegFin.Value;

                logDisponibilidadPersonal.Instancia.InsertarDisponibilidad(d);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar disponibilidad: " + ex.Message);
            }

            LimpiarVariables();
            listar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvDisponibilidad.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un registro para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCodEmpleado.Text, out int idEmpleado) || !int.TryParse(txtCodLote.Text, out int idLote))
            {
                MessageBox.Show("Código de empleado y lote deben ser válidos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                entDisponibilidadPersonal d = new entDisponibilidadPersonal();
                d.idDisponibilidad = Convert.ToInt32(dgvDisponibilidad.CurrentRow.Cells["id_disponibilidad"].Value);
                d.idEmpleado = idEmpleado;
                d.idLote = idLote;
                d.horaInicio = dtPickerRegInicio.Value;
                d.horaFin = dtPickerRegFin.Value;

                logDisponibilidadPersonal.Instancia.ActualizarDisponibilidad(d);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar disponibilidad: " + ex.Message);
            }

            LimpiarVariables();
            listar();
        }

        private void btnRealizaConsulta_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodEmpleado.Text, out int idEmpleado))
            {
                MessageBox.Show("Debe ingresar un código de empleado válido para consultar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                entDisponibilidadPersonal filtro = new entDisponibilidadPersonal();
                filtro.idEmpleado = idEmpleado;

                var listaHorarios = logDisponibilidadPersonal.Instancia.BuscarDisponibilidadPorTrabajador(filtro);

                if (listaHorarios.Count == 0)
                {
                    MessageBox.Show("El trabajador no tiene horarios registrados.", "Consulta vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDisponibilidad.DataSource = null;
                }
                else
                {
                    dgvDisponibilidad.DataSource = listaHorarios;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar horarios: " + ex.Message);
            }
        }
        private void dgvDisponibilidad_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvDisponibilidad.Rows[e.RowIndex];
                txtCodEmpleado.Text = fila.Cells["id_empleado"].Value.ToString();
                txtCodLote.Text = fila.Cells["id_lote"].Value.ToString();
                dtPickerRegInicio.Value = Convert.ToDateTime(fila.Cells["hora_inicio"].Value);
                dtPickerRegFin.Value = Convert.ToDateTime(fila.Cells["hora_fin"].Value);
            }
        }
    }
}
