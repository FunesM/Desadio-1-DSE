namespace Desadio1DSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrimeraMigracion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombres = c.String(nullable: false, maxLength: 200),
                        primerApellido = c.String(nullable: false, maxLength: 100),
                        segudnoApellido = c.String(maxLength: 100),
                        Telefono = c.String(nullable: false, maxLength: 20),
                        Email = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cliente");
        }
    }
}
