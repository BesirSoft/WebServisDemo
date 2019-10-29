using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServisDemo
{
    /// <summary>
    /// Summary description for CalcoaltiorWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalcoaltiorWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string Toplamaservisi(int valuone, int valoscond ,string secondersi)
        {
            return valuone + valoscond+secondersi;
        }
    }
}
