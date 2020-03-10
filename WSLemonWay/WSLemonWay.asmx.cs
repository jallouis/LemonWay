using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;

namespace WSLemonWay
{
    /// <summary>
    /// Description résumée de WSLemonWay
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    public partial class WebService1 : System.Web.Services.WebService
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [WebMethod]
        public int Fibonacci(int n)
        {
            if (n < 1 || n > 100)
            {
                log.Error("WS Fibonacci called with parameter : " + n + ". - Parameter must be >0 and <= 100");
                return -1;
            }

            log.Info("WS Fibonacci called with parameter : " + n);

            int penultieme = 1;
            int antepenultieme = 0;
            int tmp = 0;

            for (int i= 0; i<n; i++)
            {
                tmp = antepenultieme;
                antepenultieme = penultieme;
                penultieme = tmp + penultieme;
            }

            log.Info("WS Fibonacci returned : " + antepenultieme);
            return antepenultieme;
        }



        [WebMethod]
        public string XmlToJson(string xmlString)
        {
            try
            {
                log.Info("WS XmlToJson called with parameter : " + xmlString);

                XmlDocument doc = new XmlDocument();

                doc.LoadXml(xmlString);
                                             
                foreach (XmlElement el in doc.SelectNodes(".//*"))
                {
                    el.Attributes.RemoveAll();
                }



                string json = JsonConvert.SerializeXmlNode(doc);

                log.Info("WS XmlToJson returned : " + json);
                return json;
            }
            catch(Exception)
            {
                log.Error("Bad XML format");
                return "Bad Xml format";
            }
        }
    }
}
