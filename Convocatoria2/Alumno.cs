namespace SistemaRegistroAlumnos
{
    public class Alumno
    {
        // Propiedades que describen a un alumno
        public string Nombre { get; set; } // Nombre completo del alumno
        public int Edad { get; set; } // Edad del alumno
        public string Curso { get; set; } // Curso actual (Primero, Segundo, etc.)
        public string Estado { get; set; } // Estado: Becado o Regular
    }
}
