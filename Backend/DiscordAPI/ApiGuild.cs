/*
 * Class : API GUILD
 * Desc. : Manadger les versions de l'api plus simplement
 * Author: Zenrox, Monstered
 * Date  : 15/11/2020 - 03h
*/

namespace DiscordREQ.Backend.DiscordAPI
{
    internal class ApiGuild
    {
        internal static string SetReactUrl(string ChannelID, string MessageID, string EncodedReaction)
        {
            return URI.SetReactUrl.Replace("ENCODEDREACT", EncodedReaction).Replace("CHANID", ChannelID).Replace("MSGID", MessageID);
        }

        internal static string SetPermChanUrl(string ChannelID, string RoleID)
        {
            return URI.SetPermChanUrl.Replace("CHANID", ChannelID).Replace("ROLID", RoleID);
        }

        internal static string PinsMessUrl(string ChannelID, string MessageID)
        {
            return URI.PinsMessUrl.Replace("CHANID", ChannelID).Replace("MESSID", MessageID);
        }

        internal static string CreateWebhookUrl(string ChannelID)
        {
            return URI.CreateWebhookUrl.Replace("CHANID", ChannelID);
        }

        internal static string SendMessageUrl(string ChannelID)
        {
            return URI.SendMessageUrl.Replace("CHANID", ChannelID);
        }

        internal static string TypingMessageUrl(string ChannelID)
        {
            return URI.TypingMessageUrl.Replace("CHANID", ChannelID);
        }

        internal static string GroupChannelUrl(string GroupChannelID)
        {
            return URI.GroupChannelUrl.Replace("CHANID", GroupChannelID);
        }
    }
}