namespace AppGestionEMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAsignacionDocente : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AsignacionDocentes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumCreditos = c.Int(nullable: false),
                        CursoId = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                        GrupoclasesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cursos", t => t.CursoId, cascadeDelete: true)
                .ForeignKey("dbo.GrupoClases", t => t.GrupoclasesId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.CursoId)
                .Index(t => t.UserId)
                .Index(t => t.GrupoclasesId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AsignacionDocentes", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AsignacionDocentes", "GrupoclasesId", "dbo.GrupoClases");
            DropForeignKey("dbo.AsignacionDocentes", "CursoId", "dbo.Cursos");
            DropIndex("dbo.AsignacionDocentes", new[] { "GrupoclasesId" });
            DropIndex("dbo.AsignacionDocentes", new[] { "UserId" });
            DropIndex("dbo.AsignacionDocentes", new[] { "CursoId" });
            DropTable("dbo.AsignacionDocentes");
        }
    }
}
