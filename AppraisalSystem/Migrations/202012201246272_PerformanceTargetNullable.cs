namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PerformanceTargetNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.performancetargets", "IndividualRating", c => c.Int());
            AlterColumn("dbo.performancetargets", "SupervisorRating", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.performancetargets", "SupervisorRating", c => c.Int(nullable: false));
            AlterColumn("dbo.performancetargets", "IndividualRating", c => c.Int(nullable: false));
        }
    }
}
