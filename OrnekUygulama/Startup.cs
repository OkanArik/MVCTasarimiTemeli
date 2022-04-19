using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekUygulama
{
    public class Startup
    { 
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();//Burada uygulamamiz MVC davranişini sergilemesi için servisi uygulamamiza ekledik.Burada Controller ve View eklendi peki Model; Model bir servis degil sadece veri tabani islemlerinin yapildiği bir katman.
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();// Gelen requestin rotasý bu middleware de belirleniyor.

            //Endpoint= yapilan requestin varis noktasi.
            app.UseEndpoints(endpoints => //Bu uygulamaya yapilan requestin hangi rotalar/sablonlar esliginde gelebileceginin belirttildigi middleware.
            {
                //    endpoints.MapGet("/", async context =>
                //    {
                //        await context.Response.WriteAsync("Hello World!");
                //    });
                endpoints.MapDefaultControllerRoute();//Istek yapacagimiz temel varsayilan rotayi belirler.
            });
        }
    }
}

//customize = Özellestirmek
