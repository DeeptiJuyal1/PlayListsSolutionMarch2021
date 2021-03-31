using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PlayLists.Domain;

namespace PlayLists.Pages
{
    public class SongDetailsModel : PageModel
    {

        private readonly PlayListsDataContext _context;

        public SongDetailsModel(PlayListsDataContext context)
        {
            _context = context;
        }

        public Song Song { get; set; }
        public string ErrorMessage { get; set; }
        public async Task OnGetAsync(int id)
        {
            Song = await _context.Songs.SingleOrDefaultAsync(s => s.Id == id);
            if(Song == null)
            {
                ErrorMessage = "No Song with that Id!";
            }

        }
    }
}
