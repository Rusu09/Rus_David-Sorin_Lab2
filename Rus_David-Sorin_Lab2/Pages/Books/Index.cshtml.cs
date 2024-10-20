using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rus_David_Sorin_Lab2.Data;
using Rus_David_Sorin_Lab2.Models;

namespace Rus_David_Sorin_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Rus_David_Sorin_Lab2.Data.Rus_David_Sorin_Lab2Context _context;

        public IndexModel(Rus_David_Sorin_Lab2.Data.Rus_David_Sorin_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                .Include(b => b.Publisher)
                .Include(b => b.Author)
                .ToListAsync();
        }
    }
}
