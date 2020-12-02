# DiscordREQ V0.0.2(.1 instable) | Made by Zenrox & Monstered

```
--------------------------------------

✨ > Usurp the user-agent, fingerprint and the ip address very simply
✨ > Very easy to use
✨ > No coding skill is required

--------------------------------------

✔️ > Version 0.0.2(.1 instable)
⭐ > Made by Zenrox x Monstered
📦 > Contact here: eviltool.contact@gmail.com

--------------------------------------

👉 Full Proxy support (http/s, socks4, socks5)
👉 User-agent spoofing
👉 FingerPrint spoofing
👉 Powerfull
👉 Simple
👉 Multi Threading (enable / disable)

--------------------------------------
```
# Code Exemple
```cs
using DiscordREQ;

namespace DiscordREQ_Test
{
    class Program
    {
        static void Main()
        {
            // Create new Discord client ==> string token, string proxy, string ProxyType, int timeout, bool Threaded, string userAgent, string XFingerPrint
            new ReqClient("Token", "Proxy:Port", "ProxyType", 3000, false, "user-agent", XFingerPrint);

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
