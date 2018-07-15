using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigurandoNHibernate.Migration
{
    [Migration(201807151849)]
    public class CriacaoTabelaFuncionario : MigrationBase
    {
        public override void Down()
        {
            
        }

        public override void Up()
        {
            Create.Table("Funcionario")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("Nome").AsString().NotNullable()
                .WithColumn("Matricula").AsString().NotNullable();
        }
    }
}
