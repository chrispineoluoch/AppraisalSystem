namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class performancetargets : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.performancetargets", "FullName", c => c.String());
            AddColumn("dbo.performancetargets", "SupervisorName", c => c.String());
            AddColumn("dbo.performancetargets", "Objective_1", c => c.String());
            AddColumn("dbo.performancetargets", "Target_1", c => c.String());
            AddColumn("dbo.performancetargets", "IndividualRating_1", c => c.Int());
            AddColumn("dbo.performancetargets", "SupervisorRating_1", c => c.Int());
            AddColumn("dbo.performancetargets", "Objective_2", c => c.String());
            AddColumn("dbo.performancetargets", "Target_2", c => c.String());
            AddColumn("dbo.performancetargets", "IndividualRating_2", c => c.Int());
            AddColumn("dbo.performancetargets", "SupervisorRating_2", c => c.Int());
            AddColumn("dbo.performancetargets", "Objective_3", c => c.String());
            AddColumn("dbo.performancetargets", "Target_3", c => c.String());
            AddColumn("dbo.performancetargets", "IndividualRating_3", c => c.Int());
            AddColumn("dbo.performancetargets", "SupervisorRating_3", c => c.Int());
            AddColumn("dbo.performancetargets", "Objective_4", c => c.String());
            AddColumn("dbo.performancetargets", "Target_4", c => c.String());
            AddColumn("dbo.performancetargets", "IndividualRating_4", c => c.Int());
            AddColumn("dbo.performancetargets", "SupervisorRating_4", c => c.Int());
            AddColumn("dbo.performancetargets", "Objective_5", c => c.String());
            AddColumn("dbo.performancetargets", "Target_5", c => c.String());
            AddColumn("dbo.performancetargets", "IndividualRating_5", c => c.Int());
            AddColumn("dbo.performancetargets", "SupervisorRating_5", c => c.Int());
            AddColumn("dbo.performancetargets", "Objective_6", c => c.String());
            AddColumn("dbo.performancetargets", "Target_6", c => c.String());
            AddColumn("dbo.performancetargets", "IndividualRating_6", c => c.Int());
            AddColumn("dbo.performancetargets", "SupervisorRating_6", c => c.Int());
            AddColumn("dbo.performancetargets", "Objective_7", c => c.String());
            AddColumn("dbo.performancetargets", "Target_7", c => c.String());
            AddColumn("dbo.performancetargets", "IndividualRating_7", c => c.Int());
            AddColumn("dbo.performancetargets", "SupervisorRating_7", c => c.Int());
            AddColumn("dbo.performancetargets", "Objective_8", c => c.String());
            AddColumn("dbo.performancetargets", "Target_8", c => c.String());
            AddColumn("dbo.performancetargets", "IndividualRating_8", c => c.Int());
            AddColumn("dbo.performancetargets", "SupervisorRating_8", c => c.Int());
            AddColumn("dbo.performancetargets", "Objective_9", c => c.String());
            AddColumn("dbo.performancetargets", "Target_9", c => c.String());
            AddColumn("dbo.performancetargets", "IndividualRating_9", c => c.Int());
            AddColumn("dbo.performancetargets", "SupervisorRating_9", c => c.Int());
            AddColumn("dbo.performancetargets", "Objective_10", c => c.String());
            AddColumn("dbo.performancetargets", "Target_10", c => c.String());
            AddColumn("dbo.performancetargets", "IndividualRating_10", c => c.Int());
            AddColumn("dbo.performancetargets", "SupervisorRating_10", c => c.Int());
            AddColumn("dbo.performancetargets", "PTSettingDate", c => c.DateTime());
            AddColumn("dbo.performancetargets", "PTAppraisalDate", c => c.DateTime());
            AddColumn("dbo.performancetargets", "NumberofTargets", c => c.Int());
            AddColumn("dbo.performancetargets", "TotalScore", c => c.Int());
            DropColumn("dbo.performancetargets", "Project");
            DropColumn("dbo.performancetargets", "Objective");
            DropColumn("dbo.performancetargets", "Target");
            DropColumn("dbo.performancetargets", "KPI");
            DropColumn("dbo.performancetargets", "ResultsAchieved");
            DropColumn("dbo.performancetargets", "IndividualRating");
            DropColumn("dbo.performancetargets", "SupervisorRating");
            DropColumn("dbo.performancetargets", "PTDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.performancetargets", "PTDate", c => c.DateTime());
            AddColumn("dbo.performancetargets", "SupervisorRating", c => c.Int());
            AddColumn("dbo.performancetargets", "IndividualRating", c => c.Int());
            AddColumn("dbo.performancetargets", "ResultsAchieved", c => c.String());
            AddColumn("dbo.performancetargets", "KPI", c => c.String());
            AddColumn("dbo.performancetargets", "Target", c => c.String());
            AddColumn("dbo.performancetargets", "Objective", c => c.String());
            AddColumn("dbo.performancetargets", "Project", c => c.String());
            DropColumn("dbo.performancetargets", "TotalScore");
            DropColumn("dbo.performancetargets", "NumberofTargets");
            DropColumn("dbo.performancetargets", "PTAppraisalDate");
            DropColumn("dbo.performancetargets", "PTSettingDate");
            DropColumn("dbo.performancetargets", "SupervisorRating_10");
            DropColumn("dbo.performancetargets", "IndividualRating_10");
            DropColumn("dbo.performancetargets", "Target_10");
            DropColumn("dbo.performancetargets", "Objective_10");
            DropColumn("dbo.performancetargets", "SupervisorRating_9");
            DropColumn("dbo.performancetargets", "IndividualRating_9");
            DropColumn("dbo.performancetargets", "Target_9");
            DropColumn("dbo.performancetargets", "Objective_9");
            DropColumn("dbo.performancetargets", "SupervisorRating_8");
            DropColumn("dbo.performancetargets", "IndividualRating_8");
            DropColumn("dbo.performancetargets", "Target_8");
            DropColumn("dbo.performancetargets", "Objective_8");
            DropColumn("dbo.performancetargets", "SupervisorRating_7");
            DropColumn("dbo.performancetargets", "IndividualRating_7");
            DropColumn("dbo.performancetargets", "Target_7");
            DropColumn("dbo.performancetargets", "Objective_7");
            DropColumn("dbo.performancetargets", "SupervisorRating_6");
            DropColumn("dbo.performancetargets", "IndividualRating_6");
            DropColumn("dbo.performancetargets", "Target_6");
            DropColumn("dbo.performancetargets", "Objective_6");
            DropColumn("dbo.performancetargets", "SupervisorRating_5");
            DropColumn("dbo.performancetargets", "IndividualRating_5");
            DropColumn("dbo.performancetargets", "Target_5");
            DropColumn("dbo.performancetargets", "Objective_5");
            DropColumn("dbo.performancetargets", "SupervisorRating_4");
            DropColumn("dbo.performancetargets", "IndividualRating_4");
            DropColumn("dbo.performancetargets", "Target_4");
            DropColumn("dbo.performancetargets", "Objective_4");
            DropColumn("dbo.performancetargets", "SupervisorRating_3");
            DropColumn("dbo.performancetargets", "IndividualRating_3");
            DropColumn("dbo.performancetargets", "Target_3");
            DropColumn("dbo.performancetargets", "Objective_3");
            DropColumn("dbo.performancetargets", "SupervisorRating_2");
            DropColumn("dbo.performancetargets", "IndividualRating_2");
            DropColumn("dbo.performancetargets", "Target_2");
            DropColumn("dbo.performancetargets", "Objective_2");
            DropColumn("dbo.performancetargets", "SupervisorRating_1");
            DropColumn("dbo.performancetargets", "IndividualRating_1");
            DropColumn("dbo.performancetargets", "Target_1");
            DropColumn("dbo.performancetargets", "Objective_1");
            DropColumn("dbo.performancetargets", "SupervisorName");
            DropColumn("dbo.performancetargets", "FullName");
        }
    }
}
