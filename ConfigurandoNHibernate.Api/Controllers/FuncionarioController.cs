using ConfigurandoNHibernate.Api.Entidades;
using Microsoft.AspNetCore.Mvc;
using NHibernate;

namespace ConfigurandoNHibernate.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        public ActionResult Post([FromBody] Funcionario funcionario, [FromServices] ISession session)
        {
            funcionario.Setor = session.Load<Setor>(funcionario.Setor.Id);
            session.Save(funcionario);
            return Ok();
        }

        [HttpPut("{idFuncionario}/dominio")]
        public ActionResult AdicionarDominios([FromRoute] int idFuncionario, [FromBody] Dominio dominio, [FromServices] ISession session)
        {
            Funcionario func = session.Get<Funcionario>(idFuncionario);
            func.Dominios.Add(dominio);
            session.Save(func);
            return Ok();
        }
    }
}