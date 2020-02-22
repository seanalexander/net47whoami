using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace net47whoami.Controllers
{
    public class HealthzController : ApiController
    {
        // GET api/<controller>   : url to use => api/vs
        public HttpResponseMessage Get()
        {
            string machine_name = Environment.MachineName;
            HttpContext.Current.Response.Headers.Add("x-whoami", machine_name);
            var response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Content = new StringContent(machine_name);
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/plain");
            return response;
        }
    }
}
