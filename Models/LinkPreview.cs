using HtmlAgilityPack;
using System;

namespace MyPortfolio.Models
{
    public class LinkPreview
    {
        public static  string getLinkPreview(String url)
        {
            try
            {
                var web = new HtmlWeb();
                var doc = web.Load(url);
                var titleNode = doc.DocumentNode.SelectSingleNode("//title");
                return titleNode != null ? titleNode.InnerText : "No title found";
            }
            catch (Exception ex)
            {
                return $"Error fetching link preview: {ex.Message}";
            }
        }
    }
}