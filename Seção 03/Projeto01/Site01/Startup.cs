using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.Sqlite;
using Site01.Database;

namespace Site01
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<DatabaseContext>(options=> {
                //Providers - Bibliotecas Conexões com Bandos - SqlServer, MySQL, Oracle, Postgre, Firebird, DB2...
                //options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=site01;Integrated Security=True;");
                options.UseSqlite("Data Source=Database\\site01.db");
            });

            services.AddDistributedMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            /**
             * www.site.com.br/cliente/lista (Página com Listagem Clientes)
             * www.site.com.br/cliente/deletar/30
             * www.site.com.br/cliente/visualizar/30
             * www.site.com.br/noticia/visualizar/acidentes-de-carro-nas-rodovias
             * {domínio}/{Controller=Home}/{Action=Index}/{Id?}
             */
            app.UseSession();

            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            /*
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
            */
        }
    }
}
