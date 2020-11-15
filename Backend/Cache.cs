/*
 * Class : Cache
 * Desc. : Mettre en cache les reponsses des requêtes sans avoir à le tapper 10k fois
 * Author: Zenrox
 * Date  : 14/11/2020 - 20h
*/

using Newtonsoft.Json.Linq;

namespace DiscordREQ.Backend
{
    public class Cache
    {
        public static int Timeout                         { get; internal set; }
        public static string Token                        { get; internal set; }
        public static string Proxy                        { get; internal set; }
        public static string UserAgent                    { get; internal set; }
        public static string LastedStatusType             { get; internal set; }
        public static string LastedMessageId              { get; internal set; }
        public static string LastedRequestResp            { get; internal set; }
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
