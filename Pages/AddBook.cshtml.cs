﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesSample.DataContext;
using RazorPagesSample.DataContext.DBModels;

namespace RazorPagesSample
{
    public class AddBookModel : PageModel
    {
        private readonly RazorPagesSample.DataContext.SampleDBContext _context;

        public AddBookModel(RazorPagesSample.DataContext.SampleDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BookModel BookModel { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.BooksDbSet.Add(BookModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
