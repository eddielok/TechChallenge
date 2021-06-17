using CRUD_BAL.Service;
using CRUD_DAL.Interface;
using CRUD_DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookService _bookService;

        private readonly IRepository<Book> _book;

        public BookController(IRepository<Book> Book, BookService BookService)
        {
            _bookService = BookService;
            _book = Book;

        }
        //Add Book
        [HttpPost("AddBook")]
        public async Task<Object> AddBook([FromBody] Book book)
        {
            try
            {
                await _bookService.AddBook(book);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        //Delete Book
        [HttpDelete("DeleteBook")]
        public bool DeleteBook(string Bookname)
        {
            try
            {
                _bookService.DeleteBook(Bookname);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Delete Book
        [HttpPut("UpdateBook")]
        public async Task<IActionResult> UpdateBook(Book Object)
        {
            try
            {
                await _bookService.UpdateBook(Object);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        //GET All Book by Name
        [HttpGet("GetAllBookByName")]
        public Object GetAllBookByName(string BookName)
        {
            var data = _bookService.GetBookByBookName(BookName);
            var json = JsonConvert.SerializeObject(data, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );
            return json;
        }
        //GET All Book by Name
        [HttpGet("GetAllBookByNameAsync")]
        public async Task<Object> GetAllBookByNameAsync(string BookName)
        {
            var Bookitem = await _bookService.GetBookByBookNameAsync(BookName);
            Bookitem.SalesCount++;
            await _bookService.UpdateBook(Bookitem);
            var json = JsonConvert.SerializeObject(Bookitem, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );
            return json;
        }
        //GET All Book
        [HttpGet("GetAllBooks")]
        public Object GetAllBooks()
        {
            var data = _bookService.GetAllBooks();
            var json = JsonConvert.SerializeObject(data, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );
            return json;
        }
        //Delete Book
        [HttpPut("IncreaseSalseCount")]
        public async Task<IActionResult> IncreaseSalseCount(int id)
        {
            try
            {
                var Bookitem = _bookService.GetBookById(id);
                Bookitem.SalesCount++;
                await _bookService.UpdateBook(Bookitem);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}