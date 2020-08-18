using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookList_Razor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookList_Razor.Pages.BookList
{
    public class CreateModel : PageModel
    {
        private AppDbContext context;
        [BindProperty]
        public Book Book { get; set; }

        public CreateModel(AppDbContext Context)
        {
            this.context = Context;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost() { 
            if (!ModelState.IsValid)
            {
                return Page();
            }
            context.Books.Add(Book);
            await context.SaveChangesAsync();
            
            return RedirectToPage("Index");
        }
    }
}
