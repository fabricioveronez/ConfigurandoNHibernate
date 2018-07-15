using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConfigurandoNHibernate.Api.Map;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NHibernate;

namespace ConfigurandoNHibernate.Api
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            ISessionFactory sessionFactory = Fluently
               .Configure()
               .Database(MySQLConfiguration.Standard.ConnectionString("Server=localhost;Database=wordpress;Uid=fsvblog;Pwd=fsvblogpass;SslMode=none;"))
               .Mappings(m => m.FluentMappings.AddFromAssemblyOf<FuncionarioMap>())
               .BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();

            services.AddSingleton(session);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
