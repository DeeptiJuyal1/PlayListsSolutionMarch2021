using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PlayLists.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayLists.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<TopSong> Songs { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Songs = new List<TopSong>
            {
                new TopSong { Artist="Billie Eilish", Title="Bad Guy", NumberOfPlays=5000 },
                new TopSong { Artist="Nick Cave and Warren Ellis", Title="Elephant", NumberOfPlays=3000}
            };
        }
    }
}
