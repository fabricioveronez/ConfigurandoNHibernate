using ConfigurandoNHibernate.Api.Entidades;
using FluentNHibernate.Mapping;


namespace ConfigurandoNHibernate.Api.Map
{
    public class SetorMap : ClassMap<Setor>
    {
        public SetorMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Nome).Not.Nullable();
            HasMany(x => x.Funcionarios).KeyColumn("SetorId").Cascade.All();
        }
    }
}
