namespace Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelasRelacionadas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MRoles",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MServicoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Tamanho_Tattoo = c.String(nullable: false),
                        Local_Corpo = c.String(nullable: false),
                        Forma_Pagamento = c.String(nullable: false),
                        Data_servico = c.DateTime(nullable: false),
                        Descricao = c.String(),
                        Image_Perfil = c.String(),
                        Confirmar_Servico = c.Boolean(nullable: false),
                        IdUsuario = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.MUsuarios", t => t.IdUsuario, cascadeDelete: true)
                .Index(t => t.IdUsuario);
            
            CreateTable(
                "dbo.MUsuarios",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Username = c.String(nullable: false),
                        Senha = c.String(nullable: false),
                        Nome = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Numero_Tell = c.Int(nullable: false),
                        Instagram = c.String(),
                        Data_Nascimento = c.DateTime(nullable: false),
                        Sexo = c.String(nullable: false),
                        IdPerfil = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MServicoes", "IdUsuario", "dbo.MUsuarios");
            DropIndex("dbo.MServicoes", new[] { "IdUsuario" });
            DropTable("dbo.MUsuarios");
            DropTable("dbo.MServicoes");
            DropTable("dbo.MRoles");
        }
    }
}
