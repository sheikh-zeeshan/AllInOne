using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogSite.Data;
using BlogSite.Data.FileManager;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;

namespace BlogSite
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddIdentity<IdentityUser, IdentityRole>(opt => {
                    opt.Password.RequireDigit = false;
                })
                //.AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>();

            services.AddDbContext<AppDbContext>(opts => opts.UseSqlServer(Configuration["DefaultConnectoin"]));
            services.AddDbContext<BookContext>(opts => opts.UseSqlServer(Configuration["DefaultConnectoin"]));

            services.ConfigureApplicationCookie(opt => opt.LoginPath = "/Auth/Login");

            services.AddTransient<IRepository, Repository>();
            services.AddTransient<IFileManager, FileManager>();
            services.AddTransient<IBookRepository, BookRepository>();

        
            //services.AddMvc(opt => {
            //    opt.CacheProfiles.Add("Monthly", new CacheProfile { Duration = 60 * 60 * 24 * 7 * 4 });
            //});


            services.AddControllersWithViews();
#if DEBUG //debug mode other is release
            services.AddRazorPages().AddRazorRuntimeCompilation().AddViewOptions(opt => {

                opt.HtmlHelperOptions.ClientValidationEnabled = true; //enable or disable from here
            
            }); //to refelect run time changes of views on browser
#endif

        //    services.AddWebMarkupMin(
        //options =>
        //{
        //    options.AllowMinificationInDevelopmentEnvironment = true;
        //    options.AllowCompressionInDevelopmentEnvironment = true;
        //})
        //.AddHtmlMinification(
        //    options =>
        //    {
        //        options.MinificationSettings.RemoveRedundantAttributes = true;
        //        options.MinificationSettings.RemoveHttpProtocolFromAttributes = true;
        //        options.MinificationSettings.RemoveHttpsProtocolFromAttributes = true;
        //    })
        //.AddHttpCompression();

         }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsEnvironment("PreDev"))
            { 
                app.Use(async (ctx, next) =>
                {
                    await ctx.Response.WriteAsync("middle ware 1 executing");
                    await next();
                    await ctx.Response.WriteAsync("middle ware 1 exeuting last");
                });

                app.Use(async (ctx, next) =>
                {
                    await ctx.Response.WriteAsync("<div><h1>hello</h1><p>do it finely</p></div>");
                });
            } 

            if (env.IsDevelopment())
            {
                
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


            ////if (env.IsDevelopment())
            ////{
            ////    app.UseExceptionHandler("/error/500");
            ////    throw new Exception("bala bla");
            ////}
            ///
            
            app.UseHttpsRedirection();

           ///// app.UseWebMarkupMin(); //before static file


            app.UseStaticFiles(); //by defautl go to wwwroot

            ////app.UseStaticFiles(new StaticFileOptions() {
            //// FileProvider = new PhysicalFileProvider("folder path")
            ////});

            app.UseRouting();//map url to resource
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute( // when using tag helper
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");//if we add bookapp/{controller}/{action}/{id?} bookapp needs to be appended in any navigation
            });

            string str = env.EnvironmentName;
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.Map("/zeeshan", async ctx =>
                {
                    await ctx.Response.WriteAsync("hello zeeshan");

                });
            });
        }
    }
}
