using Discord;
using IckyBot.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IckyBot.Services
{
    public class UserService
    {
        readonly DiscordContext _database = new DiscordContext();

        public DiscordUser GetUserByName(string name)
        {
            return _database.Users.FirstOrDefault(f => f.LastKnownDiscordId == name);
        }

        public DiscordUser GetUserByNickname(string nick)
        {
            return _database.Users.FirstOrDefault(f => f.LastKnownAlias == nick);
        }

        public async Task<DiscordUser> AddUser(DiscordUser user)
        {
            _database.Users.Add(user);
            await _database.SaveChangesAsync();

            return user;
        }
    }
}
