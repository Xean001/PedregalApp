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
    public partial class MantenedorContenedor : Form
    {
        public MantenedorContenedor()
        {
            InitializeComponent();
            listarBin();
            grupBoxDatos.Enabled = false;
            txtCodBin.Enabled = false;
            btnRealizaConsulta.Visible = false;
        }
        public void listarBin()
        {
            dgvBin.DataSource = logBin.Instancia.ListarBin();
        }
        private void LimpiarVariables()
        {
            txtPeso.Text = "";
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCodBin.Enabled = true;
            grupBoxDatos.Enabled = true;
            btnAgregar.Visible = true;
            LimpiarVariables();
            btnModificar.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodBin.Text))
            {
                MessageBox.Show("El campo Código Bin no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPeso.Text))
            {
                MessageBox.Show("El campo Peso (Kg) no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPeso.Text.Trim(), out decimal pesoKg))
            {
                MessageBox.Show("El campo Peso debe ser un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                entBin b = new entBin();
                b.codigoBin = txtCodBin.Text;
                b.pesoKg = decimal.Parse(txtPeso.Text.Trim());
                b.fecRegBin = dtPickerRegBin.Value;
                b.estadoBin = cbkEstadoBin.Checked;
                b.usoBin = cbkUsoBin.Checked;
                logBin.Instancia.InsertaBin(b);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarBin();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
            txtCodBin.Enabled = true;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodBin.Text))
            {
                MessageBox.Show("El campo Código Bin no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPeso.Text))
            {
                MessageBox.Show("El campo Peso (Kg) no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPeso.Text.Trim(), out decimal pesoKg))
            {
                MessageBox.Show("El campo Peso debe ser un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                entBin b = new entBin();
                b.codigoBin = txtCodBin.Text.Trim();
                b.pesoKg = decimal.Parse(txtPeso.Text.Trim());
                b.fecRegBin = dtPickerRegBin.Value;
                b.estadoBin = cbkEstadoBin.Checked;
                b.usoBin = cbkUsoBin.Checked;
                logBin.Instancia.EditaBin(b);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarBin();

        }

        private void dgvBin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvBin.Rows[e.RowIndex];
            txtCodBin.Text = filaActual.Cells[0].Value.ToString();
            txtPeso.Text = filaActual.Cells[1].Value.ToString();
            dtPickerRegBin.Text = filaActual.Cells[2].Value.ToString();
            cbkEstadoBin.Checked = Convert.ToBoolean(filaActual.Cells[3].Value);
            cbkUsoBin.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodBin.Text))
            {
                MessageBox.Show("El campo Código Bin no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewRow fila in dgvBin.Rows)
            {
                if (fila.Cells[0].Value.ToString() == txtCodBin.Text)
                {
                    bool estadoActual = Convert.ToBoolean(fila.Cells[3].Value); // estadoBin
                    if (!estadoActual)
                    {
                        MessageBox.Show("El Bin ya se encuentra deshabilitado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            try
            {
                entBin b = new entBin();

                b.codigoBin = txtCodBin.Text.Trim();
                cbkEstadoBin.Checked = false;
                logBin.Instancia.DeshabilitarBin(b);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarBin();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            btnRealizaConsulta.Visible = true;
            btnAgregar.Visible = false;
            btnModificar.Visible = false;
            txtCodBin.Enabled = true;
            grupBoxDatos.Enabled = true;
            cbkUsoBin.Enabled = false;
            cbkEstadoBin.Enabled = false;
        }

        private void btnRealizaConsulta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodBin.Text))
            {
                MessageBox.Show("Debe ingresar un Código Bin para buscar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                entBin b = new entBin();
                b.codigoBin = txtCodBin.Text.Trim();

                logBin.Instancia.BuscarBin(b); 

                txtPeso.Text = b.pesoKg.ToString();
                dtPickerRegBin.Value = b.fecRegBin;
                cbkEstadoBin.Checked = b.estadoBin;
                cbkUsoBin.Checked = b.usoBin;

                grupBoxDatos.Enabled = true;
                txtCodBin.Enabled = true;
                btnModificar.Visible = false;
                btnAgregar.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró el bin con ese código. " + ex.Message, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarVariables();
            }
        }
    }
}
