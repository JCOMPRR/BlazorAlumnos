using System.ComponentModel.DataAnnotations;

namespace BlazorAlumnos.Shared.DTOs.Alumnos
{
    public class AlumnoDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Nombre { get; set; }
        
        [Required]
        public string Matricula { get; set; }
    }
}
