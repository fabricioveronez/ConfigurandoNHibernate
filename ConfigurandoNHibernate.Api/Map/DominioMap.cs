using System;
using ConfigurandoNHibernate.Api.Entidades;
using FluentNHibernate.Mapping;


namespace ConfigurandoNHibernate.Api.Map
{
    public class DominioMap : ClassMap<Dominio>
    {
        public DominioMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();            
            Map(x => x.Nome).Not.Nullable();
            Map(x => x.Descricao).Not.Nullable();
            HasManyToMany(x => x.Funcionarios).Table("DominioFuncionario").ChildKeyColumn("DominioId").Cascade.All();
        }
    }
}
