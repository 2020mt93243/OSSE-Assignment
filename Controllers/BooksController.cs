using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OSSE_Assignment.Models;
using OSSE_Assignment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSSE_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookService _bookService;

        public BooksController(BookService bookService)
        {
            _bookService = bookService;
        }
    }
}
