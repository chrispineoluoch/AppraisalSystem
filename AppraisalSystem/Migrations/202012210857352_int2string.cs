namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class int2string : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.valuesandcompetencies", "TeamSpirit", c => c.String());
            AlterColumn("dbo.valuesandcompetencies", "Integrity", c => c.String());
            AlterColumn("dbo.valuesandcompetencies", "InitiativeandSelfdrive", c => c.String());
            AlterColumn("dbo.valuesandcompetencies", "InterpersonalRelations", c => c.String());
            AlterColumn("dbo.valuesandcompetencies", "PunctualityandAttendance", c => c.String());
            AlterColumn("dbo.valuesandcompetencies", "TechnicalCompetencies", c => c.String());
            AlterColumn("dbo.valuesandcompetencies", "DependabilityandResourcefulness", c => c.String());
            AlterColumn("dbo.valuesandcompetencies", "ResourceManagement", c => c.String());
            AlterColumn("dbo.valuesandcompetencies", "DeliveryandPromptness", c => c.String());
            AlterColumn("dbo.valuesandcompetencies", "AttitudetoWorkandColleagues", c => c.String());
            AlterColumn("dbo.valuesandcompetencies", "TotalScore", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.valuesandcompetencies", "TotalScore", c => c.Int(nullable: false));
            AlterColumn("dbo.valuesandcompetencies", "AttitudetoWorkandColleagues", c => c.Int(nullable: false));
            AlterColumn("dbo.valuesandcompetencies", "DeliveryandPromptness", c => c.Int(nullable: false));
            AlterColumn("dbo.valuesandcompetencies", "ResourceManagement", c => c.Int(nullable: false));
            AlterColumn("dbo.valuesandcompetencies", "DependabilityandResourcefulness", c => c.Int(nullable: false));
            AlterColumn("dbo.valuesandcompetencies", "TechnicalCompetencies", c => c.Int(nullable: false));
            AlterColumn("dbo.valuesandcompetencies", "PunctualityandAttendance", c => c.Int(nullable: false));
            AlterColumn("dbo.valuesandcompetencies", "InterpersonalRelations", c => c.Int(nullable: false));
            AlterColumn("dbo.valuesandcompetencies", "InitiativeandSelfdrive", c => c.Int(nullable: false));
            AlterColumn("dbo.valuesandcompetencies", "Integrity", c => c.Int(nullable: false));
            AlterColumn("dbo.valuesandcompetencies", "TeamSpirit", c => c.Int(nullable: false));
        }
    }
}
