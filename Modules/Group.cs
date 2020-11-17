/*
 * Class : Group
 * Desc. : Classe contenant les methode en rapport avec les groupes
 * Author: Zenrox, Monstered
 * Date  : 15/11/2020 - 21h
*/

using DiscordREQ.Backend.DiscordAPI;

namespace DiscordREQ.Modules
{
    internal class Group
    {
        internal static void AddUserFromGroup(string UserID, string GroupID) => Request.SendRequest(APIChannels.KickAddUserGroupUrl(GroupID, UserID), "PUT");
        internal static void KickUserFromGroup(string UserID, string GroupID) => Request.SendRequest(APIChannels.KickAddUserGroupUrl(GroupID, UserID), "DELETE");
        internal static void CreateGroup(string DmID, string UserID) => Request.SendRequest(ApiGuild.CreateGroupUrl(DmID, UserID), "PUT");
        internal static void RenameGroup(string NewName, string GroupID) => Request.SendRequest(APIChannels.GroupChannelUrl(GroupID), "PATCH", $"\"name\": \"{NewName}\"");
        internal static void ChangeGroupIcon(string Icon, string GroupID) => Request.SendRequest(APIChannels.GroupChannelUrl(GroupID), "PATCH", $"\"icon\": \"{Icon}\"");
    }
}