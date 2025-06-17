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
            btnModificar.Enabled = true;
            btnAgregar.Visible = false;
            txtCodBin.Enabled = true;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
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
    }
}
