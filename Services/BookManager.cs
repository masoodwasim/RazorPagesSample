using RazorPagesSample.DataContext;
using RazorPagesSample.DataContext.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesSample.Services
{
    public class BookManager : IBookManager
    {
        private SampleDBContext _context;
        public BookManager(SampleDBContext context)
        {
            _context = context;
        }
        public BookModel AddNewBook(BookModel bookModel)
        {
            var newID = _context.BooksDbSet.Select(x => x.ID).Max() + 1;
            bookModel.ID = newID;
            try
            {
                _context.BooksDbSet.Add(bookModel);
                _context.SaveChanges();
                return bookModel;
            }
            catch (Exception ex)
            {
                // Log exception
                return bookModel;
            }
        }

        public IEnumerable<BookModel> GetLatestBooks()
        { 
            return _context.BooksDbSet.ToList();
        }
    }
}
