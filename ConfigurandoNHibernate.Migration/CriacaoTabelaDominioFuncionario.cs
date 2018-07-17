using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigurandoNHibernate.Migration
{
    [Migration(201807162200)]
    public class CriacaoTabelaDominioFuncionario : MigrationBase
    {
        public override void Down()
        {
            
        }

        public override void Up()
        {
            Create.Table("DominioFuncionario")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("DominioId").AsInt32().NotNullable()
                .WithColumn("FuncionarioId").AsInt32().NotNullable();

            Create.ForeignKey("fk_Funcionario_DominioFuncionario")
               .FromTable("DominioFuncionario").ForeignColumn("FuncionarioId")
               .ToTable("Funcionario").PrimaryColumn("Id");

            Create.ForeignKey("fk_Dominio_DominioFuncionario")
               .FromTable("DominioFuncionario").ForeignColumn("DominioId")
               .ToTable("Dominio").PrimaryColumn("Id");
        }
    }
}
