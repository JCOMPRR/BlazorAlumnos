using BlazorAlumnos.Server.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorAlumnos.Server.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Materia> Materias { get; set; }
    }
}
