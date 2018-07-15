using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;
using ConfigurandoNHibernate.Migration;

namespace ConfigurandoNHibernate.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = CreateServices();

            using (var scope = serviceProvider.CreateScope())
            {
                UpdateDatabase(scope.ServiceProvider);
            }

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IServiceProvider CreateServices()
        {
            return new ServiceCollection()
                .AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                    .AddMySql5()
                    .WithGlobalConnectionString("Server=localhost;Database=wordpress;Uid=fsvblog;Pwd=fsvblogpass;SslMode=none;")
                    .ScanIn(typeof(CriacaoTabelaFuncionario).Assembly).For.Migrations())
                .AddLogging(lb => lb.AddFluentMigratorConsole())
                .BuildServiceProvider(false);
        }

        public static void UpdateDatabase(IServiceProvider serviceProvider)
        {
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
            runner.MigrateUp();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
