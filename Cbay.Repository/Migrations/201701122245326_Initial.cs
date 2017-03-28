namespace Cbay.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Product", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Product", "ImageUrl");
            DropColumn("dbo.Product", "Quantity");
        }
    }
}
