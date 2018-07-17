using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurandoNHibernate.Api.Entidades
{
    public class Dominio
    {
        public Dominio()
        {
            this.Funcionarios = new List<Funcionario>();
        }

        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Descricao { get; set; }
        public virtual IList<Funcionario> Funcionarios { get; set; }
    }
}
