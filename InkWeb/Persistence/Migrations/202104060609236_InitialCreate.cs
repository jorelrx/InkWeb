namespace Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MUsuarios",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Username = c.String(nullable: false),
                        Senha = c.String(nullable: false),
                        Nome = c.String(nullable: false),
                        Sobrenome = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Numero_Tell = c.Int(nullable: false),
                        Instagram = c.String(),
                        Data_Nascimento = c.DateTime(nullable: false),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
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
                        IDUsuario = c.Long(),
                        Usuario_Id = c.Long(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.MUsuarios", t => t.Usuario_Id)
                .Index(t => t.Usuario_Id);
            
            CreateTable(
                "dbo.MAgendas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Dia = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MHorarios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        hora = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MServicoes", "Usuario_Id", "dbo.MUsuarios");
            DropIndex("dbo.MServicoes", new[] { "Usuario_Id" });
            DropTable("dbo.MHorarios");
            DropTable("dbo.MAgendas");
            DropTable("dbo.MServicoes");
            DropTable("dbo.MUsuarios");
        }
    }
}
