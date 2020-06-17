using Microsoft.EntityFrameworkCore;
using Alumnado.Data;
using Alumnado.Models;

namespace Alumnado.Data
{
    public class AlumnadoContext : DbContext
    {
        public AlumnadoContext(DbContextOptions<AlumnadoContext> options) : base (options)
        {
            
        }

        public DbSet<Alumno> Alumnos {get; set;}
    }
}