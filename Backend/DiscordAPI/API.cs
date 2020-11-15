/*
 * Class : API
 * Desc. : Manadger les versions de l'api plus simplement
 * Author: Zenrox
 * Date  : 14/11/2020 - 20h
*/

namespace DiscordREQ.Backend.DiscordAPI
{
    internal class API
    {
        internal static string JoinServerURL(string InviteCode)
        {
            return URI.JoinServerUrl.Replace("INVCODE", InviteCode);
        }

        internal static string LeaveServerUrl(string ServerID)
        {
            return URI.LeaveServerUrl.Replace("SERVID", ServerID);
        }

        internal static string SendMessageUrl(string ChannelID)
        {
            return URI.SendMessageUrl.Replace("CHANID", ChannelID);
        }

        internal static string DeleteMessageUrl(string MessageID, string ChannelID)
        {
            string url = URI.DeleteMessageUrl.Replace("CHANID", ChannelID);
            return url.Replace("MESSID", MessageID);
        }

        internal static string TypingMessageUrl(string ChannelID)
        {
            return URI.TypingMessageUrl.Replace("CHANID", ChannelID);
        }
    }
}