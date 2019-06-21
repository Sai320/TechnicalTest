namespace TechnicalTest.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TechnialTest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProdutPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductImage = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Registers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Gender = c.String(),
                        City = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        ConfirmedPassword = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Registers");
            DropTable("dbo.Products");
            DropTable("dbo.Cities");
        }
    }
}
