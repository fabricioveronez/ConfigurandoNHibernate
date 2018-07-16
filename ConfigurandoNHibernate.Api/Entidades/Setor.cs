using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurandoNHibernate.Api.Entidades
{
    public class Setor
    {

        public Setor ()
        {
            this.Funcionarios = new List<Funcionario>();
        }

        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual IList<Funcionario> Funcionarios { get; set; }
    }
}
