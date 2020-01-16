using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace ChallengeLemonwayAPI.ServiceCore
{
    public static class XmlToJson
    {
        public static string Convert(string xml)
        {
            XmlDocument doc = new XmlDocument();
            string response;
            try
            {
                doc.LoadXml(xml);
                response = Newtonsoft.Json.JsonConvert.SerializeXmlNode(doc);
            }
            catch (XmlException)
            {
                response = "Bad Xml format";
            }
            return response;
        }
    }
}