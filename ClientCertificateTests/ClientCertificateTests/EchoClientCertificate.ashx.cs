using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// https://docs.microsoft.com/en-us/azure/app-service-web/app-service-web-configure-tls-mutual-auth
// 
namespace ClientCertificateTests
{
    /// <summary>
    /// Summary description for EchoClientCertificate
    /// </summary>
    public class EchoClientCertificate : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string cert = context.Request.Headers["X-ARR-ClientCert"];

            context.Response.ContentType = "text/plain";
            context.Response.Write(cert);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
