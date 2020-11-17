/*
 * Class : Request
 * Desc. : Faire très simplement une requête en 1 seul ligne, return TRUE si la reqûete c'est bien passer return FALSE si une erreur est survenue. La reponsse est stocker dans la variable LastedRequestResp
 * Author: Zenrox
 * Date  : 15/2020 - 18h
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
        internal static bool SendRequest(string url, string Method, string Data = "")
        {
            try
            {
                var Request = (HttpWebRequest)WebRequest.Create(url);
                var RequestData = Encoding.ASCII.GetBytes("{" + Data + "}");

                if (Cache.Proxy != "")
                    Request.Proxy = new WebProxy(Cache.Proxy.Split(':')[0], Convert.ToInt32(Cache.Proxy.Split(':')[1]));

                Request.Method = Method;
                Request.Timeout = Cache.Timeout;
                Request.UserAgent = Cache.UserAgent;
                Request.ContentLength = RequestData.Length;
                Request.ContentType = "application/json";
                Request.Headers.Add("authorization", Cache.Token);

                using (var stream = Request.GetRequestStream()) { stream.Write(RequestData, 0, RequestData.Length); }
                var Response = new StreamReader(Request.GetResponse().GetResponseStream()).ReadToEnd();

                Cache.CacheResponsse(Response);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Cache.LastedErrorMessage = e.ToString();
                return false;
            }
        }
    }
}