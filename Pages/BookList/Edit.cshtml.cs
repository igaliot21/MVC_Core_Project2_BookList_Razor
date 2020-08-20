using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookList_Razor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookList_Razor.Pages.BookList
{
    public class EditModel : PageModel
    {
        private AppDbContext context;
        [BindProperty]
        public Book Book { get; set; }
        [TempData]
        public string Message { get; set; }
        public EditModel(AppDbContext Context)
        {
            this.context = Context;
        }
        public void OnGet(int id)
        {
            Book = context.Books.Find(id);
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var bookInDb = context.Books.Find(Book.Id);
                bookInDb.ISBN = Book.ISBN;
                bookInDb.Title = Book.Title;
                bookInDb.Author = Book.Author;
                bookInDb.Avaibility = Book.Avaibility;
                bookInDb.Price = Book.Price;

                await context.SaveChangesAsync();
                Message = "Book updated successfuly!";

                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}
