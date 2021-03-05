using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using ScrapySharp.Network;

namespace WebScrap_Mono
{
    class Program
    {

        static ScrapingBrowser _scrapingBrowser = new ScrapingBrowser();

        static void Main(string[] args)
        {
            GetDramRec("https://www23.estrenosdoramas.net/");
        }

        static List<string> GetMainPageLinks(string url)
        {
            var homePageLinks = new List<string>();
            var html = GetHtml(url);
            var links = html.CssSelect("#dramaslist > li > a");

            foreach (var link in links)
            {
                if (link.Attributes["href"].Value.Contains(".html"))
                {
                    homePageLinks.Add(link.InnerText);
                }
            }
            return homePageLinks;
        }

        static List<DramDetails> GetDramDetails (string url)
        {
            var listDramDeatails = new List<DramDetails>();
            var html = GetHtml(url);
            var links = html.CssSelect("#dramaslist > li > a");

            foreach (var link in links)
            {
                if (link.Attributes["href"].Value.Contains(".html"))
                {
                    var dramDetails = new DramDetails();

                    dramDetails.Name = link.InnerText;
                    dramDetails.link = link.Attributes["href"].Value;

                    listDramDeatails.Add(dramDetails);
                }
            }
            return listDramDeatails;
        }

        static List<ReciDetails> GetDramRec(string url)
        {
            var listReciDetails = new List<ReciDetails>();
            //var listDramDeatails = new List<string>();
            var html = GetHtml(url);
            var links = html.CssSelect("#main-wrapper > div.portada-cap > div.label_with_thumbs > div.thumb-cap ");

            foreach (var link in links)
            {
                var _a = link.CssSelect("a").First();
                var _strong = link.CssSelect("strong").First();
                
                var reciDetails = new ReciDetails();

                reciDetails.Name = _strong.CssSelect("a").First().InnerText;
                reciDetails.link = _a.Attributes["href"].Value;
                reciDetails.Photo = _a.CssSelect("img").First().Attributes["src"].Value;


                listReciDetails.Add(reciDetails);
              
            }
            return listReciDetails;
        }

        static HtmlNode GetHtml(string url)
        {
            WebPage webPage = _scrapingBrowser.NavigateToPage(new Uri(url));
            return webPage.Html;
        }

        public class DramDetails
        {
            public string Name { get; set; }
            public string link { get; set; }
        }

        public class ReciDetails
        {
            public string Name { get; set; }
            public string link { get; set; }
            public string Photo { get; set; }
        }
    }
}
