/*
 * Class : Message
 * Desc. : Classe contenant les methode en rapport avec les messages
 * Author: Zenrox, Monstered
 * Date  : 15/11/2020 - 18h
*/

using DiscordREQ.Backend.DiscordAPI;

namespace DiscordREQ.Modules
{
    internal class Message
    {
        internal static void SendMessage(string Message, string Channel, bool tts = false) => Request.SendRequest(APIChannels.SendMessageUrl(Channel), "POST", $"\"content\":\"{Message}\", \"nonce\":\"{Channel}\",\"tts\": \"{tts}\"");
        internal static void DeleteMessage(string MessageID, string Channel) => Request.SendRequest(APIChannels.EditMessageUrl(MessageID, Channel), "DELETE");
        internal static void Typing(string ChannelID) => Request.SendRequest(APIChannels.TypingMessageUrl(ChannelID), "POST");
        internal static void PinsMessage(string MessageID, string ChannelID) => Request.SendRequest(APIChannels.PinsMessUrl(ChannelID, MessageID), "PUT");
        internal static void UnPinsMessage(string MessageID, string ChannelID) => Request.SendRequest(APIChannels.PinsMessUrl(ChannelID, MessageID), "DELETE");
        internal static void SetReaction(string MessageID, string ChannelID, string EncodedReact) => Request.SendRequest(APIChannels.SetReactUrl(ChannelID, MessageID, EncodedReact), "PUT");
        internal static void RemoveReaction(string MessageID, string ChannelID, string EncodedReact) => Request.SendRequest(APIChannels.SetReactUrl(ChannelID, MessageID, EncodedReact), "DELETE");
        internal static void EditMessage(string NewMessage, string MessageID, string ChannelID) => Request.SendRequest(APIChannels.EditMessageUrl(ChannelID, MessageID), "PATCH", $"\"content\":\"{NewMessage}\"");
    }
}