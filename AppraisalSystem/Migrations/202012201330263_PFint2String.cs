namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PFint2String : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.apraiseecomments", "PFNumber", c => c.String());
            AlterColumn("dbo.performancesummaries", "PFNumber", c => c.String());
            AlterColumn("dbo.performancetargets", "PFNumber", c => c.String());
            AlterColumn("dbo.personaldetails", "PFNumber", c => c.String());
            AlterColumn("dbo.supervisorcomments", "PFNumber", c => c.String());
            AlterColumn("dbo.traininganddevelopmentplans", "PFNumber", c => c.String());
            AlterColumn("dbo.valuesandcompetencies", "PFNumber", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.valuesandcompetencies", "PFNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.traininganddevelopmentplans", "PFNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.supervisorcomments", "PFNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.personaldetails", "PFNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.performancetargets", "PFNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.performancesummaries", "PFNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.apraiseecomments", "PFNumber", c => c.Int(nullable: false));
        }
    }
}
