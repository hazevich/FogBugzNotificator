using FogBugzApi.Models;
using System;
using System.Collections.Generic;
using System.Xml;

namespace FogBugzApi.Helpers
{
    public class XmlConverter
    {
        public List<FogBugzCase> XmlToFugBugzCases(XmlDocument xml)
        {
            List<FogBugzCase> fbCases = new List<FogBugzCase>();


            XmlNode casesListParentNode = xml.SelectSingleNode("/response/cases");

            if (casesListParentNode != null)
            {
                XmlNodeList casesNodeList = casesListParentNode.SelectNodes("case");

                foreach (XmlNode c in casesNodeList)
                    fbCases.Add(new FogBugzCase
                    {
                        Id = Convert.ToInt32(c.Attributes["ixBug"].Value),
                        Title = c.SelectSingleNode("sTitle").InnerText,
                        Status = c.SelectSingleNode("sStatus").InnerText,
                        Priority = string.Format("{0} - {1}", c.SelectSingleNode("ixPriority").InnerText, c.SelectSingleNode("sPriority").InnerText)
                    });
            }

            return fbCases;
        }

        public string XmlToFogBugzToken(XmlDocument xml)
        {
            string token = null;

            try
            {
                XmlNode tokenNode = xml.SelectSingleNode("/response/token");
                token = tokenNode.InnerText;

                return token;
            }
            catch
            {
                return token;
            }
        }

        public string XmlToFogBugzApiUrl(XmlDocument xml)
        {
            string url = null;

            try
            {
                XmlNode tokenNode = xml.SelectSingleNode("/response/url");
                url = tokenNode.InnerText;

                return url;
            }
            catch
            {
                return url;
            }
        }
    }
}
