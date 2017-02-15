using DDDAngular.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DDDAngular.Service.Controllers
{
    [EnableCorsAttribute("http://localhost:3438", "*", "*")]
    public class TesteController : ApiController
    {
        [Route("api/ApiHomeController/CarregaElementosBabacas")]
        public IHttpActionResult CarregaElementosBabacas()
        {
            IHttpActionResult ret = null;
            List<ElementosBabacasViewModel> model = new List<ElementosBabacasViewModel>();

            for (int i = 3; i < 9; i++)
            {
                ElementosBabacasViewModel e = new ElementosBabacasViewModel();
                e.Id = i;
                e.Nome = "TesteNome" + i;
                e.Idade = 20 + i;
                e.Dindin = 50m + i;
                e.Data = DateTime.Now.AddDays(5 * i);
                model.Add(e);
            }
            ret = Ok(model);
            return ret;
        }
    }
}
