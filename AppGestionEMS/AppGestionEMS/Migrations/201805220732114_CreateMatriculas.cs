namespace AppGestionEMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMatriculas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Matriculas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Fecha = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Matriculas");
        }
    }
}
