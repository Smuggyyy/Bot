/*
 * Class : API
 * Desc. : Manadger les versions de l'api plus simplement
 * Author: Zenrox & Monstered
 * Date  : 15/11/2020 - 03h
*/

namespace DiscordREQ.Backend.DiscordAPI
{
    internal class APIChannels
    {
        internal static string SetReactUrl(string ChannelID, string MessageID, string EncodeReact)
        {
            return URI.SetReactUrl.Replace("CHANID", ChannelID).Replace("MSGID", MessageID).Replace("ENCODEDREACT", EncodeReact);
        }
        internal static string SetPermChanUrl(string ChannelID, string RoleID)
        {
            return URI.SetPermChanUrl.Replace("CHANID", ChannelID).Replace("ROLID", RoleID);
        }
        internal static string KickAddUserGroupUrl(string ChannelID, string UserID)
        {
            return URI.KickAddUserGroupUrl.Replace("CHANID", ChannelID).Replace("USRID", UserID);
        }
        internal static string EditMessageUrl(string ChannelID, string MessageID)
        {
            return URI.EditMessageUrl.Replace("CHANID", ChannelID).Replace("USRID", MessageID);
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
        internal static string GroupChannelUrl(string ChannelID)
        {
            return URI.GroupChannelUrl.Replace("CHANID", ChannelID);
        }
    }
}