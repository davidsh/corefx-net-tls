using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ClientCertificateTests
{
    /// <summary>
    /// Summary description for Echo
    /// </summary>
    public class Echo : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            var headers = context.Request.Headers;

            var buffer = new StringBuilder();
            foreach (string key in headers.Keys)
            {
                buffer.Append($"{key}: ");
                foreach (var value in headers.GetValues(key))
                {
                    buffer.Append($"{value} ");
                }
                buffer.AppendLine();
            }

            context.Response.ContentType = "text/plain";
            context.Response.Write(buffer.ToString());
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