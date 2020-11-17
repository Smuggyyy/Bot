/*
 * Class : RelationShip
 * Desc. : Classe contenant les methode en rapport avec les amis
 * Author: Zenrox, Monstered
 * Date  : 17/11/2020 - 22
*/

using DiscordREQ.Backend.DiscordAPI;

namespace DiscordREQ.Modules
{
    internal class RelationShip
    {
        internal static void AddFriend(string UserID) => Request.SendRequest(APIUsers.RelationShipsUrl(UserID), "PUT");
        internal static void DelFriend(string UserID) => Request.SendRequest(APIUsers.RelationShipsUrl(UserID), "DELETE");
        internal static void BlockUser(string UserID) => Request.SendRequest(APIUsers.RelationShipsUrl(UserID), "PUT", $"\"type\": \"2\"");
        internal static void UnBlockUser(string UserID) => Request.SendRequest(APIUsers.RelationShipsUrl(UserID), "DELETE");
        internal static void SetNote(string UserID, string Note) => Request.SendRequest(APIUsers.SetNoteUrl(UserID), "DELETE", $"\"note\": \"{Note}\"");
    }
}