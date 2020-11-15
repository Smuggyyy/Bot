/*
 * Class : Cache
 * Desc. : Faire très simplement une requête en 1 seul ligne, return TRUE si la reqûete c'est bien passer return FALSE si une erreur est survenue. La reponsse est stocker dans la variable LastedRequestResp
 * Author: Zenrox
 * Date  : 14/11/2020 - 20h
*/

using System;
using System.IO;
using System.Net;
using System.Text;
using DiscordREQ.Backend;

namespace DiscordREQ
{
    internal class Request
    {
        internal static bool SendRequest(string url, string Method, string Token, string Data = "", string Proxy = "", int Timeout = 1500, string UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36")
        {
            try
            {
                var Request = (HttpWebRequest)WebRequest.Create(url);
                var RequestData = Encoding.ASCII.GetBytes("{" + Data + "}");

                if (Proxy != "")
                    Request.Proxy = new WebProxy(Proxy.Split(':')[0], Convert.ToInt32(Proxy.Split(':')[1]));

                Request.Method = Method;
                Request.Timeout = Timeout;
                Request.UserAgent = UserAgent;
                Request.ContentLength = RequestData.Length;
                Request.ContentType = "application/json";
                Request.Headers.Add("authorization", Token);

                using (var stream = Request.GetRequestStream()) { stream.Write(RequestData, 0, RequestData.Length); }
                var Response = new StreamReader(Request.GetResponse().GetResponseStream()).ReadToEnd();

                Cache.CacheResponsse(Response);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }
    }
}