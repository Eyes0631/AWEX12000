using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CommonObj
{
    public static class HtmlObjectSerializer
    {
        public static List<XmlNode> GetData(string htmlData, string TagName)
        {
            List<XmlNode> list_data = new List<XmlNode>();
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(htmlData);

            var nodes = xmlDocument.GetElementsByTagName(TagName);
            foreach (XmlNode node in nodes)
            {
                list_data.Add(node);
            }

            return list_data;
        }

        public static string GetAttributeValue(XmlNode node, string attributeName)
        {
            XmlAttribute attribute = node.Attributes[attributeName];
            return attribute != null ? attribute.Value : "";
        }

        public static XmlNamespaceManager GetNamespaceManager(XmlDocument doc)
        {
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
            nsmgr.AddNamespace("z", "#RowsetSchema");
            return nsmgr;
        }
    }
}
