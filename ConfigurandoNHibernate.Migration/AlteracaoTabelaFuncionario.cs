using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigurandoNHibernate.Migration
{
    [Migration(201807152110)]
    public class AlteracaoTabelaFuncionario : MigrationBase
    {
        public override void Down()
        {
            
        }

        public override void Up()
        {
            Alter.Table("Funcionario")
               .AddColumn("SetorId").AsInt32().Nullable();

            Create.ForeignKey("fk_Funcionario_Setor")
                .FromTable("Funcionario").ForeignColumn("SetorId")
                .ToTable("Setor").PrimaryColumn("Id");
        }
    }
}
