namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PFNumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "PFNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "PFNumber");
        }
    }
}
