using Bookshop.Modals;
using Bookshop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookshop.Pages
{
    
    public class IndexModel : PageModel
    {
        public IEnumerable<Book> Books { get; private set; }
        public JsonBookFileService BookService;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(
            ILogger<IndexModel> logger,
            JsonBookFileService bookService)
        {
            _logger = logger;
            BookService = bookService;
        }

        public void OnGet()
        {
            Books = BookService.getBookRecord();
        }
    }
}
