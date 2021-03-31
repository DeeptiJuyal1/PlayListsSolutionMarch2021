using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PlayLists.Domain;

namespace PlayLists.Pages
{
    public class CreateASongModel : PageModel
    {
        private readonly PlayListsDataContext _context;

        public CreateASongModel(PlayListsDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Song Song { get; set; }

        public void OnGet()
        {
        }

        public async Task<ActionResult> OnPostAsync()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            } else
            {
                _context.Songs.Add(Song);
                await _context.SaveChangesAsync();
                TempData["flash"] = $"Added song {Song.Title} by {Song.Artist}";
                return RedirectToPage("Songs");
            }
        }
    }
}
