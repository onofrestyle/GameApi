using System;
using System.IO;
using Autofac;
using FluentMigrator.Runner;
using GameApi.Infrastructure.Data;
using GameApi.Infrastructure.Data.Migrations;
using GameApi.Infrastruture.CrossCutting.IOC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace GameApi.Presentation
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //GetDataBase();
            var connectionString = Configuration["ConnectionStrings:SqlLiteConnectionString"];

            services.AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                    .AddSQLite()
                    .WithGlobalConnectionString(connectionString)
                    .ScanIn(typeof(CreateGameApiTables).Assembly).For.Migrations())
                .AddLogging(lb => lb.AddFluentMigratorConsole());

            services.AddDbContext<SqliteContext>(o => o.UseSqlite(connectionString));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "GameApu", Version = "v1" });
            });

            services.AddMemoryCache();
            services.AddMvc();
            services.AddControllers();
      }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new ModuleIOC());
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var runner = app.ApplicationServices.GetRequiredService<IMigrationRunner>();
            runner.MigrateUp();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        public SqliteConnection GetDataBase()
        {
            var Connection = new SqliteConnection();

            var builder = new SqliteConnectionStringBuilder();
            builder.DataSource = "GameApi.db";


            if (!File.Exists("GameApi.db"))
            {
                Connection = new SqliteConnection(builder.ConnectionString);

                Connection.Open();
                var create = new SqliteCommand(@"CREATE TABLE [Player] (
                                                          [Id]  integer PRIMARY KEY AUTOINCREMENT,
                                                          [Name] CHAR(200),
                                                          [TeamId] int);", Connection);
                create.ExecuteNonQuery();
            }

            else
            {
                Connection = new SqliteConnection(builder.ConnectionString);
                Connection.Open();
            }


            return Connection;
        }

        private static void UpdateDatabase(IServiceProvider serviceProvider)
        {
            // Instantiate the runner
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();

            // Execute the migrations
            runner.MigrateUp();
        }
    }
}
