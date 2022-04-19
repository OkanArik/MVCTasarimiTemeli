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
            services.AddControllersWithViews();//Burada uygulamamýz MVC davranýþý sergilemesi için servisi uygulamamýza ekledik.Burada Controller ve View eklendi peki Model; Model bir servis deðil sadece veri tabaný iþlemlerinin yapýldýðý bir katman.
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();// Gelen requestin rotasý bu middleware de belirleniyor.

            //Endpoint= yapýlan requestin varýþ noktasý.
            app.UseEndpoints(endpoints => //Bu uygulamaya yapýlan requestin hangi rotalar/þablonlar eþliðinde gelebileceðinin belirttildiði middleware.
            {
                //    endpoints.MapGet("/", async context =>
                //    {
                //        await context.Response.WriteAsync("Hello World!");
                //    });
                endpoints.MapDefaultControllerRoute();//Ýstek yapacaðýmýz temel varsayýlan rotayý belirler.
            });
        }
    }
}

//customize = Özelleþtirmek
