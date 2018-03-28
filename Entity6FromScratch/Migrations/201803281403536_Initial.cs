namespace Entity6FromScratch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Families",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Version = c.Single(nullable: false),
                        S = c.String(),
                        Family_Id = c.Int(),
                        Vendor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Families", t => t.Family_Id)
                .ForeignKey("dbo.Vendors", t => t.Vendor_Id)
                .Index(t => t.Family_Id)
                .Index(t => t.Vendor_Id);
            
            CreateTable(
                "dbo.Vendors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        YearEstablished = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Vendor_Id", "dbo.Vendors");
            DropForeignKey("dbo.Products", "Family_Id", "dbo.Families");
            DropIndex("dbo.Products", new[] { "Vendor_Id" });
            DropIndex("dbo.Products", new[] { "Family_Id" });
            DropTable("dbo.Vendors");
            DropTable("dbo.Products");
            DropTable("dbo.Families");
        }
    }
}
