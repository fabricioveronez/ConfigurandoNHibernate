﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurandoNHibernate.Api.Entidades
{
    public class Funcionario
    {
        public Funcionario()
        {
            this.Dominios = new List<Dominio>();
        }

        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Matricula { get; set; }
        public virtual Setor Setor { get; set; }
        public virtual IList<Dominio> Dominios { get; set; }
    }
}
