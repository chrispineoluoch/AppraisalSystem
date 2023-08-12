namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class performancesummaries2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.performancesummaries", "PerformanceTargetScore", c => c.Int(nullable: false));
            AddColumn("dbo.performancesummaries", "ValuesandCompetenciesScore", c => c.Int(nullable: false));
            DropColumn("dbo.performancesummaries", "PerformanceTargets");
            DropColumn("dbo.performancesummaries", "ValuesandCompetencies");
        }
        
        public override void Down()
        {
            AddColumn("dbo.performancesummaries", "ValuesandCompetencies", c => c.Int(nullable: false));
            AddColumn("dbo.performancesummaries", "PerformanceTargets", c => c.Int(nullable: false));
            DropColumn("dbo.performancesummaries", "ValuesandCompetenciesScore");
            DropColumn("dbo.performancesummaries", "PerformanceTargetScore");
        }
    }
}
