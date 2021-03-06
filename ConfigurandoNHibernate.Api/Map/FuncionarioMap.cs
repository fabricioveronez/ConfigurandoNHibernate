﻿using System;
using ConfigurandoNHibernate.Api.Entidades;
using FluentNHibernate.Mapping;


namespace ConfigurandoNHibernate.Api.Map
{
    public class FuncionarioMap : ClassMap<Funcionario>
    {
        public FuncionarioMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Nome).Not.Nullable();
            Map(x => x.Matricula).Not.Nullable();
            References(x => x.Setor, "SetorId").Cascade.All();
            HasManyToMany(x => x.Dominios).Table("DominioFuncionario").ChildKeyColumn("FuncionarioId").Cascade.All();
            DiscriminateSubClassesOnColumn("TipoFuncionario");
        }
    }
}
