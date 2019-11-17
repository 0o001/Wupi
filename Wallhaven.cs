using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace wupi
{
    class Wallhaven
    {
        private const string URL = "https://wallhaven.cc";
        private const string URL_RANDOM = URL + "/random";

        private const string HTML_TAG_PICTURE = "<img id=\"wallpaper\" src=\""; //html içerisinde linkin bulunduğu tag
        private const string HTML_TAG_PREVIEW = "<a class=\"preview\" href=\""; //html içerisinde linkin bulunduğu tag

        private static string GetHTML(Uri url)
        {
            WebRequest request = HttpWebRequest.Create(url);
            WebResponse response;
            response = request.GetResponse();
            StreamReader getResponse = new StreamReader(response.GetResponseStream()); //oluşan linkin html bilgisini al

            return getResponse.ReadToEnd();
        }

        private static Uri SubStringHTML(string html, string start, string end)
        {
            int firstIndex = html.IndexOf(start) + start.Length;
            int lastIndex = html.Substring(firstIndex).IndexOf(end);

            return new Uri(html.Substring(firstIndex, lastIndex));
        }

        public static Uri GetDownloadUrl(Uri url)
        {
            string html = GetHTML(url);

            return SubStringHTML(html, HTML_TAG_PICTURE, "\"");
        }

        public static Uri GetRandomUrl()
        {
            string html = GetHTML(new Uri(URL_RANDOM));

            return SubStringHTML(html, HTML_TAG_PREVIEW, "\"");
        }
    }
}
