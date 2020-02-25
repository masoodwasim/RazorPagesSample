using RazorPagesSample.DataContext.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesSample.Services
{
    public interface IBookManager
    {
        IEnumerable<BookModel> GetLatestBooks();
        BookModel AddNewBook(BookModel bookModel);
    }
}
