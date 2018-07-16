using ConfigurandoNHibernate.Api.Entidades;
using Microsoft.AspNetCore.Mvc;
using NHibernate;

namespace ConfigurandoNHibernate.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiretorController : ControllerBase
    {
        public ActionResult Post([FromBody] Diretor diretor, [FromServices] ISession session)
        {
            diretor.Setor = session.Load<Setor>(diretor.Setor.Id);
            session.Save(diretor);
            return Ok();
        }
    }
}