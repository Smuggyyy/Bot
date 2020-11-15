/*
 * Class : API GUILD
 * Desc. : Manadger les versions de l'api plus simplement
 * Author: Zenrox, Monstered
 * Date  : 15/11/2020 - 05h
*/

namespace DiscordREQ.Backend.DiscordAPI
{
    internal class ApiGuild
    {
        internal static string KickUserUrl(string ServerID, string UserID, string Raison)
        {
            return URI.KickUserUrl.Replace("SERVID", ServerID).Replace("USRID", UserID).Replace("RSON", Raison);
        }
        internal static string DelTemplateUrl(string ServerID, string TemplateLink)
        {
            return URI.DelTemplateUrl.Replace("SERVID", ServerID).Replace("TMPLINK", TemplateLink);
        }
        internal static string DelEmojiUrl(string ServerID, string Emoji)
        {
            return URI.DelEmojiUrl.Replace("SERVID", ServerID).Replace("EMOJI", Emoji);
        }
        internal static string RoleServerUrl(string ServerID, string RoleID)
        {
            return URI.RoleServerUrl.Replace("SERVID", ServerID).Replace("ROLID", RoleID);
        }
        internal static string BanUrl(string ServerID, string UserID)
        {
            return URI.BanUrl.Replace("SERVID", ServerID).Replace("USRID", UserID);
        }
        internal static string UseTemplateUrl(string TemplateLink)
        {
            return URI.UseTemplateUrl.Replace("TMPLINK", TemplateLink);
        }
        internal static string CreateTemplateUrl(string ServerID)
        {
            return URI.CreateTemplateUrl.Replace("SERVID", ServerID);
        }
        internal static string CreateChannelUrl(string ServerID)
        {
            return URI.CreateChannelUrl.Replace("SERVID", ServerID);
        }
        internal static string DeleteGuildUrl(string ServerID)
        {
            return URI.DeleteGuildUrl.Replace("SERVID", ServerID);
        }
        internal static string CreateRoleUrl(string ServerID)
        {
            return URI.CreateRoleUrl.Replace("SERVID", ServerID);
        }
        internal static string ChangeGuildSettingsUrl(string ServerID)
        {
            return URI.ChangeGuildSettingsUrl.Replace("SERVID", ServerID);
        }
        internal static string JoinServerUrl(string InviteCode)
        {
            string url = URI.JoinServerUrl.Replace("INVCODE", InviteCode);
            System.Console.WriteLine(url);
            return url;
        }
        internal static string LeaveServerUrl(string ServerID)
        {
            return URI.LeaveServerUrl.Replace("SERVID", ServerID);
        }
    }
}