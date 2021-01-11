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

namespace MvcEntityFramework
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            String cadena = "Data Source=localhost;Initial Catalog=HOSPITAL;User ID=sa;Password=MCSD2020";
            //services.AddSingleton<IDepartamentosContext, DepartamentosContextSQL>();
            services.AddSingleton<IDepartamentosContext>(context => new DepartamentosContextSQL(cadena));
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
