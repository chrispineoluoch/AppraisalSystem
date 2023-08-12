namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class trainingprogram : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.traininganddevelopmentplans", "TrainingInstitute", c => c.String());
            AddColumn("dbo.traininganddevelopmentplans", "TotalCost", c => c.String());
            AddColumn("dbo.traininganddevelopmentplans", "NumberofDays", c => c.String());
            DropColumn("dbo.traininganddevelopmentplans", "days");
        }
        
        public override void Down()
        {
            AddColumn("dbo.traininganddevelopmentplans", "days", c => c.Int(nullable: false));
            DropColumn("dbo.traininganddevelopmentplans", "NumberofDays");
            DropColumn("dbo.traininganddevelopmentplans", "TotalCost");
            DropColumn("dbo.traininganddevelopmentplans", "TrainingInstitute");
        }
    }
}
