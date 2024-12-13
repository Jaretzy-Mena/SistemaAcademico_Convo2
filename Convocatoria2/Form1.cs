using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaRegistroAlumnos
{
    public partial class FormPrincipal : Form
    {
        private List<Alumno> alumnos = new List<Alumno>();

        public FormPrincipal()
        {
            InitializeComponent();
            CargarAlumnosIniciales();
            ActualizarTabla();
        }

        private void CargarAlumnosIniciales()
        {
            alumnos.Add(new Alumno { Nombre = "Carlos López", Edad = 15, Curso = "Primero", Estado = "Becado" });
            alumnos.Add(new Alumno { Nombre = "María Fernández", Edad = 17, Curso = "Segundo", Estado = "Regular" });
        }

        private void ActualizarTabla()
        {
            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = alumnos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var form = new FormAgregarEditar();
            if (form.ShowDialog() == DialogResult.OK)
            {
                alumnos.Add(form.Alumno);
                ActualizarTabla();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count > 0)
            {
                var alumnoSeleccionado = dgvAlumnos.SelectedRows[0].DataBoundItem as Alumno;
                alumnos.Remove(alumnoSeleccionado);
                ActualizarTabla();
            }
            else
            {
                MessageBox.Show("Selecciona un alumno para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            var promedioEdad = alumnos.Average(a => a.Edad);
            var totalPorCurso = alumnos.GroupBy(a => a.Curso).ToDictionary(g => g.Key, g => g.Count());
            var porcentajeBecados = (double)alumnos.Count(a => a.Estado == "Becado") / alumnos.Count * 100;

            string estadisticas = $"Promedio de edad: {promedioEdad:F2}\n" +
                                  "Total por curso:\n" +
                                  string.Join("\n", totalPorCurso.Select(c => $"{c.Key}: {c.Value}")) +
                                  $"\nPorcentaje de becados: {porcentajeBecados:F2}%";

            MessageBox.Show(estadisticas, "Estadísticas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
