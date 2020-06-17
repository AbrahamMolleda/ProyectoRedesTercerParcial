using System.Collections.Generic;
using System.Linq;
using Alumnado.Models;

namespace Alumnado.Data
{
    public class SqlAlumandoRepo : IAlumnadoRepo
    {
        private readonly AlumnadoContext _contexto;

        public SqlAlumandoRepo(AlumnadoContext contexto)
        {
            _contexto = contexto;
        }
        public Alumno ObtenerAlumnoporId(int id)
        {
            return _contexto.Alumnos.FirstOrDefault(p => p.ID == id);
        }

        public IEnumerable<Alumno> ObtenerTodoslosAlumnos()
        {
            return _contexto.Alumnos.ToList();
        }
    }
}