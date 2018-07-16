using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigurandoNHibernate.Migration
{
    [Migration(201807152058)]
    public class CriacaoTabelaSetor : MigrationBase
    {
        public override void Down()
        {
            
        }

        public override void Up()
        {
            Create.Table("Setor")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("Nome").AsString().NotNullable();          
        }
    }
}
