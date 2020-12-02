/*
 * Class : Group
 * Desc. : Classe contenant les methode en rapport avec les paramètres du compte
 * Author: Zenrox, Monstered
 * Date  : 02/12/2020 - 22h
*/

using DiscordREQ.Backend.DiscordAPI;

namespace DiscordREQ.Modules
{
    internal class UserSettings
    {
        internal static void SetStatus(string Status) => Request.SendRequest(APIUsers.SetStatus(), "PATCH", $"\"status\": \"{Status}\"");
        internal static void SetCustomStatus(string Text, string Expire) => Request.SendRequest(APIUsers.SetStatus(), "PATCH", $"\"text\": \"{Text}\", \"expires_at\": \"{Expire}\"");
        internal static void SetTheme(string Theme) => Request.SendRequest(APIUsers.SetStatus(), "PATCH", $"\"theme\":\"{Theme}\"");
        internal static void SetDev(bool DevMode) => Request.SendRequest(APIUsers.SetStatus(), "PATCH", $"\"developer_mode\":\"{DevMode}\"");
        internal static void SetUsername(string Name, string Pwd) => Request.SendRequest(APIUsers.SetStatus(), "PATCH", $"\"username\":\"{Name}\", \"password\":\"{Pwd}\"");
        internal static void SetLanguage(string Langue) => Request.SendRequest(APIUsers.SetStatus(), "PATCH", $"\"locale\":\"{Langue}\"");
        internal static void SetDisplayCompact(bool Display) => Request.SendRequest(APIUsers.SetStatus(), "PATCH", $"\"message_display_compact\":\"{Display}\"");
        internal static void SetAnimateStickers(string Choice) => Request.SendRequest(APIUsers.SetStatus(), "PATCH", $"\"animate_stickers\":\"{Choice}\""); // 1, 2 or 3
        internal static void SetContentFilter(string Filter) => Request.SendRequest(APIUsers.SetStatus(), "PATCH", $"\"explicit_content_filter\":\"{Filter}\""); // 1, 2 or 3
        internal static void SetDisable(string Pwd) => Request.SendRequest(APIUsers.SetDisable(), "POST", $"\"password\":\"{Pwd}\"");
        internal static void SetDelete(string Pwd) => Request.SendRequest(APIUsers.SetDelete(), "POST", $"\"password\":\"{Pwd}\"");
    }
}
