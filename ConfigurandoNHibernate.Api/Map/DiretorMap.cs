using System;
using ConfigurandoNHibernate.Api.Entidades;
using FluentNHibernate.Mapping;


namespace ConfigurandoNHibernate.Api.Map
{
    public class DiretorMap : SubclassMap<Diretor>
    {
        public DiretorMap()
        {
            Join("Diretor", x =>
            {
                x.KeyColumn("DiretorId");
                x.Map(c => c.Bonus);
                DiscriminatorValue("Diretor");
            });
        }
    }
}
