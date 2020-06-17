using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alumnado.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Alumnado.Models;

namespace Alumnado
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //Agregando conexion a la base de datos
            services.AddDbContext<AlumnadoContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("AlumnadoConnection")));
            //Agrenando funciones que se podrán realizar dentro la API con los datos de la Base
            services.AddScoped<IAlumnadoRepo, SqlAlumandoRepo>();
            
            services.AddControllers();
            
        }
        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            PreCargarBase.PreCargado(app);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            //PreCargarBase.PreCargado(app);
        }
    }
}
