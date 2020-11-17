# DiscordREQ V0.0.1 | Made by Zenrox & Monstered

* Proxy support
* User-agent spoofing
* Powerfull
* Simple
* Multi Threading (Fast)

```cs
using DiscordREQ;

namespace DiscordREQ_Test
{
    class Program
    {
        static void Main()
        {
            // Create new Discord client
            new ReqClient("Token", "Proxy:Port", 3000);

            // Join server
            ReqClient.Guild.Join("InviteCode");

            // Get request response
            string JoinResp = DiscordREQ.Backend.Cache.LastedRequestResp;

            // Start typing to channel & send message and delete it
            ReqClient.Channel.StartTyping("ChannelID");
            ReqClient.Message.Send("Message", "ChannelId", true); // Activate - Desactivate TTS (Text to Speech)
            ReqClient.Message.Delete(DiscordREQ.Backend.Cache.LastedMessageId, DiscordREQ.Backend.Cache.LastedMessageChannelId);

        }
    }
}
```
