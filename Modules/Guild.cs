using DiscordREQ.Backend.DiscordAPI;
using DiscordREQ.Backend;

namespace DiscordREQ.Modules
{
    internal class Guild
    {
        public Guild(string Name = "DiscordREQ", string Description = "Guild Created by DiscordREQ", string Icon = "")
        {
            Cache.GuildName = Name;
            Cache.GuildDescription = Description;
            Cache.GuildIcon = Icon;
        }

        internal static void JoinServer(string InviteCode) => Request.SendRequest(ApiGuild.JoinServerUrl(InviteCode), "POST");
        internal static void LeaveServer(string ServerID) => Request.SendRequest(ApiGuild.LeaveServerUrl(ServerID), "DELETE");
        internal static void DeleteServer(string ServerID) => Request.SendRequest(ApiGuild.DeleteGuildUrl(ServerID), "POST");
        internal static void KickUser(string Server, string UserID, string Reason) => Request.SendRequest(ApiGuild.KickUserUrl(Server, UserID, Reason), "DELETE");
        internal static void BanUser(string GuildID, string UserID, string DelMessDay, string Reason) => Request.SendRequest(ApiGuild.BanUrl(GuildID, UserID), "PUT", $"\"delete_message_days\":\"{DelMessDay}\", \"reason\": \"{Reason}\"");
        internal static void UnBanUser(string GuildID, string UserID) => Request.SendRequest(ApiGuild.BanUrl(GuildID, UserID), "DELETE");
        internal static void CreateRole(string ServerID, string Name) => Request.SendRequest(ApiGuild.CreateRoleUrl(ServerID), "POST", $"\"name\":\"{Name}\"");
        internal static void DeleteRole(string GuildID, string RoleID) => Request.SendRequest(ApiGuild.RoleServerUrl(GuildID, RoleID), "DELETE");
        internal static void EditRole(string GuildID, string RoleID, string Name = "", string Permission = "", string Color = "", bool ping = false, bool hoist = false) => Request.SendRequest(ApiGuild.RoleServerUrl(GuildID, RoleID), "PATCH", $"\"name\":\"{Name}\", \"permissions\":\"{Permission}\", \"color\":\"{Color}, \"hoist\":\"{hoist}\", \"mentionable\":\"{ping}\"");
        internal static void DeleteEmoji(string GuildID, string Emoji) => Request.SendRequest(ApiGuild.DelEmojiUrl(GuildID, Emoji), "DELETE");
        internal static void CreateTemplate(string GuildID, string Name, string Description) => Request.SendRequest(ApiGuild.CreateTemplateUrl(GuildID), "POST", $"\"name\":\"{Name}\", \"description\":\"{Description}\"");
        internal static void UseTemplate(string TemplateCode, string Name, string Icon) => Request.SendRequest(ApiGuild.UseTemplateUrl(TemplateCode), "POST", $"\"name\":\"{Name}\", \"icon\":\"{Icon}\"");
        internal static void DeleteTemplate(string GuildID, string TemplateCode) => Request.SendRequest(ApiGuild.DelTemplateUrl(GuildID, TemplateCode), "DELETE");
        internal static void AddRole(string GuildID, string UserID, string RoleID) => Request.SendRequest(ApiGuild.RoleServerUrl(GuildID, UserID), "PATCH", $"\"roles\":\"{RoleID}\"");
        internal static void RemoveRole(string GuildID, string UserID) => Request.SendRequest(ApiGuild.RoleServerUrl(GuildID, UserID), "PATCH");
        internal static void SetName(string GuildID, string Name) => Request.SendRequest(ApiGuild.ChangeGuildSettingsUrl(GuildID), "PATCH", $"\"name\":\"{Name}\"");
        internal static void SetDescription(string GuildID, string Description) => Request.SendRequest(ApiGuild.ChangeGuildSettingsUrl(GuildID), "PATCH", $"\"description\":\"{Description}\"");
        internal static void SetIcon(string GuildID, string Icon) => Request.SendRequest(ApiGuild.ChangeGuildSettingsUrl(GuildID), "PATCH", $"\"icon\":\"{Icon}\"");
        internal static void SetSplash(string GuildID, string Splash) => Request.SendRequest(ApiGuild.ChangeGuildSettingsUrl(GuildID), "PATCH", $"\"splash\":\"{Splash}\"");
        internal static void SetBanner(string GuildID, string Banner) => Request.SendRequest(ApiGuild.ChangeGuildSettingsUrl(GuildID), "PATCH", $"\"banner\":\"{Banner}\"");
        internal static void SetRegion(string GuildID, string Region) => Request.SendRequest(ApiGuild.ChangeGuildSettingsUrl(GuildID), "PATCH", $"\"region\":\"{Region}\"");
        internal static void SetFeatures(string GuildID, string Features) => Request.SendRequest(ApiGuild.ChangeGuildSettingsUrl(GuildID), "PATCH", $"\"features\":\"{Features}\"");
        internal static void SetAfkChannel(string GuildID, string AfkChan) => Request.SendRequest(ApiGuild.ChangeGuildSettingsUrl(GuildID), "PATCH", $"\"afk_channel_id\":\"{AfkChan}\"");
        internal static void SetAfkTime(string GuildID, string Timeout) => Request.SendRequest(ApiGuild.ChangeGuildSettingsUrl(GuildID), "PATCH", $"\"afk_timeout\":\"{Timeout}\"");
        internal static void VerificationLevel(string GuildID, string VerificationLevel) => Request.SendRequest(ApiGuild.ChangeGuildSettingsUrl(GuildID), "PATCH", $"\"verification_level\":\"{VerificationLevel}\"");
        internal static void SetMessNotif(string GuildID, string Notification) => Request.SendRequest(ApiGuild.ChangeGuildSettingsUrl(GuildID), "PATCH", $"\"default_message_notifications\":\"{Notification}\"");
        internal static void SetContentFilter(string GuildID, string ContentFilter) => Request.SendRequest(ApiGuild.ChangeGuildSettingsUrl(GuildID), "PATCH", $"\"explicit_content_filter\":\"{ContentFilter}\"");
        internal static void SetRoleName(string GuidlID, string RoleID, string Name) => Request.SendRequest(ApiGuild.RoleServerUrl(GuidlID, RoleID), "PATCH", $"\"name\":\"{Name}\"");
        internal static void SetRolePerm(string GuidlID, string RoleID, string Perm) => Request.SendRequest(ApiGuild.RoleServerUrl(GuidlID, RoleID), "PATCH", $"\"permissions\":\"{Perm}\"");
        internal static void SetRoleColor(string GuidlID, string RoleID, string Color) => Request.SendRequest(ApiGuild.RoleServerUrl(GuidlID, RoleID), "PATCH", $"\"color\":\"{Color}\"");
        internal static void SetRoleHoist(string GuidlID, string RoleID, bool Hoist) => Request.SendRequest(ApiGuild.RoleServerUrl(GuidlID, RoleID), "PATCH", $"\"hoist\":\"{Hoist}\"");
        internal static void SetRoleping(string GuidlID, string RoleID, bool Ping) => Request.SendRequest(ApiGuild.RoleServerUrl(GuidlID, RoleID), "PATCH", $"\"mentionable\":\"{Ping}\"");
    }
}