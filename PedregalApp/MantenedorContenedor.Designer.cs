namespace PedregalApp
{
    partial class MantenedorContenedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvBin = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.grupBoxDatos = new System.Windows.Forms.GroupBox();
            this.txtCodBin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbkUsoBin = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.dtPickerRegBin = new System.Windows.Forms.DateTimePicker();
            this.cbkEstadoBin = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRealizaConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBin)).BeginInit();
            this.grupBoxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBin
            // 
            this.dgvBin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBin.Location = new System.Drawing.Point(12, 12);
            this.dgvBin.Name = "dgvBin";
            this.dgvBin.ReadOnly = true;
            this.dgvBin.Size = new System.Drawing.Size(615, 213);
            this.dgvBin.TabIndex = 0;
            this.dgvBin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBin_CellClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(650, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(129, 42);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(650, 67);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(129, 42);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(650, 125);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(129, 42);
            this.btnDeshabilitar.TabIndex = 3;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(650, 183);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(129, 42);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // grupBoxDatos
            // 
            this.grupBoxDatos.Controls.Add(this.txtCodBin);
            this.grupBoxDatos.Controls.Add(this.label3);
            this.grupBoxDatos.Controls.Add(this.cbkUsoBin);
            this.grupBoxDatos.Controls.Add(this.btnCancelar);
            this.grupBoxDatos.Controls.Add(this.btnModificar);
            this.grupBoxDatos.Controls.Add(this.btnAgregar);
            this.grupBoxDatos.Controls.Add(this.txtPeso);
            this.grupBoxDatos.Controls.Add(this.dtPickerRegBin);
            this.grupBoxDatos.Controls.Add(this.cbkEstadoBin);
            this.grupBoxDatos.Controls.Add(this.label2);
            this.grupBoxDatos.Controls.Add(this.label1);
            this.grupBoxDatos.Controls.Add(this.btnRealizaConsulta);
            this.grupBoxDatos.Location = new System.Drawing.Point(12, 263);
            this.grupBoxDatos.Name = "grupBoxDatos";
            this.grupBoxDatos.Size = new System.Drawing.Size(615, 158);
            this.grupBoxDatos.TabIndex = 5;
            this.grupBoxDatos.TabStop = false;
            this.grupBoxDatos.Text = "Datos contenedor";
            // 
            // txtCodBin
            // 
            this.txtCodBin.Location = new System.Drawing.Point(114, 20);
            this.txtCodBin.Name = "txtCodBin";
            this.txtCodBin.Size = new System.Drawing.Size(100, 20);
            this.txtCodBin.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Codigo Bin";
            // 
            // cbkUsoBin
            // 
            this.cbkUsoBin.AutoSize = true;
            this.cbkUsoBin.Location = new System.Drawing.Point(171, 121);
            this.cbkUsoBin.Name = "cbkUsoBin";
            this.cbkUsoBin.Size = new System.Drawing.Size(73, 17);
            this.cbkUsoBin.TabIndex = 8;
            this.cbkUsoBin.Text = "Bin usado";
            this.cbkUsoBin.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(444, 102);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(152, 31);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(444, 65);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(152, 31);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(444, 25);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(152, 31);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(114, 89);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(200, 20);
            this.txtPeso.TabIndex = 4;
            // 
            // dtPickerRegBin
            // 
            this.dtPickerRegBin.Location = new System.Drawing.Point(114, 51);
            this.dtPickerRegBin.Name = "dtPickerRegBin";
            this.dtPickerRegBin.Size = new System.Drawing.Size(200, 20);
            this.dtPickerRegBin.TabIndex = 3;
            // 
            // cbkEstadoBin
            // 
            this.cbkEstadoBin.AutoSize = true;
            this.cbkEstadoBin.Location = new System.Drawing.Point(25, 121);
            this.cbkEstadoBin.Name = "cbkEstadoBin";
            this.cbkEstadoBin.Size = new System.Drawing.Size(77, 17);
            this.cbkEstadoBin.TabIndex = 2;
            this.cbkEstadoBin.Text = "Estado Bin";
            this.cbkEstadoBin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peso (KG)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha registro";
            // 
            // btnRealizaConsulta
            // 
            this.btnRealizaConsulta.Location = new System.Drawing.Point(444, 25);
            this.btnRealizaConsulta.Name = "btnRealizaConsulta";
            this.btnRealizaConsulta.Size = new System.Drawing.Size(152, 31);
            this.btnRealizaConsulta.TabIndex = 11;
            this.btnRealizaConsulta.Text = "Realizar consulta";
            this.btnRealizaConsulta.UseVisualStyleBackColor = true;
            this.btnRealizaConsulta.Click += new System.EventHandler(this.btnRealizaConsulta_Click);
            // 
            // MantenedorContenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grupBoxDatos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvBin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MantenedorContenedor";
            this.Text = "MantenedorContenedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBin)).EndInit();
            this.grupBoxDatos.ResumeLayout(false);
            this.grupBoxDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBin;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox grupBoxDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.DateTimePicker dtPickerRegBin;
        private System.Windows.Forms.CheckBox cbkEstadoBin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbkUsoBin;
        private System.Windows.Forms.TextBox txtCodBin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRealizaConsulta;
    }
}