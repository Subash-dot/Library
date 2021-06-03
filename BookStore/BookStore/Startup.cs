using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
#if DEBUG
            services.AddRazorPages().AddRazorRuntimeCompilation();
#endif

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            //these commented codes are the concept of the middleware. these are 3 middleware and passes throught
            //first, second third and return to second, first.
            /*app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello form my first middleware pipeline. ");

                await next();

                await context.Response.WriteAsync("First Response?? ");

            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello form my second middleware pipeline. ");

                await next();

                await context.Response.WriteAsync("Second Response?? ");

            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello form my Third middleware pipeline. ");

                await next();
            });*/

            app.UseStaticFiles();

            /*app.UseStaticFiles(new StaticFileOptions()
            {
                RequestPath = "/MyStaticFiles",
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "MyStaticFiles"))
            });*/

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
