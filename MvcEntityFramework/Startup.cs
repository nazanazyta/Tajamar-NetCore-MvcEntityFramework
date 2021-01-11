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
