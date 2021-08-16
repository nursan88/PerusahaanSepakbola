using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Newtonsoft.Json;
using WebTest.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebTest.DataLog;
using WebTest.Data.Contract.Master;
using WebTest.Data.Repository.Delete;
using WebTest.Data.Repository.Master;
using WebTest.Data.Contract.Transaksi;
using WebTest.Data.Repository.Transaksi;

namespace WebTest
{
    public class Startup
    {
        private string extensionsPath;
        private string pathUpload;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration, IWebHostEnvironment webHostEnvironment)
        {
            Configuration = configuration;
            this.extensionsPath = webHostEnvironment.ContentRootPath + configuration["Extensions:Path"];
            this.pathUpload = webHostEnvironment.ContentRootPath;
            _hostingEnvironment = webHostEnvironment;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var mvcBuilder = services.AddControllersWithViews();
            services.AddDbContext<MasterDbContext>(options =>
              options.UseSqlServer(Configuration.GetConnectionString("Connection")));
            services.AddDbContext<LogDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("ConnectionLog")));
            services.AddMvc(option =>
            {
                option.EnableEndpointRouting = false;
                option.MaxIAsyncEnumerableBufferLimit = 100000;
            }).AddJsonOptions(jsonOptions =>
            {
                jsonOptions.JsonSerializerOptions.IgnoreNullValues = true;
            }).AddNewtonsoftJson(opt =>
            {
                opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                opt.SerializerSettings.DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc;
                opt.SerializerSettings.DateFormatString = "yyyy'-'MM'-'dd' 'HH':'mm':'ss";
            });

            services.AddSingleton<IPemain, PemainRepo>();
            services.AddSingleton<IPosisiPemain, PosisiPemainRepo>();
            services.AddSingleton<IPosisi, PosisiRepo>();
            services.AddSingleton<ITim, TimRepo>();
            services.AddSingleton<IJadwalPertandingan, JadwalPertandinganRepo>();
            services.AddSingleton<IHasilPertandingan, HasilPertandinganRepo>();
            services.AddSingleton<ISkorhasil, SkorHasilRepo>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
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
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseCors(builder => builder.WithOrigins("*")
     .AllowAnyOrigin()
     .AllowAnyMethod()
     .AllowAnyHeader());
            app.UseMvc();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "default", pattern: "{controller}/{action}", defaults: new { controller = "Home", action = "Index" });
            });
        }
    }
}
