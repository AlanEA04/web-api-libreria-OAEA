using ChambaOAEA.Datos.Modelo.Services;
using ChambaOAEA.Datos.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChambaOAEA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        public BooksServices _booksServices;

        public BooksController(BooksServices booksServices)
        {
            _booksServices = booksServices;
        }
        //ARREGLO

        [HttpPost ("add-book")  ]
        public IActionResult AddBook([FromBody] BookVM book)
        {
            _booksServices.AddBook(book);
            return Ok();
        }
    }
}
