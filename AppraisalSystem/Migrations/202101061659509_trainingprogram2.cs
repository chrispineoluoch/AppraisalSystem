namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class trainingprogram2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.traininganddevelopmentplans", "SupervisorName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.traininganddevelopmentplans", "SupervisorName");
        }
    }
}
