namespace SistemaRegistroAlumnos
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.DataGridView dgvAlumnos;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelLateral.Controls.Add(this.btnAgregar);
            this.panelLateral.Controls.Add(this.btnEliminar);
            this.panelLateral.Controls.Add(this.btnEstadisticas);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(150, 450);
            this.panelLateral.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 50);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 40);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Alumno";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(12, 110);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 40);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar Alumno";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Location = new System.Drawing.Point(12, 170);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(120, 40);
            this.btnEstadisticas.TabIndex = 2;
            this.btnEstadisticas.Text = "Ver Estadísticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(160, 12);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.Size = new System.Drawing.Size(628, 426);
            this.dgvAlumnos.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.panelLateral);
            this.Name = "FormPrincipal";
            this.Text = "Sistema de Registro de Alumnos";
            this.panelLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);

        }
    }
}

