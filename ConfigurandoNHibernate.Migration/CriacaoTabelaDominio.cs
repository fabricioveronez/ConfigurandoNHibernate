using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigurandoNHibernate.Migration
{
    [Migration(201807162100)]
    public class CriacaoTabelaDominio : MigrationBase
    {
        public override void Down()
        {
            
        }

        public override void Up()
        {
            Create.Table("Dominio")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("Nome").AsString().NotNullable()
                .WithColumn("Descricao").AsString().NotNullable();            
        }
    }
}
