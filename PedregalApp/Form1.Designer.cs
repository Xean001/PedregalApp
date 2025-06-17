namespace PedregalApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuBotton = new System.Windows.Forms.PictureBox();
            this.monitoreoContainer = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSubMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMoniBiolo = new System.Windows.Forms.Button();
            this.controlCalidadContainer = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnControlCalidad = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.monitoreoTimer = new System.Windows.Forms.Timer(this.components);
            this.controlCalidadTimer = new System.Windows.Forms.Timer(this.components);
            this.sideBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBotton)).BeginInit();
            this.monitoreoContainer.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.controlCalidadContainer.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.IndianRed;
            this.sideBar.Controls.Add(this.panel1);
            this.sideBar.Controls.Add(this.monitoreoContainer);
            this.sideBar.Controls.Add(this.controlCalidadContainer);
            this.sideBar.Controls.Add(this.panel4);
            this.sideBar.Controls.Add(this.panel5);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.MaximumSize = new System.Drawing.Size(218, 450);
            this.sideBar.MinimumSize = new System.Drawing.Size(49, 450);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(218, 450);
            this.sideBar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuBotton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 123);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(47, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // menuBotton
            // 
            this.menuBotton.Image = ((System.Drawing.Image)(resources.GetObject("menuBotton.Image")));
            this.menuBotton.Location = new System.Drawing.Point(3, 3);
            this.menuBotton.Name = "menuBotton";
            this.menuBotton.Size = new System.Drawing.Size(38, 32);
            this.menuBotton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuBotton.TabIndex = 1;
            this.menuBotton.TabStop = false;
            this.menuBotton.Click += new System.EventHandler(this.menuBotton_Click);
            // 
            // monitoreoContainer
            // 
            this.monitoreoContainer.BackColor = System.Drawing.Color.IndianRed;
            this.monitoreoContainer.Controls.Add(this.panel6);
            this.monitoreoContainer.Controls.Add(this.panel2);
            this.monitoreoContainer.Location = new System.Drawing.Point(3, 132);
            this.monitoreoContainer.MaximumSize = new System.Drawing.Size(218, 106);
            this.monitoreoContainer.MinimumSize = new System.Drawing.Size(218, 55);
            this.monitoreoContainer.Name = "monitoreoContainer";
            this.monitoreoContainer.Size = new System.Drawing.Size(218, 55);
            this.monitoreoContainer.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnSubMenu);
            this.panel6.Location = new System.Drawing.Point(0, 57);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(218, 48);
            this.panel6.TabIndex = 4;
            // 
            // btnSubMenu
            // 
            this.btnSubMenu.BackColor = System.Drawing.Color.Salmon;
            this.btnSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubMenu.Location = new System.Drawing.Point(-25, -7);
            this.btnSubMenu.Name = "btnSubMenu";
            this.btnSubMenu.Size = new System.Drawing.Size(243, 60);
            this.btnSubMenu.TabIndex = 3;
            this.btnSubMenu.Text = "SubMenu";
            this.btnSubMenu.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMoniBiolo);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 48);
            this.panel2.TabIndex = 1;
            // 
            // btnMoniBiolo
            // 
            this.btnMoniBiolo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoniBiolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoniBiolo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMoniBiolo.Location = new System.Drawing.Point(-19, -3);
            this.btnMoniBiolo.MinimumSize = new System.Drawing.Size(237, 64);
            this.btnMoniBiolo.Name = "btnMoniBiolo";
            this.btnMoniBiolo.Size = new System.Drawing.Size(237, 64);
            this.btnMoniBiolo.TabIndex = 3;
            this.btnMoniBiolo.Text = "Monitoreo Biologico";
            this.btnMoniBiolo.UseVisualStyleBackColor = true;
            this.btnMoniBiolo.Click += new System.EventHandler(this.btnMoniBiolo_Click);
            // 
            // controlCalidadContainer
            // 
            this.controlCalidadContainer.Controls.Add(this.panel9);
            this.controlCalidadContainer.Controls.Add(this.panel10);
            this.controlCalidadContainer.Controls.Add(this.panel8);
            this.controlCalidadContainer.Controls.Add(this.panel3);
            this.controlCalidadContainer.Location = new System.Drawing.Point(3, 193);
            this.controlCalidadContainer.MaximumSize = new System.Drawing.Size(218, 194);
            this.controlCalidadContainer.MinimumSize = new System.Drawing.Size(218, 46);
            this.controlCalidadContainer.Name = "controlCalidadContainer";
            this.controlCalidadContainer.Size = new System.Drawing.Size(218, 46);
            this.controlCalidadContainer.TabIndex = 6;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Salmon;
            this.panel9.Controls.Add(this.button6);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 144);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(218, 48);
            this.panel9.TabIndex = 9;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(-15, -14);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(243, 64);
            this.button6.TabIndex = 8;
            this.button6.Text = "Caida de fruta";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Salmon;
            this.panel10.Controls.Add(this.button5);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 96);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(218, 48);
            this.panel10.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(-12, -10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(243, 64);
            this.button5.TabIndex = 7;
            this.button5.Text = "Categorizacion";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Salmon;
            this.panel8.Controls.Add(this.button2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 48);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(218, 48);
            this.panel8.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(-11, -10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 64);
            this.button2.TabIndex = 4;
            this.button2.Text = "Conteo de Fruta";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.IndianRed;
            this.panel3.Controls.Add(this.btnControlCalidad);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 48);
            this.panel3.TabIndex = 5;
            // 
            // btnControlCalidad
            // 
            this.btnControlCalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControlCalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlCalidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnControlCalidad.Location = new System.Drawing.Point(-11, -7);
            this.btnControlCalidad.Name = "btnControlCalidad";
            this.btnControlCalidad.Size = new System.Drawing.Size(243, 64);
            this.btnControlCalidad.TabIndex = 4;
            this.btnControlCalidad.Text = "Control de Calidad";
            this.btnControlCalidad.UseVisualStyleBackColor = true;
            this.btnControlCalidad.Click += new System.EventHandler(this.btnControlCalidad_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button4);
            this.panel4.Location = new System.Drawing.Point(3, 245);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(218, 48);
            this.panel4.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(-14, -5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(243, 64);
            this.button4.TabIndex = 7;
            this.button4.Text = "Cosecha y recepcion";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button3);
            this.panel5.Location = new System.Drawing.Point(3, 299);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(218, 48);
            this.panel5.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(-17, -9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(243, 64);
            this.button3.TabIndex = 6;
            this.button3.Text = "Empaque ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Interval = 10;
            this.sideBarTimer.Tick += new System.EventHandler(this.sideBarTimer_Tick);
            // 
            // monitoreoTimer
            // 
            this.monitoreoTimer.Interval = 10;
            this.monitoreoTimer.Tick += new System.EventHandler(this.monitoreoTimer_Tick);
            // 
            // controlCalidadTimer
            // 
            this.controlCalidadTimer.Interval = 10;
            this.controlCalidadTimer.Tick += new System.EventHandler(this.controlCalidadTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sideBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.sideBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBotton)).EndInit();
            this.monitoreoContainer.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.controlCalidadContainer.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMoniBiolo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnControlCalidad;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox menuBotton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sideBarTimer;
        private System.Windows.Forms.Panel monitoreoContainer;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnSubMenu;
        private System.Windows.Forms.Timer monitoreoTimer;
        private System.Windows.Forms.Panel controlCalidadContainer;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer controlCalidadTimer;
    }
}

