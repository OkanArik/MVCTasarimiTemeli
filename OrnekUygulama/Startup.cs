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
            services.AddControllersWithViews();//Burada uygulamam�z MVC davran��� sergilemesi i�in servisi uygulamam�za ekledik.Burada Controller ve View eklendi peki Model; Model bir servis de�il sadece veri taban� i�lemlerinin yap�ld��� bir katman.
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();// Gelen requestin rotas� bu middleware de belirleniyor.

            //Endpoint= yap�lan requestin var�� noktas�.
            app.UseEndpoints(endpoints => //Bu uygulamaya yap�lan requestin hangi rotalar/�ablonlar e�li�inde gelebilece�inin belirttildi�i middleware.
            {
                //    endpoints.MapGet("/", async context =>
                //    {
                //        await context.Response.WriteAsync("Hello World!");
                //    });
                endpoints.MapDefaultControllerRoute();//�stek yapaca��m�z temel varsay�lan rotay� belirler.
            });
        }
    }
}

//customize = �zelle�tirmek
