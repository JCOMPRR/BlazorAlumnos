using System.ComponentModel.DataAnnotations;

namespace BlazorAlumnos.Server.Model.Entities
{
    public class Materia
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

    }

}
