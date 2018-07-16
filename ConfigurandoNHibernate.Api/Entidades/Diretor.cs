using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurandoNHibernate.Api.Entidades
{
    public class Diretor : Funcionario
    {
        public virtual decimal Bonus { get; set; }
    }
}
