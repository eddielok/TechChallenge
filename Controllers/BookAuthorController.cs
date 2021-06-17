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
    public class BookAuthorController : ControllerBase
    {
        private readonly BookAuthorService _bookauthorService;

        private readonly IRepositorySP<BookAuthor> _bookauthor;

        public BookAuthorController(IRepositorySP<BookAuthor> BookAuthor, BookAuthorService BookAuthorService)
        {
            _bookauthorService = BookAuthorService;
            _bookauthor = BookAuthor;

        }
        //GET All Book with Aurhor Name
        [HttpGet("GetAllBooksAurhorName")]
        public async Task<List<BookAuthor>> GetAllBooksAurhorName()
        {

            return await _bookauthorService.GetAllBooksAurhorName();
        }

    }
}