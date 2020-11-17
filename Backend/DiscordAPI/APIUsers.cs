/*
 * Class : API USER
 * Desc. : Manadger les versions de l'api plus simplement
 * Author: Zenrox & Monstered
 * Date  : 15/11/2020 - 06h
*/

namespace DiscordREQ.Backend.DiscordAPI
{
    internal class APIUsers
    {
        internal static string RelationShipsUrl(string UserID)
        {
            return URI.RelationShipsUrl.Replace("USRID", UserID);
        }

        internal static string SetNoteUrl(string UserID)
        {
            return URI.SetNoteUrl.Replace("USRID", UserID);
        }
    }
}