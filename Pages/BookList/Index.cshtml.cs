using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookList_Razor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookList_Razor.Pages.BookList
{
    public class IndexModel : PageModel
    {
        private AppDbContext context;
        public IEnumerable<Book> Books { get; set; }
        
        public IndexModel(AppDbContext Context)
        {
            this.context = Context;
        }
        
        public async Task OnGet()
        {
            Books = await context.Books.ToListAsync();
        }
    }
}