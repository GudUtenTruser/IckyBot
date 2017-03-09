using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IckyBot.Model
{
    public class DiscordContext : DbContext
    {
        public DbSet<DiscordUserMessage> Messages { get; set; }
        public DbSet<DiscordUser> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Filename=./IckyBot.sqlite");
        }
    }

    public class DiscordUser
    {
        public int Id { get; set;}

        public string LastKnownAlias { get; set; }
        public string LastKnownDiscordId { get; set; }

        public DateTime LastActivity { get; set; }
    }

    public class DiscordUserMessage
    {
        public int Id { get; set; }

        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
        public int UserId { get; set; }
    }
}
