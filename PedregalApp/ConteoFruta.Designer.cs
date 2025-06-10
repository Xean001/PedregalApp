namespace PedregalApp
{
    partial class ConteoFruta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCortina = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbLinea = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalFrutos = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnMostrarConteos = new System.Windows.Forms.Button();
            this.cmbArbol = new System.Windows.Forms.ComboBox();
            this.cmbLote = new System.Windows.Forms.ComboBox();
            this.cmbTrabajador = new System.Windows.Forms.ComboBox();
            this.dgvConteos = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConteos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONTEO DE FRUTA :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "  REGISTRO DE ACTIVIDAD AGRÍCOLA  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(14, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lote:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(116, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cortina:";
            // 
            // cmbCortina
            // 
            this.cmbCortina.FormattingEnabled = true;
            this.cmbCortina.Location = new System.Drawing.Point(180, 85);
            this.cmbCortina.Name = "cmbCortina";
            this.cmbCortina.Size = new System.Drawing.Size(82, 21);
            this.cmbCortina.TabIndex = 5;
            this.cmbCortina.SelectedIndexChanged += new System.EventHandler(this.cmbCortina_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(14, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Linea:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(116, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Arbol:";
            // 
            // cmbLinea
            // 
            this.cmbLinea.FormattingEnabled = true;
            this.cmbLinea.Location = new System.Drawing.Point(60, 123);
            this.cmbLinea.Name = "cmbLinea";
            this.cmbLinea.Size = new System.Drawing.Size(43, 21);
            this.cmbLinea.TabIndex = 8;
            this.cmbLinea.SelectedIndexChanged += new System.EventHandler(this.cmbLinea_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(16, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = " Nombre del trabajador:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(307, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Frutos contados:";
            // 
            // txtTotalFrutos
            // 
            this.txtTotalFrutos.Location = new System.Drawing.Point(427, 83);
            this.txtTotalFrutos.Name = "txtTotalFrutos";
            this.txtTotalFrutos.Size = new System.Drawing.Size(43, 20);
            this.txtTotalFrutos.TabIndex = 13;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(518, 51);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(122, 52);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar Registro";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnMostrarConteos
            // 
            this.btnMostrarConteos.Location = new System.Drawing.Point(518, 123);
            this.btnMostrarConteos.Name = "btnMostrarConteos";
            this.btnMostrarConteos.Size = new System.Drawing.Size(122, 52);
            this.btnMostrarConteos.TabIndex = 15;
            this.btnMostrarConteos.Text = "Consultar registros";
            this.btnMostrarConteos.UseVisualStyleBackColor = true;
            this.btnMostrarConteos.Click += new System.EventHandler(this.btnMostrarConteos_Click);
            // 
            // cmbArbol
            // 
            this.cmbArbol.FormattingEnabled = true;
            this.cmbArbol.Location = new System.Drawing.Point(180, 123);
            this.cmbArbol.Name = "cmbArbol";
            this.cmbArbol.Size = new System.Drawing.Size(43, 21);
            this.cmbArbol.TabIndex = 16;
            // 
            // cmbLote
            // 
            this.cmbLote.FormattingEnabled = true;
            this.cmbLote.Location = new System.Drawing.Point(60, 89);
            this.cmbLote.Name = "cmbLote";
            this.cmbLote.Size = new System.Drawing.Size(43, 21);
            this.cmbLote.TabIndex = 17;
            this.cmbLote.SelectedIndexChanged += new System.EventHandler(this.cmbLote_SelectedIndexChanged);
            // 
            // cmbTrabajador
            // 
            this.cmbTrabajador.FormattingEnabled = true;
            this.cmbTrabajador.Location = new System.Drawing.Point(199, 182);
            this.cmbTrabajador.Name = "cmbTrabajador";
            this.cmbTrabajador.Size = new System.Drawing.Size(222, 21);
            this.cmbTrabajador.TabIndex = 18;
            // 
            // dgvConteos
            // 
            this.dgvConteos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConteos.Location = new System.Drawing.Point(17, 258);
            this.dgvConteos.Name = "dgvConteos";
            this.dgvConteos.Size = new System.Drawing.Size(639, 150);
            this.dgvConteos.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(25, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Mostrar consultas:";
            // 
            // ConteoFruta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvConteos);
            this.Controls.Add(this.cmbTrabajador);
            this.Controls.Add(this.cmbLote);
            this.Controls.Add(this.cmbArbol);
            this.Controls.Add(this.btnMostrarConteos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtTotalFrutos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbLinea);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCortina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConteoFruta";
            this.Text = "ConteoFruta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConteos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCortina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbLinea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalFrutos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnMostrarConteos;
        private System.Windows.Forms.ComboBox cmbArbol;
        private System.Windows.Forms.ComboBox cmbLote;
        private System.Windows.Forms.ComboBox cmbTrabajador;
        private System.Windows.Forms.DataGridView dgvConteos;
        private System.Windows.Forms.Label label9;
    }
}