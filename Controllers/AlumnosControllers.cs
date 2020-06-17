using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Alumnado.Models;
using Alumnado.Data;

namespace Alumnado.Controllers
{
    //api/alumnos
    [Route("api/alumnos")]
    [ApiController]
    public class AlumnosControllers : ControllerBase
    {
        private readonly IAlumnadoRepo _repository;

        public AlumnosControllers(IAlumnadoRepo repositorio)
        {
            _repository = repositorio;
        }
        //private readonly MockAlumnosRepo _repository = new MockAlumnosRepo();
        //Get api/alumnos
        [HttpGet]
        public ActionResult<IEnumerable<Alumno>> ObtenerTodoslosAlumnos()
        {
            var alumnos = _repository.ObtenerTodoslosAlumnos();
            return Ok(alumnos);
        }

        //Get api/alumnos/{id}
        [HttpGet("{id}")]
        public ActionResult<Alumno> ObtenerAlumnoporID(int id)
        {
            var alumno = _repository.ObtenerAlumnoporId(id);
            return Ok(alumno);
        }
    }
}