namespace Desadio1DSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuintaMigracion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CuentaBancaria", "TipoCuentaBancaria_Inv_id", c => c.Int());
            AlterColumn("dbo.CuentaBancaria", "Tipo", c => c.Int());
            CreateIndex("dbo.CuentaBancaria", "TipoCuentaBancaria_Inv_id");
            AddForeignKey("dbo.CuentaBancaria", "TipoCuentaBancaria_Inv_id", "dbo.TipoCuentaBancaria", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CuentaBancaria", "TipoCuentaBancaria_Inv_id", "dbo.TipoCuentaBancaria");
            DropIndex("dbo.CuentaBancaria", new[] { "TipoCuentaBancaria_Inv_id" });
            AlterColumn("dbo.CuentaBancaria", "Tipo", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.CuentaBancaria", "TipoCuentaBancaria_Inv_id");
        }
    }
}
