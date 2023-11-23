using ChambaOAEA.Datos.ViewModels;
using ChambaOAEA.Datos.Modelo;
using System;

namespace ChambaOAEA.Datos.Modelo.Services
{
    public class BooksServices
    {
        private AppDbContext __context;
        public BooksServices(AppDbContext context) 
        {
            __context = context;
        
        }
        public void AddBook(BookVM book) 
        {
            var _book = new Book()
            {
                Titulo = book.Titulo,
                Descripcion = book.Descripcion,
                IsRead = book.IsRead,
                DateRead = book.DateRead,
                Rate = book.Rate,
                Autor = book.Autor,
                CoverUrl = book.CoverUrl,
                DateAdded = DateTime.Now


            };
            __context.Books.Add(_book);
            __context.SaveChanges();
        }
    }
}
