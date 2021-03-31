using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayLists.Domain
{
    public class PlayListsDataContext : DbContext
    {
        public PlayListsDataContext(DbContextOptions<PlayListsDataContext> options): base(options)
        {

        }

        public DbSet<Song> Songs { get; set; }
    }
}
