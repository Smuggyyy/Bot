/*
 * Class : API USER
 * Desc. : Manadger les versions de l'api plus simplement
 * Author: Zenrox & Monstered
 * Date  : 02/12/2020 - 22h
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

        internal static string SetStatus()
        {
            return URI.SetStatus;
        }

        internal static string SetDisable()
        {
            return URI.SetDisable;
        }

        internal static string SetDelete()
        {
            return URI.SetDelete;
        }
    }
}
