/*
 * Class : API WEBHOOCK
 * Desc. : Manadger les versions de l'api plus simplement
 * Author: Zenrox & Monstered
 * Date  : 15/11/2020 - 06h10
*/

namespace DiscordREQ.Backend.DiscordAPI
{
    internal class ApiWebhoock
    {
        internal static string DeleteWebhookUrl(string WebhookID)
        {
            return URI.WebhookUrl.Replace("WBHID", WebhookID);
        }
    }
}