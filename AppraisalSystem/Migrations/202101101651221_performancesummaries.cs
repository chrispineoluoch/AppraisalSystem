namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class performancesummaries : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.performancesummaries", "UserName", c => c.String());
            AddColumn("dbo.performancesummaries", "FullName", c => c.String());
            AddColumn("dbo.performancesummaries", "SupervisorName", c => c.String());
            AddColumn("dbo.performancesummaries", "TotalScore", c => c.Int(nullable: false));
            AddColumn("dbo.performancesummaries", "SubmissionDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.performancesummaries", "SubmissionDate");
            DropColumn("dbo.performancesummaries", "TotalScore");
            DropColumn("dbo.performancesummaries", "SupervisorName");
            DropColumn("dbo.performancesummaries", "FullName");
            DropColumn("dbo.performancesummaries", "UserName");
        }
    }
}
