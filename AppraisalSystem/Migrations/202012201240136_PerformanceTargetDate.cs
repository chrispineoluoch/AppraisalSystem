namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PerformanceTargetDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.performancetargets", "PTDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.performancetargets", "PTDate");
        }
    }
}
