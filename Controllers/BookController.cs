using Microsoft.AspNetCore.Mvc;
using ThuVierApi.Dtos.Book;
using ThuVierApi.Services.Interfaces;

namespace ThuVierApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBook _bookService;
        public BookController(IBook book)
        {
            _bookService = book;
        }
        [HttpPost]
        public IActionResult Create(BookDto input)
        {
            _bookService.Create(input);
            return Ok(input);
        }
        [HttpGet]   
        public IActionResult GetAll()
        {
            var book = _bookService.GetAll();
            return Ok(book);
        }
        [HttpDelete("by-id")]
        public IActionResult Delete(int id)
        {
            _bookService.Delete(id);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(UpdateBookDto input) 
        {
            _bookService.Update(input);
            return Ok();
        }
       
    }
}
