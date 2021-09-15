namespace Desadio1DSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TerceraMigracion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transacciones",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        tipoTransaccion = c.String(nullable: false, maxLength: 100),
                        Monto = c.Int(nullable: false),
                        Estado = c.String(nullable: false, maxLength: 20),
                        fechaTransaccion = c.DateTime(nullable: false),
                        fechaAplicacion = c.DateTime(nullable: false),
                        CuentaBancaria_id = c.Int(),
                        CuentaBancaria_id1 = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.CuentaBancaria", t => t.CuentaBancaria_id1)
                .Index(t => t.CuentaBancaria_id1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transacciones", "CuentaBancaria_id1", "dbo.CuentaBancaria");
            DropIndex("dbo.Transacciones", new[] { "CuentaBancaria_id1" });
            DropTable("dbo.Transacciones");
        }
    }
}
