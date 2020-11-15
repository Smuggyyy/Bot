using DiscordREQ.Backend.DiscordAPI;
using DiscordREQ.Backend;

namespace DiscordREQ.Modules
{
    internal class Guild
    {
        internal static void JoinServer(string InviteCode) => Request.SendRequest(ApiGuild.JoinServerUrl(InviteCode), "POST", Cache.Token, "", Cache.Proxy, Cache.Timeout, Cache.UserAgent);
        internal static void LeaveServer(string ServerID) => Request.SendRequest(ApiGuild.LeaveServerUrl(ServerID), "DELETE", Cache.Token, "", Cache.Proxy, Cache.Timeout, Cache.UserAgent);
    }
}