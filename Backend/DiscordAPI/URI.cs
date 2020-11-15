/*
 * Class : API
 * Desc. : Manadger les liens de l'api plus simplement
 * Author: Zenrox
 * Date  : 14/11/2020 - 20h
*/


namespace DiscordREQ.Backend.DiscordAPI
{
    internal class URI
    {
        internal static string BaseUrl = "https://discord.com/api/v8";


        internal static string TypingMessageUrl = $"{BaseUrl}/channels/CHANID/typing";
        internal static string DeleteMessageUrl = $"{BaseUrl}/channels/CHANID/messages/MESSID";
        internal static string SendMessageUrl   = $"{BaseUrl}/channels/CHANID/messages";
        internal static string LeaveServerUrl   = $"{BaseUrl}/users/@me/guilds/SERVID";
        internal static string JoinServerUrl    = $"{BaseUrl}/invites/INVCODE";
        
        // internal static string Url = $"{BaseUrl}/";
    }
}