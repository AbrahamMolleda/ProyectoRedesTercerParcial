using System.Collections.Generic;
using Alumnado.Models;

//
//Prueba Unitaria de Funcionamiento de abstracción de Modelo Alumno
//y su representancion en la api, realmente no se usa dentro de la aplicacion funcional
//
namespace Alumnado.Data
{
    public class MockAlumnadoRepo : IAlumnadoRepo
    {
        public IEnumerable<Alumno> ObtenerTodoslosAlumnos()
        {
            var alumnos = new List<Alumno>
            {
                new Alumno{ID=1, ApellidoP="Molleda", ApellidoM="Rivera", Nombre="Abraham Azael"},
                new Alumno{ID=2, ApellidoP="ApellidoPaterno", ApellidoM="ApellidoMaterno", Nombre="Nombre"}
            };
            return alumnos;
        }
        public Alumno ObtenerAlumnoporId(int id)
        {
            return new Alumno{ID=1, ApellidoP="Molleda", ApellidoM="Rivera", Nombre="Abraham Azael"};
        }
    }
}