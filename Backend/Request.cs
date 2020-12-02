/*
 * Class : Request
 * Desc. : Faire très simplement une requête en 1 seul ligne, return TRUE si la reqûete c'est bien passer return FALSE si une erreur est survenue. La reponsse est stocker dans la variable LastedRequestResp
 * Author: Zenrox
 * Date  : 02/12/2020 - 21h
 * Ajout : Thread, Support proxy socks4 & 5 | Proxy type & fingerprint personalisé
*/

using System.Threading;
using DiscordREQ.Backend;
using Leaf.xNet;
using System;

namespace DiscordREQ
{
    internal class Request
    {
        
        internal static bool SendRequest(string url, string Method, string Data = "")
        {
            switch (Cache.Threaded)
            {
                case true:
                    Thread Req = new Thread(() => PVSendRequest(url, Method, Data));
                    Req.Start();
                    return true;
                case false:
                    return PVSendRequest(url, Method, Data);
                default:
                    return PVSendRequest(url, Method, Data);
            }
        }

    private static bool PVSendRequest(string url, string Method, string Data = "")
        {
            using (HttpRequest Request = new HttpRequest())
            {
                try
                {
                    switch (Cache.ProxyType)
                    {
                        case "HTTP":
                            Request.Proxy = HttpProxyClient.Parse(Cache.Proxy);
                            break;
                        case "SOCKS4":
                            Request.Proxy = Socks4ProxyClient.Parse(Cache.Proxy);
                            break;
                        case "SOCKS5":
                            Request.Proxy = Socks5ProxyClient.Parse(Cache.Proxy);
                            break;
                        default:
                            Request.Proxy = null;
                            break;
                    }

                    Request.UserAgent = Cache.UserAgent;
                    Request.IgnoreProtocolErrors = true;
                    Request.ConnectTimeout = Cache.Timeout;
                    Request.UseCookies = true;
                    Request.KeepAlive = true;
                    Request.AddHeader("Authorization", Cache.Token);
                    Request.AddHeader("X-Fingerprint", Cache.XFingerPrint);

                    switch (Method)
                    {
                        case "GET":
                            Cache.CacheResponsse(Request.Get(url).ToString());
                            break;
                        case "PUT":
                            Cache.CacheResponsse(Request.Put(url).ToString());
                            break;
                        case "DELETE":
                            Cache.CacheResponsse(Request.Delete(url).ToString());
                            break;
                        case "PATCH":
                            Cache.CacheResponsse(Request.Patch(url).ToString());
                            break;
                    }

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
}
