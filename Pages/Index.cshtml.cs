using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RazorPagesSample.DataContext.DBModels;
using RazorPagesSample.Services;

namespace RazorPagesSample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IBookManager _bookManager; 
        public IEnumerable<BookModel> Books { get; set; } = new List<BookModel>();
        public IndexModel(ILogger<IndexModel> logger, IBookManager bookManager)
        {
            _logger = logger;
            _bookManager = bookManager;
        }

        public  IActionResult OnGet()
        {
            Books =  _bookManager.GetLatestBooks().ToList();
            return Page();
           
        }
    }
}
