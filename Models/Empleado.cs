namespace Tarea___MVC.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Departamento { get; set; }
        public DateOnly FechaContratacion { get; set; }
    }
}
