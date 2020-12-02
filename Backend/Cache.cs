/*
 * Class : Cache
 * Desc. : Mettre en cache les reponsses des requêtes sans avoir à le tapper 10k fois
 * Author: Zenrox
 * Date  : 02/12/2020 - 22h
*/

using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace DiscordREQ.Backend
{
    public class Cache
    {
        internal static List<string> GroupUser            = new List<string>();
        public static string GroupName                    { get; internal set; }
        public static string GroupIcon                    { get; internal set; }
        public static string GroupDmID                    { get; internal set; }

        public static string GuildName                    { get; internal set; }
        public static string GuildIcon                    { get; internal set; }
        public static string GuildDescription             { get; internal set; }


        public static string XFingerPrint                 { get; internal set; }
        public static bool Threaded                       { get; internal set; }
        public static string ProxyType                    { get; internal set; }

        public static int Timeout                         { get; internal set; }
        public static string Token                        { get; internal set; }
        public static string Proxy                        { get; internal set; }
        public static string UserAgent                    { get; internal set; }
        public static string LastedGroupId                { get; internal set; }
        public static string LastedStatusType             { get; internal set; }
        public static string LastedMessageId              { get; internal set; }
        public static string LastedRequestResp            { get; internal set; }
        public static string LastedErrorMessage           { get; internal set; }
        public static string LastedActionReason           { get; internal set; }
        public static string LastedMessageContent         { get; internal set; }
        public static string LastedMessageDeleteId        { get; internal set; }
        public static string LastedCreatedItemName        { get; internal set; }
        public static string LastedMessageChannelId       { get; internal set; }
        public static string LastedCreatedServerTemplate  { get; internal set; }
        public static bool LastedMessageAsEveryoneMention { get; internal set; }
        public static string LastedMessageDeleteChannelId { get; internal set; }


        internal static void CacheResponsse(string ResponseData)
        {
            LastedRequestResp = ResponseData;

            try
            {
                dynamic JsonResp = JObject.Parse(ResponseData);

                try { LastedGroupId                  = JsonResp["id"]; } catch { }
                try { LastedMessageId                = JsonResp["id"];                   } catch { }
                try { LastedCreatedItemName          = JsonResp["name"];                 } catch { }
                try { LastedActionReason             = JsonResp["reason"];               } catch { }
                try { LastedMessageContent           = JsonResp["content"];              } catch { }
                try { LastedStatusType               = JsonResp["status"];               } catch { }
                try { LastedMessageChannelId         = JsonResp["channel_id"];           } catch { }
                try { LastedMessageAsEveryoneMention = JsonResp["mention_everyone"];     } catch { }
                try { LastedCreatedServerTemplate    = JsonResp["guild_template_code"];  } catch { }
            }
            catch { }
        }
    }
}
