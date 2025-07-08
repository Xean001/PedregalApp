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
    public partial class FormCategorizacion : Form
    {
        public FormCategorizacion()
        {
            InitializeComponent();
            CargarClasificaciones();
            CargarEmpleados();
        }
        private void CargarEmpleados()
        {
            cboEmpleado.DataSource = logEmpleado.Instancia.ListarEmpleados();
            cboEmpleado.DisplayMember = "nombre";
            cboEmpleado.ValueMember = "id_empleado";
        }

        private void CargarClasificaciones()
        {
            try
            {
                List<entClasificacion> clasificaciones = logClasificacion.Instancia.ListarClasificaciones();
                cmbClasificacion.DataSource = clasificaciones;
                cmbClasificacion.DisplayMember = "nombre";
                cmbClasificacion.ValueMember = "id_clasificacion";
                cmbClasificacion.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clasificaciones: " + ex.Message);
            }
        }


        private int ObtenerIdArbolPorCodigo(string codigo)
        {
            entArbolMostrar arbol = logArbol.Instancia.BuscarArbolPorCodigo(codigo);
            if (arbol != null)
                return arbol.id_arbol;
            else
                return -1;
        }
        private void btnRegistrarFruto_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigoArbol.Text.Trim();
                if (string.IsNullOrEmpty(codigo))
                {
                    MessageBox.Show("Ingrese el código del árbol.");
                    return;
                }

                entArbolMostrar arbol = logArbol.Instancia.BuscarArbolPorCodigo(codigo);
                if (arbol == null)
                {
                    MessageBox.Show("Árbol no encontrado.");
                    return;
                }

                if (!decimal.TryParse(txtPeso.Text.Trim(), out decimal peso) || peso <= 0)
                {
                    MessageBox.Show("Ingrese un peso válido.");
                    return;
                }

                if (!int.TryParse(txtCantidad.Text.Trim(), out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida.");
                    return;
                }

                if (cmbClasificacion.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione la clasificación.");
                    return;
                }

                if (cboEmpleado.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione el empleado responsable.");
                    return;
                }

                string clasificacion = cmbClasificacion.Text;
                int idEmpleado = Convert.ToInt32(cboEmpleado.SelectedValue);

                entFruto fruto = new entFruto
                {
                    id_arbol = arbol.id_arbol,
                    id_empleado = idEmpleado,
                    peso = peso,
                    clasificacion = clasificacion,
                    cantidad = cantidad

                };

                bool insertado = logFruto.Instancia.InsertarFruto(fruto);
                if (insertado)
                {
                    MessageBox.Show("Fruto registrado correctamente.");
                    ListarFrutosPorArbol(arbol.id_arbol);
                    LimpiarCamposFruto();
                }
                else
                {
                    MessageBox.Show("Error al registrar el fruto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ListarFrutosPorArbol(int idArbol)
        {
            dgvFrutos.DataSource = logFruto.Instancia.ListarFrutosPorArbol(idArbol);

            // Opcional: personalizar columnas
            dgvFrutos.Columns["peso"].HeaderText = "Peso (g)";
            dgvFrutos.Columns["clasificacion"].HeaderText = "Clasificación";
            dgvFrutos.Columns["calibre"].HeaderText = "Calibre";
            dgvFrutos.Columns["cantidad"].HeaderText = "Cantidad";
            dgvFrutos.Columns["empleado"].HeaderText = "Empleado";
            {


                // Ocultar columnas no deseadas
                if (dgvFrutos.Columns.Contains("id_arbol"))
                    dgvFrutos.Columns["id_arbol"].Visible = false;

               

                if (dgvFrutos.Columns.Contains("id_empleado"))
                    dgvFrutos.Columns["id_empleado"].Visible = false;

                // Renombrar encabezados si deseas
                if (dgvFrutos.Columns.Contains("peso"))
                    dgvFrutos.Columns["peso"].HeaderText = "Peso (g)";

                if (dgvFrutos.Columns.Contains("clasificacion"))
                    dgvFrutos.Columns["clasificacion"].HeaderText = "Clasificación";

                if (dgvFrutos.Columns.Contains("calibre"))
                    dgvFrutos.Columns["calibre"].HeaderText = "Calibre";

                if (dgvFrutos.Columns.Contains("cantidad"))
                    dgvFrutos.Columns["cantidad"].HeaderText = "Cantidad";

                if (dgvFrutos.Columns.Contains("empleado"))
                    dgvFrutos.Columns["empleado"].HeaderText = "Empleado";
            }

        }
        private void ListarFrutosEnGrid(int id_arbol)
        {
            dgvFrutos.DataSource = logFruto.Instancia.ListarFrutosPorArbol(id_arbol);

            // Ocultar columnas técnicas
            if (dgvFrutos.Columns.Contains("id_fruto"))
                dgvFrutos.Columns["id_fruto"].Visible = false;

            if (dgvFrutos.Columns.Contains("id_arbol"))
                dgvFrutos.Columns["id_arbol"].Visible = false;

            if (dgvFrutos.Columns.Contains("id_empleado"))
                dgvFrutos.Columns["id_empleado"].Visible = false;
        }


        private void LimpiarCamposFruto()
        {
            txtCodigoArbol.Clear();
            txtPeso.Clear();
            txtCantidad.Clear();
            cmbClasificacion.SelectedIndex = -1;
        }

        private int obtenerIdArbolActual()
        {
            string codigo = txtCodigoArbol.Text.Trim();
            if (string.IsNullOrEmpty(codigo)) return -1;

            entArbolMostrar arbol = logArbol.Instancia.BuscarArbolPorCodigo(codigo);
            if (arbol != null)
                return arbol.id_arbol;
            else
                return -1;
        }


        private void btnInhabilitarFruto_Click(object sender, EventArgs e)
        {

            if (dgvFrutos.CurrentRow != null)
            {
                int index = dgvFrutos.CurrentRow.Index;

                
                int id_fruto = Convert.ToInt32(dgvFrutos.Rows[index].Cells["id_fruto"].Value);

                var confirm = MessageBox.Show("¿Estás seguro de inhabilitar este fruto?", "Confirmación", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    bool ok = logFruto.Instancia.InhabilitarFruto(id_fruto);
                    if (ok)
                    {
                        MessageBox.Show("Fruto inhabilitado.");
                        ListarFrutosEnGrid(obtenerIdArbolActual());
                    }
                    else
                    {
                        MessageBox.Show("No se pudo inhabilitar el fruto.");
                    }
                }
            }
        }
    }
}




