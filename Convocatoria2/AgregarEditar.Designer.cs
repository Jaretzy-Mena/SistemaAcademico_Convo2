namespace SistemaRegistroAlumnos
{
    partial class FormAgregarEditar
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.RadioButton rbBecado;
        private System.Windows.Forms.RadioButton rbRegular;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;

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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.rbBecado = new System.Windows.Forms.RadioButton();
            this.rbRegular = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(20, 60);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad:";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(100, 60);
            this.nudEdad.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            this.nudEdad.Minimum = new decimal(new int[] { 6, 0, 0, 0 });
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(80, 20);
            this.nudEdad.TabIndex = 3;
            this.nudEdad.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(20, 100);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(37, 13);
            this.lblCurso.TabIndex = 4;
            this.lblCurso.Text = "Curso:";
            // 
            // cmbCurso
            // 
            this.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(100, 100);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(200, 21);
            this.cmbCurso.TabIndex = 5;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(20, 140);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado:";
            // 
            // rbBecado
            // 
            this.rbBecado.AutoSize = true;
            this.rbBecado.Location = new System.Drawing.Point(100, 140);
            this.rbBecado.Name = "rbBecado";
            this.rbBecado.Size = new System.Drawing.Size(62, 17);
            this.rbBecado.TabIndex = 7;
            this.rbBecado.TabStop = true;
            this.rbBecado.Text = "Becado";
            this.rbBecado.UseVisualStyleBackColor = true;
            // 
            // rbRegular
            // 
            this.rbRegular.AutoSize = true;
            this.rbRegular.Location = new System.Drawing.Point(180, 140);
            this.rbRegular.Name = "rbRegular";
            this.rbRegular.Size = new System.Drawing.Size(62, 17);
            this.rbRegular.TabIndex = 8;
            this.rbRegular.TabStop = true;
            this.rbRegular.Text = "Regular";
            this.rbRegular.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(100, 200);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 30);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(200, 200);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 30);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormAgregarEditar
            // 
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.rbRegular);
            this.Controls.Add(this.rbBecado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cmbCurso);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.nudEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "FormAgregarEditar";
            this.Text = "Agregar/Editar Alumno";
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
