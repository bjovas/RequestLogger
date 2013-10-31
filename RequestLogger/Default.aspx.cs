using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ExtensionMethods;
using System.Web.UI;
using System.Web.UI.WebControls;
using log4net;

namespace RequestLogger
{
    public partial class Default : System.Web.UI.Page
    {
        private static ILog log = LogManager.GetLogger("Default");

        protected void Page_Load(object sender, EventArgs e)
        {
            var request = HttpContext.Current.Request;
            log.Info("Receiving request...");
            log.Info(request.ToRaw());

            Response.StatusCode = 200;
            Response.StatusDescription = "OK";
        }
    }
}