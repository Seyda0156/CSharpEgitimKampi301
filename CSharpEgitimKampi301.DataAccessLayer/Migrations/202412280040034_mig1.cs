namespace CSharpEgitimKampi301.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "CategoryStatus", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Products", "ProductStock", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "ProductPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "ProductPrice", c => c.String());
            AlterColumn("dbo.Products", "ProductStock", c => c.String());
            AlterColumn("dbo.Categories", "CategoryStatus", c => c.String());
        }
    }
}
