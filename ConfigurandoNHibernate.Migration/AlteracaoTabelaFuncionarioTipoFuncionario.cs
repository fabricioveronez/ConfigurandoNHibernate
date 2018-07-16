using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigurandoNHibernate.Migration
{
    [Migration(201807152156)]
    public class AlteracaoTabelaFuncionarioTipoFuncionario : MigrationBase
    {
        public override void Down()
        {

        }

        public override void Up()
        {
            Alter.Table("Funcionario")
               .AddColumn("TipoFuncionario").AsString().Nullable();

            Create.ForeignKey("fk_Funcionario_Diretor")
               .FromTable("Diretor").ForeignColumn("DiretorId")
               .ToTable("Funcionario").PrimaryColumn("Id");
        }
    }
}
