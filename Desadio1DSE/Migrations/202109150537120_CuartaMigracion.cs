namespace Desadio1DSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CuartaMigracion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoCuentaBancaria",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        TipoCuenta = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TipoCuentaBancaria");
        }
    }
}
