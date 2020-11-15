using DiscordREQ.Backend.DiscordAPI;
using DiscordREQ.Backend;

namespace DiscordREQ
{
    public class ReqClient
    {
        public ReqClient(string token, string proxy = "", int timeout = 3500, string userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36")
        {
            Cache.Token = token;
            Cache.Proxy = proxy;
            Cache.Timeout = timeout;
            Cache.UserAgent = userAgent;
        }
        
        public void SendMessage(string Message, string Channel, bool tts = false) => Request.SendRequest(API.SendMessageUrl(Channel), "POST", Cache.Token, $"\"content\":\"{Message}\", \"nonce\":\"{Channel}\",\"tts\": \"{tts}\"", Cache.Proxy, Cache.Timeout, Cache.UserAgent);
        
        public void DeleteMessage(string MessageID, string Channel) => Request.SendRequest(API.DeleteMessageUrl(MessageID, Channel), "DELETE", Cache.Token, "", Cache.Proxy, Cache.Timeout, Cache.UserAgent);

        public void JoinServer(string InviteCode) => Request.SendRequest(API.JoinServerURL(InviteCode), "POST", Cache.Token, "", Cache.Proxy, Cache.Timeout, Cache.UserAgent);

        public void LeaveServer(string ServerID) => Request.SendRequest(API.LeaveServerUrl(ServerID), "DELETE", Cache.Token, "", Cache.Proxy, Cache.Timeout, Cache.UserAgent);

        public void Typing(string ChannelID) => Request.SendRequest(API.TypingMessageUrl(ChannelID), "POST", Cache.Token, "", Cache.Proxy, Cache.Timeout, Cache.UserAgent);
    }
}