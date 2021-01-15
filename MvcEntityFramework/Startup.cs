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
        //VARIABLE PARA PODER RECUPERAR EL OBJETO DE LA INYECCI�N
        IConfiguration Configuration { get; set; }
        //PARA PODER ACCEDER AL FICHERO appsettings.json
        //NECESITAMOS REALIZAR INYECCI�N DE DEPENDENCIAS
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
            //DEBEMOS UTILIZAR UN M�TODO ESPECIAL PARA IoC QUE ES .AddDbContext
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
            //LA PRIMERA OPCI�N SER� UTILIZAR AddTransient<>
            //QUE GENERA UN OBJETO POR CADA PETICI�N DE INYECCI�N
            //TODOS LOS CONTROLLERS QUE UTILICEN UN COCHE, USAR�N ESE MISMO
            //services.AddTransient<Coche>();
            //TAMBI�N TENEMOS LA OPCI�N DE CREAR UNA �NICA INSTANCIA DE UN OBJETO
            //PARA TODAS LAS PETICIONES DE INYECCI�N
            //SE REALIZA CON EL M�TODO AddSingleton<T>
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
