using Discord.Commands;
using System;
using System.Threading.Tasks;

namespace SadistDiscordBotCore.Modules.Cleverbot
{
	public class CleverbotModule : ModuleBase<SocketCommandContext>
    {
		[Command("c")]
		public async Task Speak([Remainder]string message)
		{
			CleverbotSession cleverbot = new CleverbotSession("");
			var response = await cleverbot.GetResponseAsync(message);
			await ReplyAsync(response.Response);
		}
    }
}
