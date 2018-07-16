using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigurandoNHibernate.Migration
{
    [Migration(201807152151)]
    public class CriacaoTabelaDiretor : MigrationBase
    {
        public override void Down()
        {
            
        }

        public override void Up()
        {
            Create.Table("Diretor")
                .WithColumn("DiretorId").AsInt32().NotNullable()
                .WithColumn("Bonus").AsDecimal().NotNullable();
        }
    }
}
