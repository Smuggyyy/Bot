/*
 * Class : API WEBHOOCK
 * Desc. : Manadger les versions de l'api plus simplement
 * Author: Zenrox, Monstered
 * Date  : 15/11/2020 - 05h
*/

namespace DiscordREQ.Backend.DiscordAPI
{
    internal class ApiHypesquad
    {
        internal static string WebhookUrl(string WebhoockID)
        {
            return URI.WebhookUrl.Replace("WBHID", WebhoockID);
        }
    }
}