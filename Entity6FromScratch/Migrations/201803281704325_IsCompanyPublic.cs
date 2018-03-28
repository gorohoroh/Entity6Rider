namespace Entity6FromScratch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsCompanyPublic : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vendors", "IdPublicCompany", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vendors", "IdPublicCompany");
        }
    }
}
