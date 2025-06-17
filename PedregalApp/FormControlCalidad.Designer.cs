namespace PedregalApp
{
    partial class FormControlCalidad
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnNuevo1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.cmbLote = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cmbLinea = new System.Windows.Forms.ComboBox();
            this.cmbCortina = new System.Windows.Forms.ComboBox();
            this.cmbArbol = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(652, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 36);
            this.button3.TabIndex = 19;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(652, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 36);
            this.button2.TabIndex = 18;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(652, 71);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(85, 36);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(652, 372);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(123, 43);
            this.btnDeshabilitar.TabIndex = 16;
            this.btnDeshabilitar.Text = "Deshabilitar Prov.";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(652, 298);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(123, 43);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(652, 228);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(123, 43);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnNuevo1
            // 
            this.btnNuevo1.Location = new System.Drawing.Point(652, 29);
            this.btnNuevo1.Name = "btnNuevo1";
            this.btnNuevo1.Size = new System.Drawing.Size(85, 36);
            this.btnNuevo1.TabIndex = 13;
            this.btnNuevo1.Text = "Nuevo";
            this.btnNuevo1.UseVisualStyleBackColor = true;
            this.btnNuevo1.Click += new System.EventHandler(this.btnNuevo1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbArbol);
            this.groupBox1.Controls.Add(this.cmbCortina);
            this.groupBox1.Controls.Add(this.cmbLinea);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbLote);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbEmpleado);
            this.groupBox1.Location = new System.Drawing.Point(26, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 222);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Datos";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(363, 115);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(174, 20);
            this.dtpFecha.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(201, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cortina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Empleado a cargo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Linea:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arbol:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lote:";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(158, 115);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cmbEmpleado.TabIndex = 1;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(26, 19);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(600, 185);
            this.dgvDatos.TabIndex = 11;
            // 
            // cmbLote
            // 
            this.cmbLote.FormattingEnabled = true;
            this.cmbLote.Location = new System.Drawing.Point(53, 30);
            this.cmbLote.Name = "cmbLote";
            this.cmbLote.Size = new System.Drawing.Size(121, 21);
            this.cmbLote.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(373, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cantidad de frutos:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(516, 31);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(55, 20);
            this.txtCantidad.TabIndex = 16;
            // 
            // cmbLinea
            // 
            this.cmbLinea.FormattingEnabled = true;
            this.cmbLinea.Location = new System.Drawing.Point(53, 65);
            this.cmbLinea.Name = "cmbLinea";
            this.cmbLinea.Size = new System.Drawing.Size(121, 21);
            this.cmbLinea.TabIndex = 17;
            // 
            // cmbCortina
            // 
            this.cmbCortina.FormattingEnabled = true;
            this.cmbCortina.Location = new System.Drawing.Point(257, 29);
            this.cmbCortina.Name = "cmbCortina";
            this.cmbCortina.Size = new System.Drawing.Size(91, 21);
            this.cmbCortina.TabIndex = 18;
            // 
            // cmbArbol
            // 
            this.cmbArbol.FormattingEnabled = true;
            this.cmbArbol.Location = new System.Drawing.Point(257, 64);
            this.cmbArbol.Name = "cmbArbol";
            this.cmbArbol.Size = new System.Drawing.Size(91, 21);
            this.cmbArbol.TabIndex = 19;
            // 
            // FormControlCalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnNuevo1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDatos);
            this.Name = "FormControlCalidad";
            this.Text = "FormControlCalidad";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnNuevo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.ComboBox cmbLote;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbArbol;
        private System.Windows.Forms.ComboBox cmbCortina;
        private System.Windows.Forms.ComboBox cmbLinea;
    }
}