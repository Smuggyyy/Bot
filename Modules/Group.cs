using DiscordREQ.Backend.DiscordAPI;
using DiscordREQ.Backend;

namespace DiscordREQ.Modules
{
    internal class Group
    {
        public static void AddUserFromGroup(string UserID, string GroupID) => Request.SendRequest(APIChannels.KickAddUserGroupUrl(GroupID, UserID), "PUT", Cache.Token, "", Cache.Proxy, Cache.Timeout, Cache.UserAgent);
        public static void KickUserFromGroup(string UserID, string GroupID) => Request.SendRequest(APIChannels.KickAddUserGroupUrl(GroupID, UserID), "DELETE", Cache.Token, "", Cache.Proxy, Cache.Timeout, Cache.UserAgent);
    }
}