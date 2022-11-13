using System.ComponentModel.DataAnnotations;

namespace BlazorAlumnos.Server.Model.Entities
{
    public class Alumno
    {
        public int Id { get; set; }
        
        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Matricula { get; set; }
    }
}
