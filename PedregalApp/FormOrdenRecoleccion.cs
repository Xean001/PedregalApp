using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace PedregalApp
{
    public partial class FormOrdenRecoleccion : Form
    {
        public FormOrdenRecoleccion()
        {
            InitializeComponent();
            listarOrdenes();
        }
        private void listarOrdenes()
        {
            try
            {
                dgvOrden.DataSource = logOrdenRecoleccion.Instancia.ListarOrdenes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar órdenes: " + ex.Message);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodOrden.Text) || string.IsNullOrWhiteSpace(txtEmpleado.Text) || string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtEmpleado.Text.Trim(), out int idEmpleado) || !int.TryParse(txtCantidad.Text.Trim(), out int cantidadEstimada))
            {
                MessageBox.Show("Empleado y Cantidad deben ser números válidos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                entOrdenRecoleccion orden = new entOrdenRecoleccion();
                orden.codigoOrden = txtCodOrden.Text.Trim();
                orden.fechaRecoleccion = dtPickerRegOrden.Value;
                orden.idEmpleado = idEmpleado;
                orden.cantidadEstimada = cantidadEstimada;

                logOrdenRecoleccion.Instancia.InsertarOrden(orden);

                MessageBox.Show("Orden registrada con éxito.");
                listarOrdenes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar orden: " + ex.Message);
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodOrden.Text))
            {
                MessageBox.Show("Ingrese el ID de la orden que desea anular.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCodOrden.Text.Trim(), out int idOrden))
            {
                MessageBox.Show("El ID de orden debe ser un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool exito = logOrdenRecoleccion.Instancia.AnularOrden(idOrden);
                if (exito)
                {
                    MessageBox.Show("Orden anulada correctamente.");
                    listarOrdenes();
                }
                else
                {
                    MessageBox.Show("No se pudo anular la orden. Verifique si el ID existe y está activa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al anular la orden: " + ex.Message);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodOrden.Text.Trim(), out int idOrden))
            {
                MessageBox.Show("Ingrese un ID de orden válido.");
                return;
            }

            try
            {
                entOrdenRecoleccion orden = logOrdenRecoleccion.Instancia.BuscarOrdenPorId(idOrden);
                if (orden != null)
                {
                    // Mostrar en controles
                    txtCodOrden.Text = orden.idOrden.ToString();
                    txtCantidad.Text = orden.cantidadEstimada.ToString();
                    txtEmpleado.Text = orden.idEmpleado.ToString();
                    dtPickerRegOrden.Value = orden.fechaRecoleccion;
                }
                else
                {
                    MessageBox.Show("No se encontró una orden con ese ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar: " + ex.Message);
            }
        }
        private void dgvOrden_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvOrden.Rows[e.RowIndex];
                txtCodOrden.Text = fila.Cells["codigoOrden"].Value.ToString();
                txtEmpleado.Text = fila.Cells["idEmpleado"].Value.ToString();
                txtCantidad.Text = fila.Cells["cantidadEstimada"].Value.ToString();
                dtPickerRegOrden.Value = Convert.ToDateTime(fila.Cells["fechaRecoleccion"].Value);
            }
        }
    }
}
