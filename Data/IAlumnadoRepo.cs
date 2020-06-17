using System.Collections.Generic;
using Alumnado.Models;

namespace Alumnado.Data
{
    public interface IAlumnadoRepo
    {
        IEnumerable<Alumno> ObtenerTodoslosAlumnos();
        Alumno ObtenerAlumnoporId(int id);
    }
}