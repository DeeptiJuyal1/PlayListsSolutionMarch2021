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
    public class SongsModel : PageModel
    {

        private readonly PlayListsDataContext _context;

        public SongsModel(PlayListsDataContext context)
        {
            _context = context;
        }

        public List<Song> Songs { get; set; }

        public async Task OnGetAsync()
        {
            Songs = await _context.Songs.ToListAsync();
        }
    }
}
