namespace MvcApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changetelephonenumbertostring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rentals", "TelephoneNumber", c => c.String());
            AlterColumn("dbo.Renters", "TelephoneNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Renters", "TelephoneNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.Rentals", "TelephoneNumber", c => c.Int(nullable: false));
        }
    }
}
