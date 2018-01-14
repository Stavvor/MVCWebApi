using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MVCWebApi.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Swagger;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Cors.Internal;

namespace MVCWebApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
            options.AddPolicy("AllowAnyOrigin",
                Cbuilder => Cbuilder.AllowAnyOrigin()
                                    .AllowAnyMethod()
                                    .AllowAnyHeader());
                    
            });

            services.AddMvc();

            services.Configure<MvcOptions>(options =>
            {
                options.Filters.Add(new CorsAuthorizationFilterFactory("AllowAnyOrigin"));
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "library api" });
            }
            );

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "projektzespolowy123.database.windows.net";
            builder.UserID = "DBadmin";
            builder.Password = "SuperBibliotekaKurwo123";
            builder.InitialCatalog = "uselesslibrary";

            services.AddDbContext<LibraryContext>(options => options.UseSqlServer(builder.ConnectionString));
        }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("AllowAnyOrigin");

            app.UseMvc();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "SWAG");
            }
                );
        }
    }
}
