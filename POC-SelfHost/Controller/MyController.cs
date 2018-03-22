using System.Threading;
using System.Web.Http;

namespace POC_SelfHost.Controller {

    [RoutePrefix("api/my-poc")]
    public class MyController: ApiController {

        [HttpGet]
        [Route("get")]
        public string Get()
        {
            Thread.Sleep(1000);

            return "OK";
        }
    }
}
