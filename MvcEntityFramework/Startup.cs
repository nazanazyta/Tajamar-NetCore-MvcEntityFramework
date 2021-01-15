using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcEntityFramework.Models;
using MvcEntityFramework.Data;
using Microsoft.Extensions.Configuration;
using MvcEntityFramework.Repositories;
using Microsoft.EntityFrameworkCore;

namespace MvcEntityFramework
{
    public class Startup
    {
        //VARIABLE PARA PODER RECUPERAR EL OBJETO DE LA INYECCIÓN
        IConfiguration Configuration { get; set; }
        //PARA PODER ACCEDER AL FICHERO appsettings.json
        //NECESITAMOS REALIZAR INYECCIÓN DE DEPENDENCIAS
        //EN LA CLASE Startup.cs DE LA INTERFACE IConfiguration
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            String cadena = Configuration.GetConnectionString("casasqlhospital");
            services.AddTransient<RepositoryEmpleados>();
            services.AddDbContext<EmpleadosContext>(options => options.UseSqlServer(cadena));
            services.AddTransient<RepositoryEnfermos>();
            services.AddDbContext<EnfermosContext>(options => options.UseSqlServer(cadena));
            //RESOLVEMOS LA DEPENDENCIA PARA EL REPOSITORIO
            services.AddTransient<RepositoryHospital>();
            //PARA UTILIZAR CONTEXTOS PUROS DbContext DE Entity Framework
            //DEBEMOS UTILIZAR UN MÉTODO ESPECIAL PARA IoC QUE ES .AddDbContext
            services.AddDbContext<HospitalContext>(options =>
            options.UseSqlServer(cadena));
            services.AddTransient<RepositoryPlantilla>();
            //String cadena = "Data Source=localhost;Initial Catalog=HOSPITAL;User ID=sa;Password=MCSD2020";
            //String cadena = Configuration.GetConnectionString("casamysqlhospital");
            //services.AddSingleton<IDepartamentosContext, DepartamentosContextSQL>();
            services.AddSingleton<IDepartamentosContext>(context =>
                new DepartamentosContextSQL(cadena));
            //services.AddSingleton<IDepartamentosContext>(context =>
            //    new DepartamentosContextMySql(cadena));
            //LAS DEPENDENCIAS DE OBJETOS SE RESUELVEN EN LOS SERVICIOS DE LA APP
            //LA PRIMERA OPCIÓN SERÁ UTILIZAR AddTransient<>
            //QUE GENERA UN OBJETO POR CADA PETICIÓN DE INYECCIÓN
            //TODOS LOS CONTROLLERS QUE UTILICEN UN COCHE, USARÁN ESE MISMO
            //services.AddTransient<Coche>();
            //TAMBIÉN TENEMOS LA OPCIÓN DE CREAR UNA ÚNICA INSTANCIA DE UN OBJETO
            //PARA TODAS LAS PETICIONES DE INYECCIÓN
            //SE REALIZA CON EL MÉTODO AddSingleton<T>
            //services.AddSingleton<ICoche, Coche>();
            //services.AddSingleton<ICoche, Deportivo>();
            services.AddSingleton<ICoche>(z => new Deportivo("Nisan", "Kaskai", "nisan.jfif", 290));
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
