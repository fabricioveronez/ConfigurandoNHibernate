using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurandoNHibernate.Api.Entidades
{
    public class Funcionario
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Matricula { get; set; }
    }
}
