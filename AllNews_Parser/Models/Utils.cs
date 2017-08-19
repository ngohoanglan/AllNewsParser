using AllNews_Parser.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace AllNews_Parser.Models
{
    public class Utils
    {
        public void ImportDataFromXMLFile()
        {
            AllNewsContext context = new AllNewsContext();
            // XmlTextReader reader = new XmlTextReader(Server.MapPath("~/App_data/Data.xml"));
            XmlDocument doc = new XmlDocument();
            doc.Load(System.Web.Hosting.HostingEnvironment.MapPath("~/App_data/Data.xml"));
            XmlNodeList nodes = doc.SelectNodes("//Site");
            foreach (XmlNode node in nodes)
            {
                Site site = new Site();
                site.CountryCode = node.ParentNode.Attributes["code"].Value;
                site.SiteName = node.Attributes["name"].Value;
                site.SiteURL = node.Attributes["url"].Value;
                if (context.Sites.Where(it => it.SiteURL == site.SiteURL).FirstOrDefault() == null)
                {
                    context.Sites.Add(site);
                    context.SaveChanges();
                    int siteID = site.ID;
                    XmlNodeList siteItemNodes = node.SelectNodes("./Item");
                    foreach (XmlNode itemNode in siteItemNodes)
                    {
                        SiteItem item = new SiteItem();
                        item.SiteID = siteID;
                        item.SiteItemName = itemNode.Attributes["name"].Value;
                        item.SiteItemURL = itemNode.Attributes["url"].Value;
                        item.Regex = itemNode.Attributes["regex"].Value;
                        item.TitleRegex = itemNode.Attributes["TitleRegex"].Value;
                        item.LinkRegex = itemNode.Attributes["LinkRegex"].Value;
                        item.ImageRegex = itemNode.Attributes["ImageRegex"].Value;
                        item.ContentRegex = itemNode.Attributes["DescriptionRegex"].Value;
                        item.PubdateRegex = itemNode.Attributes["PubdateRegex"].Value;
                        if (context.SiteItems.Where(it => it.SiteItemURL == item.SiteItemURL).FirstOrDefault() == null)
                        {
                            context.SiteItems.Add(item);
                            context.SaveChanges();
                        }
                    }
                }
;
            }
        }
    }
}