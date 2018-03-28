namespace Entity6FromScratch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsCompanyPublicProper : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vendors", "IsPublicCompany", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vendors", "IsPublicCompany");
        }
    }
}
