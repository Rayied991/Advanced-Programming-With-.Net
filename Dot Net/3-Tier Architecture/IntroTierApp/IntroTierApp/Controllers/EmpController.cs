using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;

namespace IntroTierApp.Controllers
{
    public class EmpController : ApiController
    {
        [HttpGet]
        [Route("api/employees")]

        public HttpResponseMessage get()
        {
            try
            {
               return Request.CreateResponse(HttpStatusCode.OK, EmployeeService.Get());
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }


    }
}
