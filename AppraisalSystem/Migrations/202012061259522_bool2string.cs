namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bool2string : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.apraiseecomments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PFNumber = c.Int(nullable: false),
                        FinancialYear = c.String(),
                        DiscussionConfirmation = c.Boolean(nullable: false),
                        AppraiseeComments = c.String(),
                        AppraiseeDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.performancesummaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PFNumber = c.Int(nullable: false),
                        FinancialYear = c.String(),
                        performancetargets = c.Int(nullable: false),
                        valuesandcompetencies = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.performancetargets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PFNumber = c.Int(nullable: false),
                        FinancialYear = c.String(),
                        Project = c.Boolean(nullable: false),
                        Objective = c.String(),
                        Target = c.String(),
                        KPI = c.String(),
                        ResultsAchieved = c.String(),
                        IndividualRating = c.String(),
                        SupervisorRating = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.supervisorcomments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PFNumber = c.Int(nullable: false),
                        FinancialYear = c.String(),
                        EmployeeStrengths = c.String(),
                        EmployeeDifficulties = c.String(),
                        SupervisorPerformanceComments = c.String(),
                        SupervisorName = c.String(),
                        SupervisorDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.traininganddevelopmentplans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PFNumber = c.Int(nullable: false),
                        FinancialYear = c.String(),
                        TrainingProgram = c.String(),
                        days = c.Int(nullable: false),
                        ApraiseeComents = c.String(),
                        HODComments = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.valuesandcompetencies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PFNumber = c.Int(nullable: false),
                        FinancialYear = c.String(),
                        TeamSpirit = c.Boolean(nullable: false),
                        Integrity = c.Boolean(nullable: false),
                        InitiativeandSelfdrive = c.Boolean(nullable: false),
                        InterpersonalRelations = c.Boolean(nullable: false),
                        PunctualityandAttendance = c.Boolean(nullable: false),
                        TechnicalCompetencies = c.Boolean(nullable: false),
                        DependabilityandResourcefulness = c.Boolean(nullable: false),
                        ResourceManagement = c.Boolean(nullable: false),
                        DeliveryandPromptness = c.Boolean(nullable: false),
                        AttitudetoWorkandColleagues = c.Boolean(nullable: false),
                        TotalScore = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.personaldetails", "NatureofEmployment", c => c.String());
            AlterColumn("dbo.personaldetails", "StaffCategory", c => c.String());
            DropColumn("dbo.personaldetails", "DateFrom");
            DropColumn("dbo.personaldetails", "DateTo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.personaldetails", "DateTo", c => c.DateTime());
            AddColumn("dbo.personaldetails", "DateFrom", c => c.DateTime());
            AlterColumn("dbo.personaldetails", "StaffCategory", c => c.Boolean(nullable: false));
            AlterColumn("dbo.personaldetails", "NatureofEmployment", c => c.Boolean(nullable: false));
            DropTable("dbo.valuesandcompetencies");
            DropTable("dbo.traininganddevelopmentplans");
            DropTable("dbo.supervisorcomments");
            DropTable("dbo.performancetargets");
            DropTable("dbo.performancesummaries");
            DropTable("dbo.apraiseecomments");
        }
    }
}
