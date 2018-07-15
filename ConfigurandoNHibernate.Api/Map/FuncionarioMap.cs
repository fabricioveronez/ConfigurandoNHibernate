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
        }
    }
}
