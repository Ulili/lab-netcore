using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab4.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Lab4
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
                .AddDbContext<DadosContext>(options =>
                options.UseMySql(Configuration.GetConnectionString("DefaultConnection")));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, DadosContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

            Inicializar(context);
        }

        private void Inicializar(DadosContext context)
        {
            if (context != null)
            {
                context.Database.EnsureCreated();

                if (!context.Usuarios.Any())
                {
                    var fake = new DadosFake();
                    context.Usuarios.AddRange(fake.Usuarios(100));
                    context.SaveChanges();       
                }
            }
        }
    }
}
