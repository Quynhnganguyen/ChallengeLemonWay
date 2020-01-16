using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Web;
using System.Web.Services;

namespace ChallengeLemonwayAPI
{
    /// <summary>
    /// Summary description for ChallengeLemonwayService
    /// </summary>
    [WebService(Namespace = "http://ChallengeLemonway.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ChallengeLemonwayService : System.Web.Services.WebService
    {


        [WebMethod]
        public string Fibonacci(int n)
        {
            System.Threading.Thread.Sleep(2000);
            BigInteger response = ServiceCore.Fibonacci.Calculate(n);
            return response.ToString();
        }

        [WebMethod]
        public string XmlToJson(string xml)
        {
            string response = ServiceCore.XmlToJson.Convert(xml);
            return response;
        }
    }
}
