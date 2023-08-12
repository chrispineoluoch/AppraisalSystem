namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bool2intVCProject : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.valuesandcompetencies", "TeamSpirit", c => c.Int(nullable: false));
            AlterColumn("dbo.valuesandcompetencies", "Integrity", c => c.Int(nullable: false));
            AlterColumn("dbo.valuesandcompetencies", "InitiativeandSelfdrive", c => c.Int(nullable: false));
            AlterColumn("dbo.valuesandcompetencies", "InterpersonalRelations", c => c.Int(nullable: false));
            AlterColumn("dbo.valuesandcompetencies", "PunctualityandAttendance", c => c.Int(nullable: false));
            AlterColumn("dbo.valuesandcompetencies", "TechnicalCompetencies", c => c.Int(nullable: false));
            AlterColumn("dbo.valuesandcompetencies", "DependabilityandResourcefulness", c => c.Int(nullable: false));
            AlterColumn("dbo.valuesandcompetencies", "ResourceManagement", c => c.Int(nullable: false));
            AlterColumn("dbo.valuesandcompetencies", "DeliveryandPromptness", c => c.Int(nullable: false));
            AlterColumn("dbo.valuesandcompetencies", "AttitudetoWorkandColleagues", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.valuesandcompetencies", "AttitudetoWorkandColleagues", c => c.Boolean(nullable: false));
            AlterColumn("dbo.valuesandcompetencies", "DeliveryandPromptness", c => c.Boolean(nullable: false));
            AlterColumn("dbo.valuesandcompetencies", "ResourceManagement", c => c.Boolean(nullable: false));
            AlterColumn("dbo.valuesandcompetencies", "DependabilityandResourcefulness", c => c.Boolean(nullable: false));
            AlterColumn("dbo.valuesandcompetencies", "TechnicalCompetencies", c => c.Boolean(nullable: false));
            AlterColumn("dbo.valuesandcompetencies", "PunctualityandAttendance", c => c.Boolean(nullable: false));
            AlterColumn("dbo.valuesandcompetencies", "InterpersonalRelations", c => c.Boolean(nullable: false));
            AlterColumn("dbo.valuesandcompetencies", "InitiativeandSelfdrive", c => c.Boolean(nullable: false));
            AlterColumn("dbo.valuesandcompetencies", "Integrity", c => c.Boolean(nullable: false));
            AlterColumn("dbo.valuesandcompetencies", "TeamSpirit", c => c.Boolean(nullable: false));
        }
    }
}
