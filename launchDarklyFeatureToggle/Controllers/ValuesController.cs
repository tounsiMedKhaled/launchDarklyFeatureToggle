using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaunchDarkly.Client;
using Microsoft.AspNetCore.Mvc;

namespace launchDarklyFeatureToggle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private LdClient ldClient;

        public ValuesController()
        {
            ldClient = new LdClient("sdk-638d5200-59cb-46a3-aaaa-0d38f30fd913");
        }
        // GET api/values
        [HttpGet]
        public ActionResult<bool> Get()
        {
            
            User user = LaunchDarkly.Client.User.WithKey("khaled");
            user.FirstName = Guid.NewGuid().ToString();
            bool showFeature = ldClient.BoolVariation("beta-feature", user, false);           
            return showFeature;
        }

       
    }
}
