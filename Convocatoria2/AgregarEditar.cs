using System;
using System.Windows.Forms;

namespace SistemaRegistroAlumnos
{
    public partial class FormAgregarEditar : Form
    {
        public Alumno Alumno { get; private set; }

        public FormAgregarEditar()
        {
            InitializeComponent();
            InicializarFormulario();
        }

        private void InicializarFormulario()
        {
            // Opciones de cursos
            cmbCurso.Items.AddRange(new string[] { "Primero", "Segundo", "Tercero" });
            cmbCurso.SelectedIndex = 0; // Selección por defecto
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar campos
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nudEdad.Value < 6 || nudEdad.Value > 30)
            {
                MessageBox.Show("La edad debe estar entre 6 y 30 años.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear el objeto Alumno
            Alumno = new Alumno
            {
                Nombre = txtNombre.Text,
                Edad = (int)nudEdad.Value,
                Curso = cmbCurso.SelectedItem.ToString(),
                Estado = rbBecado.Checked ? "Becado" : "Regular"
            };

            DialogResult = DialogResult.OK; // Indica éxito
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // Cancela la operación
            Close();
        }
    }
}

