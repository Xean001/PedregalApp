namespace PedregalApp
{
    partial class FormCategorizacion
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
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbClasificacion = new System.Windows.Forms.ComboBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoArbol = new System.Windows.Forms.TextBox();
            this.btnRegistrarFruto = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnInhabilitarFruto = new System.Windows.Forms.Button();
            this.btnEditarFruto = new System.Windows.Forms.Button();
            this.dgvFrutos = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(196, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(265, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Mantenedor de Categorizacion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboEmpleado);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbClasificacion);
            this.groupBox1.Controls.Add(this.txtPeso);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodigoArbol);
            this.groupBox1.Controls.Add(this.btnRegistrarFruto);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnInhabilitarFruto);
            this.groupBox1.Controls.Add(this.btnEditarFruto);
            this.groupBox1.Controls.Add(this.dgvFrutos);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 502);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Datos";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(164, 103);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(123, 20);
            this.txtCantidad.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Cantidad de frutos:";
            // 
            // cmbClasificacion
            // 
            this.cmbClasificacion.FormattingEnabled = true;
            this.cmbClasificacion.Location = new System.Drawing.Point(164, 140);
            this.cmbClasificacion.Name = "cmbClasificacion";
            this.cmbClasificacion.Size = new System.Drawing.Size(123, 21);
            this.cmbClasificacion.TabIndex = 37;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(164, 70);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(123, 20);
            this.txtPeso.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Codigo de Arbol:";
            // 
            // txtCodigoArbol
            // 
            this.txtCodigoArbol.Location = new System.Drawing.Point(164, 36);
            this.txtCodigoArbol.Name = "txtCodigoArbol";
            this.txtCodigoArbol.Size = new System.Drawing.Size(123, 20);
            this.txtCodigoArbol.TabIndex = 33;
            // 
            // btnRegistrarFruto
            // 
            this.btnRegistrarFruto.Location = new System.Drawing.Point(477, 27);
            this.btnRegistrarFruto.Name = "btnRegistrarFruto";
            this.btnRegistrarFruto.Size = new System.Drawing.Size(85, 36);
            this.btnRegistrarFruto.TabIndex = 31;
            this.btnRegistrarFruto.Text = "Registrar fruto";
            this.btnRegistrarFruto.UseVisualStyleBackColor = true;
            this.btnRegistrarFruto.Click += new System.EventHandler(this.btnRegistrarFruto_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(657, 12);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 35);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnInhabilitarFruto
            // 
            this.btnInhabilitarFruto.Location = new System.Drawing.Point(477, 124);
            this.btnInhabilitarFruto.Name = "btnInhabilitarFruto";
            this.btnInhabilitarFruto.Size = new System.Drawing.Size(85, 36);
            this.btnInhabilitarFruto.TabIndex = 30;
            this.btnInhabilitarFruto.Text = "Inhabilitar fruto";
            this.btnInhabilitarFruto.UseVisualStyleBackColor = true;
            this.btnInhabilitarFruto.Click += new System.EventHandler(this.btnInhabilitarFruto_Click);
            // 
            // btnEditarFruto
            // 
            this.btnEditarFruto.Location = new System.Drawing.Point(477, 74);
            this.btnEditarFruto.Name = "btnEditarFruto";
            this.btnEditarFruto.Size = new System.Drawing.Size(85, 36);
            this.btnEditarFruto.TabIndex = 29;
            this.btnEditarFruto.Text = "Editar fruto ";
            this.btnEditarFruto.UseVisualStyleBackColor = true;
            // 
            // dgvFrutos
            // 
            this.dgvFrutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrutos.Location = new System.Drawing.Point(22, 215);
            this.dgvFrutos.Name = "dgvFrutos";
            this.dgvFrutos.Size = new System.Drawing.Size(731, 229);
            this.dgvFrutos.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Elegir clasficacion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Insertar Peso :";
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(119, 177);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(178, 21);
            this.cboEmpleado.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Empleado:";
            // 
            // FormCategorizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 571);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCategorizacion";
            this.Text = "FormCategorizacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoArbol;
        private System.Windows.Forms.Button btnRegistrarFruto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnInhabilitarFruto;
        private System.Windows.Forms.Button btnEditarFruto;
        private System.Windows.Forms.DataGridView dgvFrutos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.ComboBox cmbClasificacion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboEmpleado;
    }
}