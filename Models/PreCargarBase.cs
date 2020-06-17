using Alumnado.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Alumnado.Models
{
    public class PreCargarBase
    {
        public static void PreCargado(IApplicationBuilder app)
        {
            using(var serviceScope = app.ApplicationServices.CreateScope())
            {
                MontaDatos(serviceScope.ServiceProvider.GetService<AlumnadoContext>());
            }
        }

        public static void MontaDatos(AlumnadoContext context)
        {
            System.Console.WriteLine("Buscando Base de Datos y contenido...");
            context.Database.Migrate();
            if(!context.Alumnos.Any())
            {
                System.Console.WriteLine("No existe la base, Añadiendo Datos...");
                context.Alumnos.AddRange(
                    new Alumno() {ApellidoP="Molleda", ApellidoM="Rivera", Nombre="Abraham Azael"}
                );
                context.SaveChanges();
            }   
            else
            {
                System.Console.WriteLine("Ya existe una base con datos, ejecutando sin aplicar semilla");
            }
        }
    }
}