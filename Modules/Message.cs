using DiscordREQ.Backend.DiscordAPI;
using DiscordREQ.Backend;

namespace DiscordREQ.Modules
{
    internal class Message
    {
        internal static void SendMessage(string Message, string Channel, bool tts = false) => Request.SendRequest(APIChannels.SendMessageUrl(Channel), "POST", Cache.Token, $"\"content\":\"{Message}\", \"nonce\":\"{Channel}\",\"tts\": \"{tts}\"", Cache.Proxy, Cache.Timeout, Cache.UserAgent);
        internal static void DeleteMessage(string MessageID, string Channel) => Request.SendRequest(APIChannels.EditMessageUrl(MessageID, Channel), "DELETE", Cache.Token, "", Cache.Proxy, Cache.Timeout, Cache.UserAgent);
        internal static void Typing(string ChannelID) => Request.SendRequest(APIChannels.TypingMessageUrl(ChannelID), "POST", Cache.Token, "", Cache.Proxy, Cache.Timeout, Cache.UserAgent);
        internal static void PinsMessage(string MessageID, string ChannelID) => Request.SendRequest(APIChannels.PinsMessUrl(ChannelID, MessageID), "PUT", Cache.Token, "", Cache.Proxy, Cache.Timeout, Cache.UserAgent);
        internal static void UnPinsMessage(string MessageID, string ChannelID) => Request.SendRequest(APIChannels.PinsMessUrl(ChannelID, MessageID), "DELETE", Cache.Token, "", Cache.Proxy, Cache.Timeout, Cache.UserAgent);
        internal static void SetReaction(string MessageID, string ChannelID, string EncodedReact) => Request.SendRequest(APIChannels.SetReactUrl(ChannelID, MessageID, EncodedReact), "PUT", Cache.Token, "", Cache.Proxy, Cache.Timeout, Cache.UserAgent);
        internal static void RemoveReaction(string MessageID, string ChannelID, string EncodedReact) => Request.SendRequest(APIChannels.SetReactUrl(ChannelID, MessageID, EncodedReact), "DELETE", Cache.Token, "", Cache.Proxy, Cache.Timeout, Cache.UserAgent);

    }
}