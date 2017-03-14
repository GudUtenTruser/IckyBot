using IckyBot.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IckyBot.Services
{
    public class MessageService
    {
        private DiscordContext _database = new DiscordContext();

        public async Task<DiscordUserMessage> AddMessage(DiscordUserMessage msg)
        {
            _database.Messages.Add(msg);

            await _database.SaveChangesAsync();

            return msg;
        }
    }
}
