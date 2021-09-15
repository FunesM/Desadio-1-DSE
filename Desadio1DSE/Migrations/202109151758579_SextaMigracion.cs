namespace Desadio1DSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SextaMigracion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoTransaccion",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.CuentaBancaria", "Moneda", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CuentaBancaria", "Moneda");
            DropTable("dbo.TipoTransaccion");
        }
    }
}
