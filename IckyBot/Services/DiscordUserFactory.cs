using Discord;
using IckyBot.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IckyBot.Services
{
    public static class DiscordUserFactory
    {
        public static DiscordUser GenerateUser(User user)
        {
            return new DiscordUser
            {
                LastKnownAlias = user.Nickname,
                LastKnownDiscordId = user.Name
            };
        }
    }
}
