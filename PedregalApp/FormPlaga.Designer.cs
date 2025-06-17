namespace PedregalApp
{
    partial class FormPlaga
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
            this.txtNombrePlaga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbkHabilitado = new System.Windows.Forms.CheckBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cmbTipoPlaga = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgvPlagas = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlagas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombrePlaga
            // 
            this.txtNombrePlaga.Location = new System.Drawing.Point(16, 58);
            this.txtNombrePlaga.Name = "txtNombrePlaga";
            this.txtNombrePlaga.Size = new System.Drawing.Size(184, 22);
            this.txtNombrePlaga.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(503, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "PLAGAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre plaga";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.cmbTipoPlaga);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombrePlaga);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 382);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de plaga";
            // 
            // cbkHabilitado
            // 
            this.cbkHabilitado.AutoSize = true;
            this.cbkHabilitado.Location = new System.Drawing.Point(175, 477);
            this.cbkHabilitado.Name = "cbkHabilitado";
            this.cbkHabilitado.Size = new System.Drawing.Size(91, 20);
            this.cbkHabilitado.TabIndex = 8;
            this.cbkHabilitado.Text = "Habilitado";
            this.cbkHabilitado.UseVisualStyleBackColor = true;
            this.cbkHabilitado.CheckedChanged += new System.EventHandler(this.cbkHabilitado_CheckedChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(18, 111);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(184, 142);
            this.txtDescripcion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de plaga";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(251, 309);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(141, 53);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cmbTipoPlaga
            // 
            this.cmbTipoPlaga.FormattingEnabled = true;
            this.cmbTipoPlaga.Items.AddRange(new object[] {
            "Insecto",
            "Hongo",
            "Bacteria"});
            this.cmbTipoPlaga.Location = new System.Drawing.Point(251, 56);
            this.cmbTipoPlaga.Name = "cmbTipoPlaga";
            this.cmbTipoPlaga.Size = new System.Drawing.Size(184, 24);
            this.cmbTipoPlaga.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(18, 309);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(141, 53);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgvPlagas
            // 
            this.dgvPlagas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlagas.Location = new System.Drawing.Point(506, 52);
            this.dgvPlagas.Name = "dgvPlagas";
            this.dgvPlagas.RowHeadersWidth = 51;
            this.dgvPlagas.RowTemplate.Height = 24;
            this.dgvPlagas.Size = new System.Drawing.Size(549, 479);
            this.dgvPlagas.TabIndex = 12;
            this.dgvPlagas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlagas_CellContentClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 500);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 31);
            this.button5.TabIndex = 15;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(158, 504);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 27);
            this.panel1.TabIndex = 16;
            // 
            // FormPlaga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbkHabilitado);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dgvPlagas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormPlaga";
            this.Text = "CrudPlaga";
            this.Load += new System.EventHandler(this.FormPlaga_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlagas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombrePlaga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoPlaga;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.CheckBox cbkHabilitado;
        private System.Windows.Forms.DataGridView dgvPlagas;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}