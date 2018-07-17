using ConfigurandoNHibernate.Api.Entidades;
using Microsoft.AspNetCore.Mvc;
using NHibernate;

namespace ConfigurandoNHibernate.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DominioController : ControllerBase
    {
        public ActionResult Post([FromBody] Dominio dominio, [FromServices] ISession session)
        {
            session.Save(dominio);
            return Ok();
        }        
    }
}