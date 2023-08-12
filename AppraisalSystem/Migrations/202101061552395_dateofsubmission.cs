namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dateofsubmission : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.traininganddevelopmentplans", "DateofSubmission", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.traininganddevelopmentplans", "DateofSubmission");
        }
    }
}
