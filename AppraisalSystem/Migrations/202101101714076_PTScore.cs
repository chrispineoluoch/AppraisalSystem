namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PTScore : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.performancetargets", "PTTotalScore", c => c.Int());
            DropColumn("dbo.performancetargets", "TotalScore");
        }
        
        public override void Down()
        {
            AddColumn("dbo.performancetargets", "TotalScore", c => c.Int());
            DropColumn("dbo.performancetargets", "PTTotalScore");
        }
    }
}
