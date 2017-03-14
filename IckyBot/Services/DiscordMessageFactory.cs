using Discord;
using IckyBot.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IckyBot.Services
{
    public class DiscordMessageFactory
    {
        public static DiscordUserMessage GenerateMessage(Message original)
        {
            return new DiscordUserMessage
            {
                Message = original.Text,
                Timestamp = original.Timestamp,
            };
        }
    }
}
