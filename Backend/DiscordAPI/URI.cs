/*
 * Class : API
 * Desc. : Manadger les liens de l'api plus simplement
 * Author: Zenrox & Monstered
 * Date  : 15/11/2020 - 03h
*/


namespace DiscordREQ.Backend.DiscordAPI
{
    internal class URI
    {
        //| BASE URL |\\
        internal static string BaseUrl = "https://discord.com/api/v8";


        //| CHANNEL URI |\\
        internal static string SetReactUrl            = $"{BaseUrl}/channels/CHANID/messages/MSGID/reactions/ENCODEDREACT";
        internal static string SetPermChanUrl         = $"{BaseUrl}/channels/CHANID/permissions/ROLID";
        internal static string KickAddUserGroupUrl    = $"{BaseUrl}/channels/CHANID/recipients/USRID";
        internal static string EditMessageUrl         = $"{BaseUrl}/channels/CHANID/messages/MESSID";
        internal static string PinsMessUrl            = $"{BaseUrl}/channels/CHANID/pins/MESSID";
        internal static string CreateWebhookUrl       = $"{BaseUrl}/channels/CHANID/webhooks";
        internal static string SendMessageUrl         = $"{BaseUrl}/channels/CHANID/messages";
        internal static string TypingMessageUrl       = $"{BaseUrl}/channels/CHANID/typing";
        internal static string GroupChannelUrl        = $"{BaseUrl}/channels/CHANID";


        //| GUILD URI |\\
        internal static string KickUserUrl            = $"{BaseUrl}/guilds/SERVID/members/USRID?reason=RSON";
        internal static string DelTemplateUrl         = $"{BaseUrl}/guilds/SERVID/templates/TMPLINK";
        internal static string RoleMemberUrl          = $"{BaseUrl}/guilds/SERVID/members/USRID";
        internal static string DelEmojiUrl            = $"{BaseUrl}/guilds/SERVID/emojis/EMOJI";
        internal static string RoleServerUrl          = $"{BaseUrl}/guilds/SERVID/roles/ROLID";
        internal static string BanUrl                 = $"{BaseUrl}/guilds/SERVID/bans/USRID";
        internal static string UseTemplateUrl         = $"{BaseUrl}/guilds/templates/TMPLINK";
        internal static string CreateTemplateUrl      = $"{BaseUrl}/guilds/SERVID/templates";
        internal static string CreateChannelUrl       = $"{BaseUrl}/guilds/SERVID/channels";
        internal static string DeleteGuildUrl         = $"{BaseUrl}/guilds/SERVID/delete";
        internal static string CreateRoleUrl          = $"{BaseUrl}/guilds/SERVID/roles";
        internal static string ChangeGuildSettingsUrl = $"{BaseUrl}/guilds/SERVID";
        internal static string CreateGuildUrl         = $"{BaseUrl}/guilds";


        //| USERS URI |\\
        internal static string RelationShipsUrl       = $"{BaseUrl}/users/@me/relationships/USRID";
        internal static string LeaveServerUrl         = $"{BaseUrl}/users/@me/guilds/SERVID";
        internal static string SetNoteUrl             = $"{BaseUrl}/users/@me/notes/USRID";
        internal static string GroupUrl               = $"{BaseUrl}/users/@me/channels";


        //| HYPESQUAD URI |\\
        internal static string HypeSquadUrl           = $"{BaseUrl}/hypesquad/online";


        //| WEBHOOCK URI |\\
        internal static string WebhookUrl             = $"{BaseUrl}/webhooks/WBHID";


        //| INVITE URI |\\
        internal static string JoinServerUrl          = $"{BaseUrl}/invites/INVCODE";
    }
}