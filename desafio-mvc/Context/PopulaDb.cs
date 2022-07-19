using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace desafio_mvc.Context
{
    public static class PopulaDb
    {
        public static void IncluiDadosDB(IApplicationBuilder app){
            IncluiDadosDB(
                app.ApplicationServices.GetRequiredService<ApplicationDbContext>());
        }
        public static void IncluiDadosDB(ApplicationDbContext context)
        {
            System.Console.WriteLine("Aplicando Migrations...");
            context.Database.Migrate();
        }
    }
}