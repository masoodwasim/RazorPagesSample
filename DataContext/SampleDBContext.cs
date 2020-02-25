using Microsoft.EntityFrameworkCore;
using RazorPagesSample.DataContext.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesSample.DataContext
{
    public class SampleDBContext : DbContext
    {
        public SampleDBContext(DbContextOptions<SampleDBContext> options)
           : base(options)
        {
        }
        public DbSet<BookModel> BooksDbSet { get; set; }
    
    }
}
