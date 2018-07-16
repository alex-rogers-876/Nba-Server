using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Nba.Core.CustomWebClient
{
    public class CustomWebClient : ICustomWebClient
    {

        public string GetResponse(string url)
        {
            using (var client = new WebClient())
            {
                client.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_9_1) AppleWebKit/537.73.11 (KHTML, like Gecko) Version/7.0.1 Safari/537.73.11");
                client.Headers.Add(HttpRequestHeader.Accept, "text/html, application/xhtml+xml, /");
                client.Headers.Add(HttpRequestHeader.AcceptLanguage, "en-GB");

                // client2.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip, deflate");
                var response = client.DownloadString(url);
                return response;
            }
        }
    }
}
