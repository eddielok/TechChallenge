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
    public class AuthorController : ControllerBase
    {
        private readonly AuthorService _authorService;

        private readonly IRepository<Author> _Author;

        public AuthorController(IRepository<Author> Author, AuthorService AuthorService)
        {
            _authorService = AuthorService;
            _Author = Author;

        }
        //Add Author
        [HttpPost("AddAuthor")]
        public async Task<Object> AddAuthor([FromBody] Author author)
        {
            try
            {
                await _authorService.AddAuthor(author);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        //Delete Author
        [HttpDelete("DeleteAuthor")]
        public bool DeleteAuthor(string Authorname)
        {
            try
            {
                _authorService.DeleteAuthor(Authorname);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Delete Author
        [HttpPut("UpdateAuthor")]
        public bool UpdateAuthor(Author Object)
        {
            try
            {
                _authorService.UpdateAuthor(Object);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //GET All Author by Name
        [HttpGet("GetAllAuthorByName")]
        public Object GetAllAuthorByName(string AuthorName)
        {
            var data = _authorService.GetAuthorByName(AuthorName);
            var json = JsonConvert.SerializeObject(data, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );
            return json;
        }

        //GET All Author
        [HttpGet("GetAllAuthors")]
        public Object GetAllBooks()
        {
            var data = _authorService.GetAllAuthors();
            var json = JsonConvert.SerializeObject(data, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );
            return json;
        }
    }
}