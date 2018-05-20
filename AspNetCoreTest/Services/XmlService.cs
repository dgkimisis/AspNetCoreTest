using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace AspNetCoreTest.Services
{
    public class XmlService
    {
        public void SaveXMLAttribute(int entityId, string key)
        {
            XmlDocument _xmldoc = new XmlDocument();
        }


        public string ParseXMLAttribute(int entityId, string key, string xmlvalue)
        {
            return "abc";
        }

        public string ParseXMLAttributeValue(int entityId, string key, string xmlvalue)
        {
            return "abc";
        }
    }
}
