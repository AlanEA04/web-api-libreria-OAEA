using ChambaOAEA.Datos.Modelo;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChambaOAEA.Datos
{
    public class AppDbInitialer
    {

        //Metodo para poder agregar datos a nuestra base de datos

        public static void Seed(IApplicationBuilder applicationBuilder)
        {
           using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (context.Books.Any()) 
                {
                    context.Books.AddRange(new Book()
                    {
                        Titulo = "lst Bool Title",
                        Descripcion = "lst Book Description",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genero = "Biography",
                        Autor = "lst Authoner",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now,


                    },
                    new Book()
                    {
                        Titulo = "2nd Bool Title",
                        Descripcion = "2nd Book Description",
                        IsRead = true,
                        
                        Rate = 4,
                        Genero = "Biography",
                        Autor = "2nd Authoner",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now,

                    });
                    context.SaveChanges();
                }
            }
        }

    }
}
