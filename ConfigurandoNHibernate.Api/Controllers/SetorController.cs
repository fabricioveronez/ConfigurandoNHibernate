using ConfigurandoNHibernate.Api.Entidades;
using Microsoft.AspNetCore.Mvc;
using NHibernate;

namespace ConfigurandoNHibernate.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SetorController : ControllerBase
    {
        public ActionResult Post([FromBody] Setor setor, [FromServices] ISession session)
        {
            session.Save(setor);
            return Ok();
        }
    }
}